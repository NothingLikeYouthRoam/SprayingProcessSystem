namespace SprayingProcessSystem
{
    partial class UserVarCurrentValue
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
            uiDigitalLabel1 = new Sunny.UI.UIDigitalLabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.BackColor = Color.Transparent;
            uiTableLayoutPanel1.ColumnCount = 3;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            uiTableLayoutPanel1.Controls.Add(uiLabel1, 0, 0);
            uiTableLayoutPanel1.Controls.Add(uiDigitalLabel1, 1, 0);
            uiTableLayoutPanel1.Controls.Add(uiLabel2, 2, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.Size = new Size(337, 60);
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
            uiLabel1.Size = new Size(131, 60);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "名称";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiDigitalLabel1
            // 
            uiDigitalLabel1.BackColor = Color.Transparent;
            uiDigitalLabel1.DecimalPlaces = 1;
            uiDigitalLabel1.Dock = DockStyle.Fill;
            uiDigitalLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDigitalLabel1.ForeColor = Color.DeepSkyBlue;
            uiDigitalLabel1.Location = new Point(140, 3);
            uiDigitalLabel1.MinimumSize = new Size(1, 1);
            uiDigitalLabel1.Name = "uiDigitalLabel1";
            uiDigitalLabel1.Size = new Size(109, 54);
            uiDigitalLabel1.TabIndex = 1;
            uiDigitalLabel1.Text = "uiDigitalLabel1";
            uiDigitalLabel1.TextAlign = HorizontalAlignment.Center;
            // 
            // uiLabel2
            // 
            uiLabel2.Dock = DockStyle.Fill;
            uiLabel2.Font = new Font("微软雅黑", 12F);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(255, 0);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(79, 60);
            uiLabel2.TabIndex = 2;
            uiLabel2.Text = "单位";
            uiLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserVarCurrentValue
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(uiTableLayoutPanel1);
            Name = "UserVarCurrentValue";
            RectColor = Color.Transparent;
            Size = new Size(337, 60);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDigitalLabel uiDigitalLabel1;
        private Sunny.UI.UILabel uiLabel2;
    }
}
