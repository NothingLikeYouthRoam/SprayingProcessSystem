using HZY.Framework.DependencyInjection;
using IoTClient.Common.Enums;
using Sunny.UI;

namespace SprayingProcessSystem.Pages
{
    public partial class PageSystemParameterSet : UIPage, ISingletonSelfDependency
    {
        public PageSystemParameterSet()
        {
            InitializeComponent();
            this.Load += PageSystemParameterSet_Load;
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

        private void PageSystemParameterSet_Load(object? sender, EventArgs e)
        {
            InitSystemParameter();
        }

        private void InitSystemParameter()
        {
            uiTextBox10.Text = Globals.PlcVarConfigPath;
            uiTextBox4.Text = Globals.ConnectTimeOut.ToString();
            uiipTextBox1.Text = Globals.IpAddress;
            uiTextBox1.Text = Globals.Port.ToString();
            uiTextBox5.Text = Globals.ReadTimeInterval.ToString();
            uiTextBox6.Text = Globals.ReConnectTimeInterval.ToString();
            uiTextBox2.Text = Globals.Rack.ToString();
            uiTextBox3.Text = Globals.Slot.ToString();
            uiComboBox1.Items.AddRange(Enum.GetNames(typeof(SiemensVersion)));
            uiComboBox1.Text = Globals.CpuType.ToString();
            uiTextBox9.Text = Globals.DelFilePath;
            switch(Globals.SaveDay)
            {
                case "不清理":
                    uiRadioButtonGroup1.SelectedIndex = 0;
                    break;
                case "3天":
                    uiRadioButtonGroup1.SelectedIndex = 1;
                    break;
                case "7天":
                    uiRadioButtonGroup1.SelectedIndex = 2;
                    break;
                case "15天":
                    uiRadioButtonGroup1.SelectedIndex = 3;
                    break;
                case "30天":
                    uiRadioButtonGroup1.SelectedIndex = 4;
                    break;
                case "60天":
                    uiRadioButtonGroup1.SelectedIndex = 5;
                    break;
            }
            uiTextBox7.Text = Globals.SoftWareVersion;
            uiTextBox8.Text = Globals.SYTime;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            var parameters = new Dictionary<string, string>
            {
                {"PLC地址",uiipTextBox1.Text },
                {"PLC端口",uiTextBox1.Text },
                {"CPU类型",uiComboBox1.Text },
                {"机架号",uiTextBox2.Text },
                {"插槽号",uiTextBox3.Text },
                {"超时时间",uiTextBox4.Text },
                {"循环读取时间",uiTextBox5.Text },
                {"重连时间",uiTextBox6.Text },
                {"变量表地址", this.uiTextBox10.Text }
            };
            foreach (var parameter in parameters)
            {
                if (!Globals.ini.Write("PLC参数", parameter.Key, parameter.Value))
                {
                    UIMessageTip.ShowWarning($"保存{parameter.Key}失败！");
                    return;
                }
            }

            string delDirePath = uiTextBox9.Text;
            string saveDay = uiRadioButtonGroup1.Items[uiRadioButtonGroup1.SelectedIndex].ToString();
            if (Directory.Exists(delDirePath))
            {
                if (!Globals.ini.Write("系统参数", "删除文件夹路径", delDirePath))
                {
                    UIMessageTip.ShowWarning("删除文件夹路径失败");
                    return;
                }
            }
            else
            {
                UIMessageTip.ShowWarning("删除文件夹不存在");
                return;
            }
            if (!Globals.ini.Write("系统参数","保存文件夹天数",saveDay))
            {
                UIMessageTip.ShowWarning("保存天数失败");
                return;
            }
            if (!Globals.ini.Write("软件参数","软件版本", uiTextBox7.Text))
            {
                UIMessageTip.ShowWarning("保存软件版本信息失败");
                return;
            }
            if (!Globals.ini.Write("软件参数","试用时间", uiTextBox8.Text))
            {
                UIMessageTip.ShowWarning("保存软件试用时间失败");
                return;
            }
            UIMessageTip.ShowOk("保存成功！");
        }
    }
}
