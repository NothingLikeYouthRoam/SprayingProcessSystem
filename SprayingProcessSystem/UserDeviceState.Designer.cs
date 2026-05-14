namespace SprayingProcessSystem
{
    partial class UserDeviceState
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
            uiLight1 = new Sunny.UI.UILight();
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
            uiTableLayoutPanel1.Controls.Add(uiLight1, 1, 0);
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
            uiLabel1.Text = "状态名称";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLight1
            // 
            uiLight1.Dock = DockStyle.Fill;
            uiLight1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLight1.Location = new Point(193, 3);
            uiLight1.MinimumSize = new Size(1, 1);
            uiLight1.Name = "uiLight1";
            uiLight1.OffColor = Color.Red;
            uiLight1.Radius = 54;
            uiLight1.Size = new Size(54, 54);
            uiLight1.TabIndex = 1;
            uiLight1.Text = "uiLight1";
            // 
            // UserDeviceState
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Transparent;
            Controls.Add(uiTableLayoutPanel1);
            Name = "UserDeviceState";
            RectColor = Color.Transparent;
            Size = new Size(250, 60);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILight uiLight1;
    }
}
