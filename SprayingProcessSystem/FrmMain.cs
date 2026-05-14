using HZY.Framework.DependencyInjection;
using IoTClient.Common.Enums;
using IoTClient.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MiniExcelLibs;
using SprayingProcessSystem.Pages;
using Sunny.UI;
using System.BLL;
using System.BLL.Manager;
using System.Helper;
using System.Model;
using System.Timers;
using Yale.SprayProcessSCADASystem;

namespace SprayingProcessSystem
{
    public partial class FrmMain : UIHeaderAsideMainFooterFrame, ISingletonSelfDependency
    {
        #region 成员变量
        private bool plcIsConnected = false;
        // CancellationTokenSource（取消令牌源）：用于控制后台线程的退出
        // 初始状态：IsCancellationRequested = false，后台循环正常运行
        // 调用 cts.Cancel() 后：IsCancellationRequested 变为 true（不可逆，不能变回false）
        // 但下次程序启动会 new 一个新的，天然就是false，所以不用担心
        private CancellationTokenSource cts = new CancellationTokenSource();
        private readonly ILogger<FrmMain> _logger;
        private System.Timers.Timer timer = new System.Timers.Timer();
        private Dictionary<string, Control> pageControls = new Dictionary<string, Control>
{
    { "设备总控", Globals.serviceProvider.GetRequiredService<PageTotalEquipmentControl>() },
    { "用户管理", Globals.serviceProvider.GetRequiredService<UserManage>() },
    { "权限管理", Globals.serviceProvider.GetRequiredService<PageAuthManage>() },
    { "设备监控1", Globals.serviceProvider.GetRequiredService<PageEquipmentMonitor>() },
    { "设备监控2", Globals.serviceProvider.GetRequiredService<PageEquipmentMonitor1>() },
    { "设备监控3", Globals.serviceProvider.GetRequiredService<PageEquipmentMonitor3>() },
    { "配方管理", Globals.serviceProvider.GetRequiredService<PageRecipeManage>() },
    { "日志管理", Globals.serviceProvider.GetRequiredService<PageLogManage>() },
    { "报表管理", Globals.serviceProvider.GetRequiredService<PageReportManage>() },
    { "图表管理", Globals.serviceProvider.GetRequiredService<PageChartManage>() },
    { "参数管理", Globals.serviceProvider.GetRequiredService<PageSystemParameterSet>() }
};
        private readonly UserManager _userManager;
        private readonly AuthManager _authManager;
        private readonly DataManager _dataManager;
        private List<string> AlarmList = new List<string>();
        private bool isFirst = true;
        private bool isConnectFirst = true;
        #endregion

        #region 初始化
        public FrmMain(ILogger<FrmMain> logger, UserManager userManage, AuthManager authManager, DataManager dataManager)
        {
            _logger = logger;
            _userManager = userManage;
            _authManager = authManager;
            _dataManager = dataManager;
            InitializeComponent();
            uiLabel1.Text = "长街听风";
            //Init();
            // FormClosing：窗体"即将"关闭时触发（还没关，此时还可以用 e.Cancel = true 阻止关闭）
            // 在这里先停掉后台PLC读取循环，防止循环还在跑的时候连接就被关了
            this.FormClosing += (s, e) =>
            {
                cts.Cancel(); // 调用Cancel()后，cts.IsCancellationRequested会从false变为true（不可逆，不能再变回false）
            };
            // FormClosed：窗体"已经"关闭后触发（窗体已从屏幕消失，无法阻止）
            // 执行顺序：FormClosing → 窗体关闭 → FormClosed，所以这里循环已经停了，可以安全关闭PLC连接
            this.FormClosed += (s, e) =>
            {
                Globals.SiemensClient.Close();
            };

            UIStyles.DPIScale = true;           // 开启DPI缩放
            UIStyles.GlobalFont = true;         // 启用全局字体
            UIStyles.GlobalFontName = "宋体";   // 统一字体
            UIStyles.GlobalFontScale = SystemConsts.DefaultFontscale;  // 默认缩放
            UIStyles.SetDPIScale();             // 应用
        }

