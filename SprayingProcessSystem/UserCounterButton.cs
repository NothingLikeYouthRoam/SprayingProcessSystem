using Sunny.UI;
using System.ComponentModel;

namespace SprayingProcessSystem
{
    public partial class UserCounterButton : UIUserControl
    {
        private UIStyle style;
        private Color defaultFillColor;
        private Color defaultRectColor;
        public UserCounterButton()
        {
            this.Load += UserCounterButton_Load;
            InitializeComponent();
            style = btn_Counter.Style;
            defaultFillColor = this.btn_Counter.FillColor;
            defaultRectColor = this.btn_Counter.RectColor;
        }

        private void UserCounterButton_Load(object? sender, EventArgs e)
        {
            UIExtension.SetStyleManager += SetStyle;
        }

        private void SetStyle(UIStyleManager manager)
        {
            this.btn_Counter.Style = manager.Style;
            style = manager.Style;
            defaultFillColor = this.btn_Counter.FillColor;
            defaultRectColor = this.btn_Counter.RectColor;
            if (counterButtonState)
            {
                this.btn_Counter.FillColor = this.btn_Counter.FillPressColor;
                this.btn_Counter.RectColor = this.btn_Counter.RectPressColor;
            }
        }

        private string buttonName = "";
        [Browsable(true)] // 使属性在工具箱中暴露出来
        [Category("自定义属性")] // 在属性窗口中会创建一个分组，然后把所有属性放在一起
        [Description("按钮的名称")] // 选中属性的描述性文字
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)] // 控制设计器如何将属性值保存到后台
        public string ButtonName
        {
            get { return buttonName; }
            set
            {
                buttonName = value;
                this.btn_Counter.Text = value;
            }
        }

        private int counterBUttonSymbol = 61452;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置按钮的图标")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CounterButtonSymbol
        {
            get { return counterBUttonSymbol; }
            set
            {
                counterBUttonSymbol = value;
                this.btn_Counter.Symbol = value;
            }
        }

        private bool counterButtonState;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("按钮的状态")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool CounterButtonState
        {
            get { return counterButtonState; }
            set
            {
                counterButtonState = value;
                if (value)
                {
                    this.btn_Counter.FillColor = this.btn_Counter.FillPressColor;
                    this.btn_Counter.RectColor = this.btn_Counter.RectPressColor;
                }
                else
                {
                    this.btn_Counter.FillColor = defaultFillColor;
                    this.btn_Counter.RectColor = defaultRectColor;
                }
            }
        }

        private string variableName;

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("获取变量的名称")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string VariableName
        {
            get { return variableName; }
            set { variableName = value; }
        }


        public event EventHandler ClickEvent;
        [Browsable(true)]
        [Category("自定义事件")]
        [Description("点击事件")]
        private void UserCounterButton_Click(object sender, EventArgs e)
        {
            if (ClickEvent != null)
            {
                ClickEvent?.Invoke(this, e);
            }
        }
    }
}
