namespace SprayingProcessSystem
{
    partial class UserAlarmState
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.BackColor = Color.Transparent;
            uiTableLayoutPanel1.ColumnCount = 2;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            uiTableLayoutPanel1.Controls.Add(uiLabel1, 0, 0);
            uiTableLayoutPanel1.Controls.Add(uiSymbolLabel1, 1, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.Size = new Size(250, 60);
            uiTableLayoutPanel1.TabIndex = 0;
            uiTableLayoutPanel1.TagString = null;
            // 
            // uiLabel1
            // 
            uiLabel1.Dock = DockStyle.Fill;
            uiLabel1.Font = new Font("微软雅黑", 12F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(3, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(184, 60);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "报警名称";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Dock = DockStyle.Fill;
            uiSymbolLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolLabel1.Location = new Point(193, 3);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(54, 54);
            uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolLabel1.Symbol = 61683;
            uiSymbolLabel1.SymbolColor = Color.Red;
            uiSymbolLabel1.SymbolSize = 54;
            uiSymbolLabel1.TabIndex = 1;
            // 
            // UserAlarmState
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(uiTableLayoutPanel1);
            Name = "UserAlarmState";
            RectColor = Color.Transparent;
            Size = new Size(250, 60);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}
