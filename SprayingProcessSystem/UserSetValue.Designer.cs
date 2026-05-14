namespace SprayingProcessSystem
{
    partial class UserSetValue
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
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.BackColor = Color.Transparent;
            uiTableLayoutPanel1.ColumnCount = 3;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            uiTableLayoutPanel1.Controls.Add(uiLabel1, 0, 0);
            uiTableLayoutPanel1.Controls.Add(uiTextBox1, 1, 0);
            uiTableLayoutPanel1.Controls.Add(uiLabel2, 2, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            uiTableLayoutPanel1.Size = new Size(337, 46);
            uiTableLayoutPanel1.TabIndex = 0;
            uiTableLayoutPanel1.TagString = null;
            // 
            // uiLabel1
            // 
            uiLabel1.Dock = DockStyle.Fill;
            uiLabel1.Font = new Font("微软雅黑", 10F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(3, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(161, 46);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "参数名称";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiTextBox1
            // 
            uiTextBox1.Dock = DockStyle.Fill;
            uiTextBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTextBox1.Location = new Point(171, 5);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(92, 36);
            uiTextBox1.TabIndex = 1;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleCenter;
            uiTextBox1.Watermark = "";
            uiTextBox1.TextChanged += txt_Value_TextChanged;
            // 
            // uiLabel2
            // 
            uiLabel2.Dock = DockStyle.Fill;
            uiLabel2.Font = new Font("微软雅黑", 10F);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(270, 0);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(64, 46);
            uiLabel2.TabIndex = 2;
            uiLabel2.Text = "单位";
            uiLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserSetValue
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(uiTableLayoutPanel1);
            Name = "UserSetValue";
            RectColor = Color.Transparent;
            Size = new Size(337, 46);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel2;
    }
}