        public override void Init()
        {
            /**
            // 设置初始页面索引（每个页面，唯一索引构成）
            int pageIndex = 1000;

            // 用户模块，直接创建并添加各个节点
            Aside.CreateNode(AddPage(new PageTotalEquipmentControl()));
            TreeNode parent = Aside.CreateNode("用户模块", 61447, 24, pageIndex++);
            Aside.CreateChildNode(parent, AddPage(new PageUserManage(), pageIndex++));
            Aside.CreateChildNode(parent, AddPage(new PageAuthManage(), pageIndex++));
            parent = Aside.CreateNode("设备模块", 61550, 24, pageIndex++);
            Aside.CreateChildNode(parent, AddPage(new PageEquipmentMonitor(), pageIndex++));
            Aside.CreateChildNode(parent, AddPage(new PageEquipmentMonitor1(), pageIndex++));
            Aside.CreateChildNode(parent, AddPage(new PageEquipmentMonitor3(), pageIndex++));
            Aside.CreateNode(AddPage(new PageRecipeManage()));
            Aside.CreateNode(AddPage(new PageLogManage()));
            Aside.CreateNode(AddPage(new PageReportManage()));
            Aside.CreateNode(AddPage(new PageChartManage()));
            Aside.CreateNode(AddPage(new PageSystemParameterSet()));
            Aside.SelectFirst();
            */

            // 使用依赖注入方式初始化页面
            //Globals.ini.Write("PLC参数", "变量表地址", "D:/MyC#Text/study/Project/PLC_Var_Config.xlsx");
            InitAsideUI();
            InitHeaderUI();
            InitConfig();
            InitPlcClient();
            InitOther();
        }

        private void InitOther()
        {

            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            if (Globals.SiemensClient.Connected)
            {
                if (InvokeRequired)
                {
                    Invoke(async () =>
                    {
                        lbl_ProducteCount.Text = Globals.DataDic[lbl_ProducteCount.TagString].ToString();
                        uiLedLabel2.Text = Globals.DataDic[uiLedLabel2.TagString].ToString();
                        uiLedLabel1.Text = Globals.DataDic[uiLedLabel1.TagString].ToString() + "S";
                        uiLedLabel3.Text = Globals.DataDic[uiLedLabel3.TagString].ToString();
                        lbl_Temperature.Text = Globals.DataDic[lbl_Temperature.TagString].ToString() + "℃";
                        lbl_Humidness.Text = Globals.DataDic[lbl_Humidness.TagString].ToString() + "%";

                        //CPU和内存
                        string CPUstr = RuntimeStatusHelper.DataManager.GetCpuUtilization();
                        string MemoryStr = RuntimeStatusHelper.DataManager.GetMemoryUtilization().Replace("G", "");
                        string NeiResult = (double.Parse(MemoryStr.Split('/')[0]) / double.Parse(MemoryStr.Split('/')[1]) * 100).ToString("f1") + "%";
                        this.uiLabel12.Text = double.Parse(CPUstr).ToString("f1") + "%";
                        this.uiLabel14.Text = NeiResult;

                        //时间
                        this.lbl_Time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        //报警
                        List<string> alarmInfos = CheckAlarms(AlarmList);
                        string alarmInfo = string.Join("，", alarmInfos);
                        if (string.IsNullOrEmpty(alarmInfo))
                        {
                            st_AlarmInfo.Text = "系统正常";
                            st_AlarmInfo.ForeColor = Color.Green;
                            led_ProducteState.On = true;
                            led_ProducteState.Color = Color.Green;
                            led_ProducteState.Blink = false;
                        }
                        else
                        {
                            st_AlarmInfo.Text = alarmInfo;
                            st_AlarmInfo.ForeColor = Color.Red;
                            led_ProducteState.Blink = true;
                            led_ProducteState.Color = Color.Red;
                        }

                        // 保存数据
                        AddDataDto addDataDto = new AddDataDto();
                        addDataDto.InsertTime = DateTime.Now;
                        foreach (var item in Globals.SaveList)
                        {
                            var type = typeof(AddDataDto).GetProperty(item).PropertyType.Name;
                            if (type == "String")
                            {
                                addDataDto.GetType().GetProperty(item).SetValue(addDataDto, Globals.DataDic[item].ToString());
                            }
                        }
                        var res = await _dataManager.AddDataAsync(addDataDto);
                        if (res.Status == SystemEnums.Result.Fail)
                        {
                            LogExtension.ShowMessage("保存数据失败", Microsoft.Extensions.Logging.LogLevel.Error);
                        }
                    });
                }
                else
                {
                    lbl_ProducteCount.Text = Globals.DataDic[lbl_ProducteCount.TagString].ToString();
                    uiLedLabel2.Text = Globals.DataDic[uiLedLabel2.TagString].ToString();
                    uiLedLabel1.Text = Globals.DataDic[uiLedLabel1.TagString].ToString() + "S";
                    uiLedLabel3.Text = Globals.DataDic[uiLedLabel3.TagString].ToString();
                    lbl_Temperature.Text = Globals.DataDic[lbl_Temperature.TagString].ToString() + "℃";
                    lbl_Humidness.Text = Globals.DataDic[lbl_Humidness.TagString].ToString() + "%";

                }
                if (isFirst)
                {
                    Globals.serviceProvider.GetRequiredService<FromStartLoad>().CloseFormThread();
                    isFirst = false;
                }
            }
        }

