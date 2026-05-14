using Sunny.UI;
using System.ComponentModel;

namespace SprayingProcessSystem
{
    public partial class UserDeviceUnitControl : UIUserControl
    {
        public UserDeviceUnitControl()
        {
            InitializeComponent();
        }

        private string equipmentUnitName = "设备单元";
        [Browsable(true)]// 使属性可以暴露出来，显示到窗口
        [Category("自定义属性")]
        [Description("设备单元的名称")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string EquipmentUnitName { 
            get { return equipmentUnitName; }
            set
            {
                equipmentUnitName = value;
                this.lbl_DeviceName.Text = value;
            }
        }

        private bool state;
        [Browsable(true)]// 使属性可以暴露出来，显示到窗口
        [Category("自定义属性")]
        [Description("设备状态")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool State
        {
            get {
                state = this.sw_Device.Active;
                return state;
            }
            set {
                state = value;
                this.sw_Device.Active = state;
            }
        }

        private string openVariableName = "";
        [Browsable(true)]// 使属性可以暴露出来，显示到窗口
        [Category("自定义属性")]
        [Description("控制打开操作的变量名称")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string OpenVariableName
        {
            get { return openVariableName; }
            set { openVariableName = value; }
        }

        private string closeVariableName = "";
        [Browsable(true)]// 使属性可以暴露出来，显示到窗口
        [Category("自定义属性")]
        [Description("控制关闭操作的变量名称")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string CloseVariableName
        {
            get { return closeVariableName; }
            set { closeVariableName = value; }
        }

        public event EventHandler ClickEvent;
        [Browsable(true)]
        [Category("自定义事件")]
        [Description("点击事件")]
        private void SW_Device_Click(object sender, EventArgs e)
        {
            if (ClickEvent != null)
            {
                ClickEvent?.Invoke(this, e);
            }
        }

    }
}
