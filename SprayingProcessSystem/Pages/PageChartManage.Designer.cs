namespace SprayingProcessSystem.Pages
{
    partial class PageChartManage
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
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            uiDatetimePicker1 = new Sunny.UI.UIDatetimePicker();
            uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            uiDatetimePicker2 = new Sunny.UI.UIDatetimePicker();
            uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            uiLineChart1 = new Sunny.UI.UILineChart();
            SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolLabel1.Location = new Point(12, 12);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(142, 35);
            uiSymbolLabel1.Symbol = 62067;
            uiSymbolLabel1.TabIndex = 0;
            uiSymbolLabel1.Text = "开始时间";
            // 
            // uiDatetimePicker1
            // 
            uiDatetimePicker1.FillColor = Color.White;
            uiDatetimePicker1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDatetimePicker1.Location = new Point(147, 12);
            uiDatetimePicker1.Margin = new Padding(4, 5, 4, 5);
            uiDatetimePicker1.MaxLength = 19;
            uiDatetimePicker1.MinimumSize = new Size(63, 0);
            uiDatetimePicker1.Name = "uiDatetimePicker1";
            uiDatetimePicker1.Padding = new Padding(0, 0, 30, 2);
            uiDatetimePicker1.Size = new Size(264, 35);
            uiDatetimePicker1.SymbolDropDown = 61555;
            uiDatetimePicker1.SymbolNormal = 61555;
            uiDatetimePicker1.SymbolSize = 24;
            uiDatetimePicker1.TabIndex = 1;
            uiDatetimePicker1.Text = "2025-12-18 21:45:35";
            uiDatetimePicker1.TextAlignment = ContentAlignment.MiddleLeft;
            uiDatetimePicker1.Value = new DateTime(2025, 12, 18, 21, 45, 35, 987);
            uiDatetimePicker1.Watermark = "";
            // 
            // uiSymbolLabel2
            // 
            uiSymbolLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolLabel2.Location = new Point(454, 12);
            uiSymbolLabel2.MinimumSize = new Size(1, 1);
            uiSymbolLabel2.Name = "uiSymbolLabel2";
            uiSymbolLabel2.Size = new Size(142, 35);
            uiSymbolLabel2.Symbol = 62067;
            uiSymbolLabel2.TabIndex = 0;
            uiSymbolLabel2.Text = "结束时间";
            // 
            // uiDatetimePicker2
            // 
            uiDatetimePicker2.FillColor = Color.White;
            uiDatetimePicker2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDatetimePicker2.Location = new Point(589, 12);
            uiDatetimePicker2.Margin = new Padding(4, 5, 4, 5);
            uiDatetimePicker2.MaxLength = 19;
            uiDatetimePicker2.MinimumSize = new Size(63, 0);
            uiDatetimePicker2.Name = "uiDatetimePicker2";
            uiDatetimePicker2.Padding = new Padding(0, 0, 30, 2);
            uiDatetimePicker2.Size = new Size(264, 35);
            uiDatetimePicker2.SymbolDropDown = 61555;
            uiDatetimePicker2.SymbolNormal = 61555;
            uiDatetimePicker2.SymbolSize = 24;
            uiDatetimePicker2.TabIndex = 1;
            uiDatetimePicker2.Text = "2025-12-18 21:45:35";
            uiDatetimePicker2.TextAlignment = ContentAlignment.MiddleLeft;
            uiDatetimePicker2.Value = new DateTime(2025, 12, 18, 21, 45, 35, 987);
            uiDatetimePicker2.Watermark = "";
            // 
            // uiSymbolButton1
            // 
            uiSymbolButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolButton1.Location = new Point(903, 9);
            uiSymbolButton1.MinimumSize = new Size(1, 1);
            uiSymbolButton1.Name = "uiSymbolButton1";
            uiSymbolButton1.Size = new Size(132, 38);
            uiSymbolButton1.Symbol = 559520;
            uiSymbolButton1.TabIndex = 2;
            uiSymbolButton1.Text = "查询数据";
            uiSymbolButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolButton1.Click += uiSymbolButton1_Click;
            // 
            // uiLineChart1
            // 
            uiLineChart1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLineChart1.LegendFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLineChart1.Location = new Point(12, 68);
            uiLineChart1.MinimumSize = new Size(1, 1);
            uiLineChart1.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            uiLineChart1.Name = "uiLineChart1";
            uiLineChart1.Size = new Size(1061, 469);
            uiLineChart1.SubFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLineChart1.TabIndex = 3;
            uiLineChart1.Text = "uiLineChart1";
            // 
            // PageChartManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiLineChart1);
            Controls.Add(uiSymbolButton1);
            Controls.Add(uiDatetimePicker2);
            Controls.Add(uiDatetimePicker1);
            Controls.Add(uiSymbolLabel2);
            Controls.Add(uiSymbolLabel1);
            Name = "PageChartManage";
            Symbol = 61950;
            Text = "图表管理";
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker2;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UILineChart uiLineChart1;
    }
}