        private List<string> CheckAlarms(List<string> alarmList)
        {
            List<string> alarmInfos = new List<string>();
            foreach (var item in alarmList)
            {
                if (Globals.DataDic[item].ToString() == "1")
                {
                    alarmInfos.Add(item);
                }
            }
            return alarmInfos;
        }

        /// <summary>
        /// 从config.ini读取PLC连接参数，读不到则使用默认值
        /// </summary>
        private void InitConfig()
        {
            // 读取Excel变量配置表的路径，默认值为程序目录下的PLC_Var_Config.xlsx
            Globals.PlcVarConfigPath = Globals.ini.ReadString("PLC参数", "变量表地址", "D:/MyC#Text/study/Project/PLC_Var_Config.xlsx");
            // 读取PLC的IP地址，默认本机回环地址
            Globals.IpAddress = Globals.ini.ReadString("PLC参数", "PLC地址", "127.0.0.1");
            // 读取PLC的端口号，西门子默认102
            Globals.Port = Globals.ini.ReadInt("PLC参数", "PLC端口号", 102);
            // 读取CPU型号并转为枚举，如S7-1200、S7-1500等
            Globals.CpuType = Enum.Parse<SiemensVersion>(Globals.ini.ReadString("PLC参数", "CPU类型", "S7_1200"));
            // 读取机架号，默认0
            Globals.Rack = Globals.ini.ReadByte("PLC参数", "机架号", 0);
            // 读取插槽号，默认0
            Globals.Slot = Globals.ini.ReadByte("PLC参数", "插槽号", 0);
            // 读取连接超时时间，默认3000毫秒
            Globals.ConnectTimeOut = Globals.ini.ReadInt("PLC参数", "超时时间", 3000);
            // 读取PLC数据循环时间
            Globals.ReadTimeInterval = Globals.ini.ReadInt("PLC参数", "PLC循环读取时间", 500);
            // 读取PLC重连时间
            Globals.ReConnectTimeInterval = Globals.ini.ReadInt("PLC参数", "重连时间", 3000);
            // 删除文件夹
            Globals.DelFilePath = Globals.ini.ReadString("系统参数", "删除文件夹", Path.Combine(Application.StartupPath, "Logs"));
            Globals.SaveDay = Globals.ini.ReadString("系统参数", "保存文件夹天数", "7天");
            // 软件版本和试用时间
            Globals.SoftWareVersion = Globals.ini.ReadString("软件参数", "软件版本", "V1.0");
            Globals.SYTime = Globals.ini.ReadString("软件参数", "试用时间", "100");
            _logger.LogInformation("读取配置文件成功");
        }

