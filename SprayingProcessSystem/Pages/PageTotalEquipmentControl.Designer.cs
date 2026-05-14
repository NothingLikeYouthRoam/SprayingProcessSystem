namespace SprayingProcessSystem.Pages
{
    partial class PageTotalEquipmentControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            userCounterButton1 = new UserCounterButton();
            uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            btn_Start = new Sunny.UI.UISymbolButton();
            uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            uiTextBox1 = new Sunny.UI.UITextBox();
            userDeviceUnitControl1 = new UserDeviceUnitControl();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            userDeviceUnitControl8 = new UserDeviceUnitControl();
            userDeviceUnitControl5 = new UserDeviceUnitControl();
            userDeviceUnitControl7 = new UserDeviceUnitControl();
            userDeviceUnitControl4 = new UserDeviceUnitControl();
            userDeviceUnitControl6 = new UserDeviceUnitControl();
            userDeviceUnitControl3 = new UserDeviceUnitControl();
            userDeviceUnitControl2 = new UserDeviceUnitControl();
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel3.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(userCounterButton1);
            uiTitlePanel1.Controls.Add(uiSymbolButton3);
            uiTitlePanel1.Controls.Add(uiSymbolButton2);
            uiTitlePanel1.Controls.Add(uiSymbolButton1);
            uiTitlePanel1.Controls.Add(btn_Start);
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel1.Location = new Point(7, 4);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(1065, 157);
            uiTitlePanel1.TabIndex = 1;
            uiTitlePanel1.Text = "产线总控制";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userCounterButton1
            // 
            userCounterButton1.BackColor = Color.Transparent;
            userCounterButton1.ButtonName = "空运行";
            userCounterButton1.CounterButtonState = false;
            userCounterButton1.CounterButtonSymbol = 61452;
            userCounterButton1.FillColor = Color.Transparent;
            userCounterButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userCounterButton1.Location = new Point(867, 55);
            userCounterButton1.MinimumSize = new Size(1, 1);
            userCounterButton1.Name = "userCounterButton1";
            userCounterButton1.RectColor = Color.Transparent;
            userCounterButton1.Size = new Size(181, 84);
            userCounterButton1.TabIndex = 1;
            userCounterButton1.Text = "userCounterButton1";
            userCounterButton1.TextAlignment = ContentAlignment.MiddleCenter;
            userCounterButton1.VariableName = "空运行";
            userCounterButton1.ClickEvent += userCounterButton1_Click;
            // 
            // uiSymbolButton3
            // 
            uiSymbolButton3.Font = new Font("微软雅黑", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolButton3.Location = new Point(657, 55);
            uiSymbolButton3.MinimumSize = new Size(1, 1);
            uiSymbolButton3.Name = "uiSymbolButton3";
            uiSymbolButton3.Radius = 10;
            uiSymbolButton3.Size = new Size(181, 84);
            uiSymbolButton3.Symbol = 61473;
            uiSymbolButton3.SymbolSize = 55;
            uiSymbolButton3.TabIndex = 0;
            uiSymbolButton3.TagString = "报警复位";
            uiSymbolButton3.Text = "报警复位";
            uiSymbolButton3.TipsFont = null;
            uiSymbolButton3.Click += btn_Start_Click;
            // 
            // uiSymbolButton2
            // 
            uiSymbolButton2.Font = new Font("微软雅黑", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolButton2.Location = new Point(444, 55);
            uiSymbolButton2.MinimumSize = new Size(1, 1);
            uiSymbolButton2.Name = "uiSymbolButton2";
            uiSymbolButton2.Radius = 10;
            uiSymbolButton2.Size = new Size(181, 84);
            uiSymbolButton2.Symbol = 61473;
            uiSymbolButton2.SymbolSize = 55;
            uiSymbolButton2.TabIndex = 0;
            uiSymbolButton2.TagString = "机械复位";
            uiSymbolButton2.Text = "机械复位";
            uiSymbolButton2.TipsFont = null;
            uiSymbolButton2.Click += btn_Start_Click;
            // 
            // uiSymbolButton1
            // 
            uiSymbolButton1.Font = new Font("微软雅黑", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolButton1.Location = new Point(226, 55);
            uiSymbolButton1.MinimumSize = new Size(1, 1);
            uiSymbolButton1.Name = "uiSymbolButton1";
            uiSymbolButton1.Radius = 10;
            uiSymbolButton1.Size = new Size(181, 84);
            uiSymbolButton1.Symbol = 62093;
            uiSymbolButton1.SymbolSize = 55;
            uiSymbolButton1.TabIndex = 0;
            uiSymbolButton1.TagString = "总停止";
            uiSymbolButton1.Text = "总停止";
            uiSymbolButton1.TipsFont = null;
            uiSymbolButton1.Click += btn_Start_Click;
            // 
            // btn_Start
            // 
            btn_Start.Font = new Font("微软雅黑", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_Start.Location = new Point(12, 55);
            btn_Start.MinimumSize = new Size(1, 1);
            btn_Start.Name = "btn_Start";
            btn_Start.Radius = 10;
            btn_Start.Size = new Size(181, 84);
            btn_Start.Symbol = 561649;
            btn_Start.SymbolSize = 55;
            btn_Start.TabIndex = 0;
            btn_Start.TagString = "总启动";
            btn_Start.Text = "总启动";
            btn_Start.TipsFont = null;
            btn_Start.Click += btn_Start_Click;
            // 
            // uiTitlePanel3
            // 
            uiTitlePanel3.Controls.Add(uiTextBox1);
            uiTitlePanel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel3.Location = new Point(617, 169);
            uiTitlePanel3.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel3.MinimumSize = new Size(1, 1);
            uiTitlePanel3.Name = "uiTitlePanel3";
            uiTitlePanel3.ShowText = false;
            uiTitlePanel3.Size = new Size(455, 374);
            uiTitlePanel3.TabIndex = 3;
            uiTitlePanel3.Text = "日志栏";
            uiTitlePanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTextBox1.Location = new Point(4, 40);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Multiline = true;
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ReadOnly = true;
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(447, 329);
            uiTextBox1.TabIndex = 1;
            uiTextBox1.TextAlignment = ContentAlignment.TopLeft;
            uiTextBox1.Watermark = "";
            // 
            // userDeviceUnitControl1
            // 
            userDeviceUnitControl1.CloseVariableName = "脱脂工位关";
            userDeviceUnitControl1.EquipmentUnitName = "脱脂工位";
            userDeviceUnitControl1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceUnitControl1.Location = new Point(18, 57);
            userDeviceUnitControl1.MinimumSize = new Size(1, 1);
            userDeviceUnitControl1.Name = "userDeviceUnitControl1";
            userDeviceUnitControl1.OpenVariableName = "脱脂工位开";
            userDeviceUnitControl1.RectColor = Color.Transparent;
            userDeviceUnitControl1.Size = new Size(243, 44);
            userDeviceUnitControl1.State = false;
            userDeviceUnitControl1.TabIndex = 3;
            userDeviceUnitControl1.Text = "userDeviceUnitControl1";
            userDeviceUnitControl1.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl1.ClickEvent += userDeviceUnitControl1_Click;
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(userDeviceUnitControl8);
            uiTitlePanel2.Controls.Add(userDeviceUnitControl5);
            uiTitlePanel2.Controls.Add(userDeviceUnitControl7);
            uiTitlePanel2.Controls.Add(userDeviceUnitControl4);
            uiTitlePanel2.Controls.Add(userDeviceUnitControl6);
            uiTitlePanel2.Controls.Add(userDeviceUnitControl3);
            uiTitlePanel2.Controls.Add(userDeviceUnitControl2);
            uiTitlePanel2.Controls.Add(userDeviceUnitControl1);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel2.Location = new Point(7, 169);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(602, 374);
            uiTitlePanel2.TabIndex = 2;
            uiTitlePanel2.Text = "设备单元控制";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userDeviceUnitControl8
            // 
            userDeviceUnitControl8.CloseVariableName = "输送机工位关";
            userDeviceUnitControl8.EquipmentUnitName = "输送机工位";
            userDeviceUnitControl8.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceUnitControl8.Location = new Point(295, 297);
            userDeviceUnitControl8.MinimumSize = new Size(1, 1);
            userDeviceUnitControl8.Name = "userDeviceUnitControl8";
            userDeviceUnitControl8.OpenVariableName = "输送机工位开";
            userDeviceUnitControl8.RectColor = Color.Transparent;
            userDeviceUnitControl8.Size = new Size(271, 44);
            userDeviceUnitControl8.State = false;
            userDeviceUnitControl8.TabIndex = 7;
            userDeviceUnitControl8.Text = "userDeviceUnitControl8";
            userDeviceUnitControl8.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl8.ClickEvent += userDeviceUnitControl1_Click;
            // 
            // userDeviceUnitControl5
            // 
            userDeviceUnitControl5.CloseVariableName = "水分炉工位关";
            userDeviceUnitControl5.EquipmentUnitName = "水分炉工位";
            userDeviceUnitControl5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceUnitControl5.Location = new Point(295, 57);
            userDeviceUnitControl5.MinimumSize = new Size(1, 1);
            userDeviceUnitControl5.Name = "userDeviceUnitControl5";
            userDeviceUnitControl5.OpenVariableName = "水分炉工位开";
            userDeviceUnitControl5.RectColor = Color.Transparent;
            userDeviceUnitControl5.Size = new Size(271, 44);
            userDeviceUnitControl5.State = false;
            userDeviceUnitControl5.TabIndex = 6;
            userDeviceUnitControl5.Text = "userDeviceUnitControl5";
            userDeviceUnitControl5.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl5.ClickEvent += userDeviceUnitControl1_Click;
            // 
            // userDeviceUnitControl7
            // 
            userDeviceUnitControl7.CloseVariableName = "固化炉工位关";
            userDeviceUnitControl7.EquipmentUnitName = "固化炉工位";
            userDeviceUnitControl7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceUnitControl7.Location = new Point(295, 219);
            userDeviceUnitControl7.MinimumSize = new Size(1, 1);
            userDeviceUnitControl7.Name = "userDeviceUnitControl7";
            userDeviceUnitControl7.OpenVariableName = "固化炉工位开";
            userDeviceUnitControl7.RectColor = Color.Transparent;
            userDeviceUnitControl7.Size = new Size(271, 44);
            userDeviceUnitControl7.State = false;
            userDeviceUnitControl7.TabIndex = 7;
            userDeviceUnitControl7.Text = "userDeviceUnitControl7";
            userDeviceUnitControl7.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl7.ClickEvent += userDeviceUnitControl1_Click;
            // 
            // userDeviceUnitControl4
            // 
            userDeviceUnitControl4.CloseVariableName = "精洗工位关";
            userDeviceUnitControl4.EquipmentUnitName = "精洗工位";
            userDeviceUnitControl4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceUnitControl4.Location = new Point(18, 297);
            userDeviceUnitControl4.MinimumSize = new Size(1, 1);
            userDeviceUnitControl4.Name = "userDeviceUnitControl4";
            userDeviceUnitControl4.OpenVariableName = "精洗工位开";
            userDeviceUnitControl4.RectColor = Color.Transparent;
            userDeviceUnitControl4.Size = new Size(243, 44);
            userDeviceUnitControl4.State = false;
            userDeviceUnitControl4.TabIndex = 5;
            userDeviceUnitControl4.Text = "userDeviceUnitControl4";
            userDeviceUnitControl4.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl4.ClickEvent += userDeviceUnitControl1_Click;
            // 
            // userDeviceUnitControl6
            // 
            userDeviceUnitControl6.CloseVariableName = "冷却室工位关";
            userDeviceUnitControl6.EquipmentUnitName = "冷却室工位";
            userDeviceUnitControl6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceUnitControl6.Location = new Point(295, 135);
            userDeviceUnitControl6.MinimumSize = new Size(1, 1);
            userDeviceUnitControl6.Name = "userDeviceUnitControl6";
            userDeviceUnitControl6.OpenVariableName = "冷却室工位开";
            userDeviceUnitControl6.RectColor = Color.Transparent;
            userDeviceUnitControl6.Size = new Size(271, 44);
            userDeviceUnitControl6.State = false;
            userDeviceUnitControl6.TabIndex = 7;
            userDeviceUnitControl6.Text = "userDeviceUnitControl6";
            userDeviceUnitControl6.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl6.ClickEvent += userDeviceUnitControl1_Click;
            // 
            // userDeviceUnitControl3
            // 
            userDeviceUnitControl3.CloseVariableName = "陶化工位关";
            userDeviceUnitControl3.EquipmentUnitName = "陶化工位";
            userDeviceUnitControl3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceUnitControl3.Location = new Point(18, 219);
            userDeviceUnitControl3.MinimumSize = new Size(1, 1);
            userDeviceUnitControl3.Name = "userDeviceUnitControl3";
            userDeviceUnitControl3.OpenVariableName = "陶化工位开";
            userDeviceUnitControl3.RectColor = Color.Transparent;
            userDeviceUnitControl3.Size = new Size(243, 44);
            userDeviceUnitControl3.State = false;
            userDeviceUnitControl3.TabIndex = 4;
            userDeviceUnitControl3.Text = "userDeviceUnitControl3";
            userDeviceUnitControl3.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl3.ClickEvent += userDeviceUnitControl1_Click;
            // 
            // userDeviceUnitControl2
            // 
            userDeviceUnitControl2.CloseVariableName = "粗洗工位关";
            userDeviceUnitControl2.EquipmentUnitName = "粗洗工位";
            userDeviceUnitControl2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceUnitControl2.Location = new Point(18, 135);
            userDeviceUnitControl2.MinimumSize = new Size(1, 1);
            userDeviceUnitControl2.Name = "userDeviceUnitControl2";
            userDeviceUnitControl2.OpenVariableName = "粗洗工位开";
            userDeviceUnitControl2.RectColor = Color.Transparent;
            userDeviceUnitControl2.Size = new Size(243, 44);
            userDeviceUnitControl2.State = false;
            userDeviceUnitControl2.TabIndex = 3;
            userDeviceUnitControl2.Text = "userDeviceUnitControl2";
            userDeviceUnitControl2.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl2.ClickEvent += userDeviceUnitControl1_Click;
            // 
            // PageTotalEquipmentControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel3);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageTotalEquipmentControl";
            Symbol = 57397;
            Text = "设备总控";
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel3.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UISymbolButton btn_Start;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private Sunny.UI.UITextBox uiTextBox1;
        private UserCounterButton userCounterButton1;
        private UserDeviceUnitControl userDeviceUnitControl1;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private UserDeviceUnitControl userDeviceUnitControl4;
        private UserDeviceUnitControl userDeviceUnitControl3;
        private UserDeviceUnitControl userDeviceUnitControl2;
        private UserDeviceUnitControl userDeviceUnitControl8;
        private UserDeviceUnitControl userDeviceUnitControl7;
        private UserDeviceUnitControl userDeviceUnitControl5;
        private UserDeviceUnitControl userDeviceUnitControl6;
    }
}