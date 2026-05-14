using Sunny.UI;
using System.ComponentModel;

namespace SprayingProcessSystem
{
    public partial class UserDeviceState : UIUserControl
    {
        public UserDeviceState()
        {
            InitializeComponent();
        }

        private string deviceRunName = "状态名称";

        [Description("设置或获取设备运行状态名称")]
        [Category("自定义属性")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string DeviceRunName { 
            get
            {
                return deviceRunName;
            }
            set
            {
                deviceRunName = value;
                this.uiLabel1.Text = value;
            }
        }

        private bool state = false;
        [Description("获取设备运行状态")]
        [Category("自定义属性")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool State {
            get { return state; }
            set
            {
                state = value;
                if (state)
                {
                    this.uiLight1.State = UILightState.On;
                }
                else
                {
                    this.uiLight1.State = UILightState.Off;
                }
            }
        }

        private string variableName = "";
        [Description("获取变量名称")]
        [Category("自定义属性")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string VariableName {
            get { return variableName; }
            set { variableName = value; }
        }    
    }
}
