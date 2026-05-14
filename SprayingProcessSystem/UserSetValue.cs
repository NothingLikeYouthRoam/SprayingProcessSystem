using Sunny.UI;
using System.ComponentModel;
using static Sunny.UI.UITextBox;

namespace SprayingProcessSystem
{
    public partial class UserSetValue : UIUserControl
    {
        public UserSetValue()
        {
            InitializeComponent();
        }

        private string deviceVarName = "名称";

        [Description("设备变量名称")]
        [Category("自定义属性")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string DeviceVarName
        {
            get { return deviceVarName; }
            set
            {
                deviceVarName = value;
                this.uiLabel1.Text = deviceVarName;
            }
        }

        private string varValue = "";
        [Description("变量值")]
        [Category("自定义属性")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string VarValue
        {
            get { return varValue; }
            set
            {
                varValue = value;
                this.uiTextBox1.Text = varValue;
            }
        }

        private UIEditType dataType = UIEditType.Double;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("数值类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public UIEditType DataType
        {
            get { return dataType; }
            set
            {
                dataType = value;
                this.uiTextBox1.Type = dataType;
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
                this.uiLabel2.Text = unit;
            }
        }

        private void txt_Value_TextChanged(object sender, EventArgs e)
        {
            VarValue = this.uiTextBox1.Text;
        }
        private string variableName = "";

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("获取变量名称")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string VariableName
        {
            get { return variableName; }
            set { variableName = value; }
        }
    }
}
