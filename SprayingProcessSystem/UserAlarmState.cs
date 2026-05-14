using Sunny.UI;
using System.ComponentModel;

namespace SprayingProcessSystem
{
    public partial class UserAlarmState : UIUserControl
    {
        public UserAlarmState()
        {
            InitializeComponent();
        }

        private string deviceAlarmName = "报警名称";
        [Description("设置或获取设备报警名称")]
        [Category("自定义属性")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string DeviceName {
            get { return deviceAlarmName; }
            set 
            { 
                this.uiLabel1.Text = value;
                deviceAlarmName = value;
            }
        }

        private bool state = true;
        [Description("设置或获取设备报警名称")]
        [Category("自定义属性")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool State 
        { 
            get { return state; }
            set
            {
                state = value;
                if (value)
                {
                    this.uiSymbolLabel1.SymbolColor = Color.Red;
                }
                else
                {
                    this.uiSymbolLabel1.SymbolColor = Color.LimeGreen;
                }
            }
        }

        private string variableName = "";
        [Description("设置或获取设备报警名称")]
        [Category("自定义属性")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string VariableName 
        {
            get { return variableName; }
            set
            {
                variableName = value;
            }
        }
    }
}
