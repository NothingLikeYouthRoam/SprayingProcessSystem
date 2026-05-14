using Sunny.UI;
using System.ComponentModel;

namespace SprayingProcessSystem
{
    public partial class UserVarCurrentValue : UIUserControl
    {
        public UserVarCurrentValue()
        {
            InitializeComponent();
        }

        private string deviceVarName = "名称";
        [Description("设置或获取设备变量名称")]
        [Category("自定义属性")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string DeviceVarName 
        {
            get { return deviceVarName; }
            set
            {
                deviceVarName = value;
                this.uiLabel1.Text = value;
            }
        }

        private float varValue;
        [Description("设置或获取设备变量值")]
        [Category("自定义属性")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float VarValue 
        {
            get { return varValue; }
            set
            {
                varValue = value;
                this.uiDigitalLabel1.Value = value;
            }
        }

        private string unit = "单位";
        [Description("设置或获取单位")]
        [Category("自定义属性")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                this.uiLabel2.Text = value;
            }
        }

        private string variableName = "";
        [Description("获取变量名称")]
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