        /// <summary>
        /// 初始化PLC客户端：读取Excel变量表、建立连接、填充变量字典
        /// </summary>
        private void InitPlcClient()
        {
            // 从Excel读取所有PLC变量配置（地址、名称、类型等），转为对象列表
            var plcVarList = MiniExcel.Query<PLCVarConfigModel>(Globals.PlcVarConfigPath).ToList();
            // 创建西门子PLC通信客户端，传入CPU类型、IP、端口、插槽、机架、超时时间
            Globals.SiemensClient = new IoTClient.Clients.PLC.SiemensClient(Globals.CpuType, Globals.IpAddress, Globals.Port, Globals.Slot, Globals.Rack, Globals.ConnectTimeOut);
            // 尝试第一次连接PLC
            var connectResult = Globals.SiemensClient.Open();
            if (connectResult.IsSucceed)
            {
                // 连接成功，更新状态和指示灯
                plcIsConnected = true;
                uiLedBulb1.On = true;
            }
            else
            {
                // 连接失败，关闭指示灯
                plcIsConnected = false;
                uiLedBulb1.On = false;
            }

            // 遍历Excel中的每一行变量配置，填充三个全局字典
            for (int i = 0; i < plcVarList.Count; i++)
            {
                // 地址→数据类型：读取时知道该地址按什么类型解析（如Float、Int16等）
                Globals.ReadDic.Add(plcVarList[i].PLC地址, Enum.Parse<DataTypeEnum>(plcVarList[i].变量类型, true));
                // 名称→地址：写入时通过变量名找到对应的PLC地址
                Globals.WriteDic.Add(plcVarList[i].名称, plcVarList[i].PLC地址);
                // 名称→值：存储读取到的数据，初始值"NA"表示尚未读取
                Globals.DataDic.Add(plcVarList[i].名称, "NA");
                //添加报警
                if (plcVarList[i].名称.EndsWith("报警") && !plcVarList[i].名称.Contains("累计"))
                {
                    AlarmList.Add(plcVarList[i].名称);
                }

                if (plcVarList[i].是否保存.ToLower() == "true")
                {
                    Globals.SaveList.Add(plcVarList[i].名称);
                }

            }
            try
            {
                // 后台线程：不断循环读取PLC数据或尝试重连
                Task.Run(async () =>   // async标记，因为下面用了await
                {
                    // IsCancellationRequested 不是自动变化的，必须有人主动调用 cts.Cancel() 才会变成true
                    // 这里是：只要没人调Cancel()就一直循环；调了Cancel()后条件不满足，循环退出
                    while (!cts.IsCancellationRequested)
                    {
                        if (plcIsConnected)
                        {
                            // 带着ReadDic（地址-类型）去PLC批量读取真实数据，返回地址-值的字典
                            var readResult = Globals.SiemensClient.BatchRead(Globals.ReadDic);
                            if (readResult.IsSucceed)
                            {
                                // readResult.Value是按地址存的：{"DB1.0" → 25.6}
                                // DataDic是按名称存的，所以这里用地址从结果取值，用名称存到DataDic
                                for (int i = 0; i < plcVarList.Count; i++)
                                {
                                    Globals.DataDic[plcVarList[i].名称] = readResult.Value[plcVarList[i].PLC地址];
                                }
                            }
                            else
                            {
                                

                                // 读取失败（PLC断连），关闭旧连接，否则重连时Open()会失败
                                Globals.SiemensClient.Close();
                                plcIsConnected = false;
                                // 后台线程不能直接操作界面控件，必须通过Invoke交回UI线程执行
                                this.Invoke(() =>
                                {
                                    this.uiLedBulb1.On = false;
                                });
                            }
                            // 等待一段时间再读下一次，不加等待会疯狂读取轰炸PLC
                            await Task.Delay(Globals.ReadTimeInterval);
                        }
                        else
                        {
                            if (isConnectFirst)
                            {
                                Globals.serviceProvider.GetRequiredService<FromStartLoad>().CloseFormThread();
                                isConnectFirst = false;
                            }
                            // PLC未连接，尝试重新建立连接
                            var reConnectResult = Globals.SiemensClient.Open();
                            if (reConnectResult.IsSucceed)
                            {
                                plcIsConnected = true;
                                this.Invoke(() =>
                                {
                                    this.uiLedBulb1.On = true;
                                });
                            }
                            else
                            {
                                plcIsConnected = false;
                                this.Invoke(() =>
                                {
                                    uiLedBulb1.On = false;
                                });
                                // 重连失败等久一点再试，避免频繁重连占用资源
                                await Task.Delay(Globals.ReConnectTimeInterval);
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void InitAsideUI()
        {
            // 设置初始页面索引（每个页面，唯一索引构成）
            int pageIndex = 1000;
            Aside.CreateNode(AddPage(Globals.serviceProvider.GetRequiredService<PageTotalEquipmentControl>()));
            // 用户模块
            TreeNode parent = Aside.CreateNode("用户模块", 61447, 24, pageIndex++);
            Aside.CreateChildNode(parent, AddPage(Globals.serviceProvider.GetRequiredService<UserManage>(), pageIndex++));
            Aside.CreateChildNode(parent, AddPage(Globals.serviceProvider.GetRequiredService<PageAuthManage>(), pageIndex++));
            // 设备模块
            parent = Aside.CreateNode("设备模块", 61550, 24, pageIndex++);
            Aside.CreateChildNode(parent, AddPage(Globals.serviceProvider.GetRequiredService<PageEquipmentMonitor>(), pageIndex++));
            Aside.CreateChildNode(parent, AddPage(Globals.serviceProvider.GetRequiredService<PageEquipmentMonitor1>(), pageIndex++));
            Aside.CreateChildNode(parent, AddPage(Globals.serviceProvider.GetRequiredService<PageEquipmentMonitor3>(), pageIndex++));
            Aside.CreateNode(AddPage(Globals.serviceProvider.GetRequiredService<PageRecipeManage>()));
            Aside.CreateNode(AddPage(Globals.serviceProvider.GetRequiredService<PageLogManage>()));
            Aside.CreateNode(AddPage(Globals.serviceProvider.GetRequiredService<PageReportManage>()));
            Aside.CreateNode(AddPage(Globals.serviceProvider.GetRequiredService<PageChartManage>()));
            Aside.CreateNode(AddPage(Globals.serviceProvider.GetRequiredService<PageSystemParameterSet>()));
            Aside.SelectFirst();
            Aside.NodeMouseClick += Aside_NodeClick;
        }

        private void InitHeaderUI()
        {
            Header.Nodes.Add("");
            Header.Nodes.Add("");
            Header.Nodes.Add("");
            Header.SetNodeSymbol(Header.Nodes[0], 558295, 34);
            Header.SetNodeSymbol(Header.Nodes[1], 61489, 34);
            Header.SetNodeSymbol(Header.Nodes[2], 557925, 34);
            var styles = UIStyles.PopularStyles();
            foreach (UIStyle style in styles)
            {
                Header.CreateChildNode(Header.Nodes[0], style.DisplayText(), style.Value());
            }

            // 获取枚举FontsType所有字体名称
            for (int i = 0; i < Enum.GetValues(typeof(SystemEnums.FontsType)).Length; i++)
            {
                Header.CreateChildNode(Header.Nodes[1], Enum.GetName(typeof(SystemEnums.FontsType), i), i);
            }

            // 获取枚举字体大小，用于字体大小设置
            for (int i = 75; i <= 125; i += 5)
            {
                Header.CreateChildNode(Header.Nodes[2], i.ToString(), i);
            }
        }
        #endregion

        #region 主题管理
        /// <summary>
        /// Header子菜单点击事件
        /// </summary>
        /// <param name="itemText">点击的子菜单显示文本</param>
        /// <param name="menuIndex">父节点索引：0-主题，1-字体，2-字号</param>
        /// <param name="pageIndex">创建子节点时绑定的关联值</param>
        private void Header_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {
            switch (menuIndex)
            {
                case 0: // 切换主题风格
                    UIStyle style = (UIStyle)pageIndex;
                    // 过滤掉Colorful及之后的特殊风格，只允许常规主题
                    if (pageIndex < UIStyle.Colorful.Value())
                    {
                        // 通过StyleManager切换整个窗体皮肤
                        uiStyleManager1.Style = style;
                        // 广播通知订阅了的自定义控件（如UserCounterButton）也跟着换肤
                        if (UIExtension.SetStyleManager != null)
                        {
                            UIExtension.SetStyleManager(uiStyleManager1);
                        }
                    }
                    break;

                case 1: // 切换全局字体
                    UIStyles.DPIScale = true;       // 开启DPI缩放
                    UIStyles.GlobalFont = true;     // 启用全局字体
                    UIStyles.GlobalFontName = itemText; // 设置全局字体名称
                    UIStyles.GlobalFontScale = SystemConsts.DefaultFontscale; // 重置为默认缩放比例
                    UIStyles.SetDPIScale();         // 应用字体设置
                    break;

                case 2: // 切换全局字号（缩放比例75%-125%）
                    UIStyles.GlobalFontScale = int.Parse(itemText); // 解析选中的字号数值
                    UIStyles.SetDPIScale();         // 应用缩放设置
                    break;

                default:
                    break;
            }
        }
        #endregion

        #region 最小化和关闭
        private void lbl_Min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region 无边框拖动
        // 记住鼠标按下时的坐标，用于无边框窗体拖拽
        private Point mPoint;

        // 鼠标按下事件：记录鼠标在面板内的坐标
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y); // e.X, e.Y 是鼠标相对于面板左上角的位置
        }

        // 鼠标移动事件：左键按住时，用偏移量移动整个窗口
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 只有左键按着才拖动
            {
                // e.X - mPoint.X → 鼠标X方向移动了多少（偏移量）
                // 窗口原位置 + 偏移量 = 窗口新位置
                // this.Location 是窗体左上角相对于屏幕左上角的坐标
                this.Location = new Point(this.Location.X + e.X - mPoint.X, Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // 把Aside折叠起来
            Aside.CollapseAll();
            Aside.SelectFirst();

            var frmLogin = Globals.serviceProvider.GetRequiredService<FrmLogin>();
            frmLogin.ShowDialog();
            if (frmLogin.IsLogin)
            {
                this.uiLabel1.Text = frmLogin.UserName;
                foreach (var control in pageControls.Values)
                {
                    control.Enabled = true;
                }
            }
        }

        private async void Aside_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            string moduleName = e.Node.Text;
            string user = uiLabel1.Text;
            var roleRes = await _userManager.GetUserAuthAsync(new QueryUserAuthDto() { UserName = user });
            if (roleRes.Data[0].Role != "管理员")
            {
                var authRes = await _authManager.GetAuthAsync(new QueryAuthDto() { Role = roleRes.Data[0].Role });
                if (authRes.Status == SystemEnums.Result.Success)
                {
                    UpdateControlAccess(moduleName, authRes.Data[0], pageControls);
                }
            }
        }

        private void UpdateControlAccess(string moduleName, QueryAuthResultDto authDto, Dictionary<string, Control> pageControls)
        {
            switch (moduleName)
            {
                case "设备总控":
                    pageControls["设备总控"].Enabled = authDto.ControlModule;
                    break;

                case "用户模块":
                    pageControls["用户管理"].Enabled = false;
                    pageControls["权限管理"].Enabled = false;
                    break;

                case "设备模块":
                    pageControls["设备监控1"].Enabled = authDto.MonitorModule;
                    pageControls["设备监控2"].Enabled = authDto.MonitorModule;
                    pageControls["设备监控3"].Enabled = authDto.MonitorModule;
                    break;

                case "配方管理":
                    pageControls["配方管理"].Enabled = authDto.RecipeModule;
                    break;

                case "日志管理":
                    pageControls["日志管理"].Enabled = authDto.LogModule;
                    break;

                case "报表管理":
                    pageControls["报表管理"].Enabled = authDto.ReportModule;
                    break;

                case "图表管理":
                    pageControls["图表管理"].Enabled = authDto.ChartModule;
                    break;

                case "参数管理":
                    pageControls["参数管理"].Enabled = authDto.ParamModule;
                    break;

                default:
                    break;
            }
        }

        private async void Aside_NodeClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string moduleName = e.Node.Text;
            string user = uiLabel1.Text;
            var roleRes = await _userManager.GetUserAuthAsync(new QueryUserAuthDto() { UserName = user });
            if (roleRes.Data[0].Role != "管理员")
            {
                var authRes = await _authManager.GetAuthAsync(new QueryAuthDto() { Role = roleRes.Data[0].Role });
                if (authRes.Status == SystemEnums.Result.Success)
                {
                    UpdateControlAccess(moduleName, authRes.Data[0], pageControls);
                }
            }
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            Globals.serviceProvider.GetRequiredService<FromStartLoad>().OpenFormThread();
            Init();
        }

        #region 窗体卡顿处理
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }
        #endregion
    }
}
