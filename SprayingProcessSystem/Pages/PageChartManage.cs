using HZY.Framework.DependencyInjection;
using Sunny.UI;
using System.BLL;
using System.BLL.Manager;
using System.Helper;

namespace SprayingProcessSystem.Pages
{
    public partial class PageChartManage : UIPage, ISingletonSelfDependency
    {

        private readonly DataManager _dataManager;

        public PageChartManage(DataManager dataManager)
        {
            InitializeComponent();
            _dataManager = dataManager;

            // 默认查询最近1小时的数据
            uiDatetimePicker1.Value = DateTime.Now.AddHours(-1);
            uiDatetimePicker2.Value = DateTime.Now;

            // 配置折线图：X轴为时间，Y轴为数值，鼠标悬停显示提示
            UILineOption option = new UILineOption
            {
                ToolTip = { Visible = true },                           // 鼠标悬停显示数据提示
                Title = new UITitle { Text = "" },                      // 图表标题为空
                Legend = new UILegend                                    // 图例（区分不同数据线的标签）
                {
                    Orient = UIOrient.Horizontal,                       // 图例水平排列
                    Top = UITopAlignment.Top,                            // 图例在顶部
                    Left = UILeftAlignment.Left                          // 图例在左侧
                },
                XAxisType = UIAxisType.DateTime,                        // X轴类型为时间
                XAxis = { Name = "日期", AxisLabel = { DateTimeFormat = "HH:mm:ss" } },  // X轴显示格式：时:分:秒
                YAxis = { Name = "数值", AxisLabel = { DecimalPlaces = 1 } }              // Y轴保留1位小数
            };

            // 需要显示的7条数据线对应的PLC变量名
            string[] legendData =
            {
                "脱脂喷淋泵压力值",
                "脱脂pH值",
                "粗洗喷淋泵压力值",
                "陶化喷淋泵压力值",
                "精洗喷淋泵压力值",
                "水分炉测量温度",
                "固化炉测量温度"
            };

            // 为每条数据线添加图例和折线系列
            foreach (var data in legendData)
            {
                option.Legend.AddData(data);    // 添加图例标签
                AddSeries(option, data);         // 添加一条折线
            }

            // 将配置应用到图表控件
            uiLineChart1.SetOption(option);
        }

        /// <summary>
        /// 添加一条折线系列，配置数据点的显示样式
        /// </summary>
        private void AddSeries(UILineOption option, string seriesName)
        {
            var series = option.AddSeries(new UILineSeries(seriesName));
            series.Symbol = UILinePointSymbol.Circle;     // 数据点形状：圆形
            series.SymbolSize = 4;                         // 数据点大小
            series.SymbolLineWidth = 2;                    // 数据点边框粗细
            //series.YAxisDecimalPlaces = 1;               // Y轴小数位数（已注释）
            series.Smooth = true;                           // 平滑曲线（不是折线）
        }

        /// <summary>
        /// 查询按钮：根据选择的时间范围查询数据并绘制图表
        /// </summary>
        private async void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            var t1 = this.uiDatetimePicker1.Value;
            var t2 = this.uiDatetimePicker2.Value;

            // 校验时间范围
            if (t1 >= t2)
            {
                UIMessageTip.ShowWarning("开始时间不能大于结束时间！");
                return;
            }

            // 构造查询DTO，传入起止时间
            QueryDataDto dto = new QueryDataDto
            {
                StartTime = t1,
                EndTime = t2
            };

            // 调用BLL层查询数据库，获取时间范围内的所有数据记录
            var res = await _dataManager.GetDataListByTimeAsync(dto);

            if (res.Status == SystemEnums.Result.Success)
            {
                // 最多取前30条数据绘制图表，防止数据量太大导致图表卡顿
                for (int i = 0; i < res.Data.Count; i++)
                {
                    if (i > 30)
                    {
                        break;
                    }

                    // 获取当前数据记录的时间戳，作为X轴坐标
                    var dt = res.Data[i].InsertTime;
                    var dataRes = res.Data[i];

                    // 将7个变量的值分别添加到对应的折线系列中（变量名, 时间, 数值）
                    uiLineChart1.Option.AddData("脱脂喷淋泵压力值", dt, double.Parse(dataRes.脱脂喷淋泵压力值));
                    uiLineChart1.Option.AddData("脱脂pH值", dt, double.Parse(dataRes.脱脂pH值));
                    uiLineChart1.Option.AddData("粗洗喷淋泵压力值", dt, double.Parse(dataRes.粗洗喷淋泵压力值));
                    uiLineChart1.Option.AddData("陶化喷淋泵压力值", dt, double.Parse(dataRes.陶化喷淋泵压力值));
                    uiLineChart1.Option.AddData("精洗喷淋泵压力值", dt, double.Parse(dataRes.精洗喷淋泵压力值));
                    uiLineChart1.Option.AddData("水分炉测量温度", dt, double.Parse(dataRes.水分炉测量温度));
                    uiLineChart1.Option.AddData("固化炉测量温度", dt, double.Parse(dataRes.固化炉测量温度));
                }
            }

            // 刷新图表显示
            uiLineChart1.Refresh();
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
