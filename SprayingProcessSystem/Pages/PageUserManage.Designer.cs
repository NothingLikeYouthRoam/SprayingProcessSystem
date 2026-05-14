namespace SprayingProcessSystem.Pages
{
    partial class UserManage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            uiLabel1 = new Sunny.UI.UILabel();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            uiTextBox2 = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            uiTextBox3 = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            ID = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(23, 21);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(108, 23);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "用户名称";
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTextBox1.Location = new Point(138, 12);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(150, 44);
            uiTextBox1.TabIndex = 2;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "用户名称";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(23, 92);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(108, 23);
            uiLabel2.TabIndex = 0;
            uiLabel2.Text = "用户密码";
            // 
            // uiTextBox2
            // 
            uiTextBox2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTextBox2.Location = new Point(138, 83);
            uiTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiTextBox2.MinimumSize = new Size(1, 16);
            uiTextBox2.Name = "uiTextBox2";
            uiTextBox2.Padding = new Padding(5);
            uiTextBox2.ShowText = false;
            uiTextBox2.Size = new Size(150, 44);
            uiTextBox2.TabIndex = 2;
            uiTextBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox2.Watermark = "用户密码";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(23, 163);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(108, 23);
            uiLabel3.TabIndex = 0;
            uiLabel3.Text = "确认密码";
            // 
            // uiTextBox3
            // 
            uiTextBox3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTextBox3.Location = new Point(138, 154);
            uiTextBox3.Margin = new Padding(4, 5, 4, 5);
            uiTextBox3.MinimumSize = new Size(1, 16);
            uiTextBox3.Name = "uiTextBox3";
            uiTextBox3.Padding = new Padding(5);
            uiTextBox3.ShowText = false;
            uiTextBox3.Size = new Size(150, 44);
            uiTextBox3.TabIndex = 2;
            uiTextBox3.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox3.Watermark = "确认密码";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(23, 236);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(108, 23);
            uiLabel4.TabIndex = 0;
            uiLabel4.Text = "权限选择";
            // 
            // uiComboBox1
            // 
            uiComboBox1.DataSource = null;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiComboBox1.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiComboBox1.Items.AddRange(new object[] { "管理员", "工程师", "操作员", "访客" });
            uiComboBox1.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiComboBox1.Location = new Point(138, 226);
            uiComboBox1.Margin = new Padding(4, 5, 4, 5);
            uiComboBox1.MinimumSize = new Size(63, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 30, 2);
            uiComboBox1.Size = new Size(150, 44);
            uiComboBox1.SymbolSize = 24;
            uiComboBox1.TabIndex = 3;
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.Watermark = "权限选择";
            // 
            // uiSymbolButton1
            // 
            uiSymbolButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolButton1.Location = new Point(23, 294);
            uiSymbolButton1.MinimumSize = new Size(1, 1);
            uiSymbolButton1.Name = "uiSymbolButton1";
            uiSymbolButton1.Size = new Size(265, 60);
            uiSymbolButton1.Symbol = 561285;
            uiSymbolButton1.TabIndex = 4;
            uiSymbolButton1.Text = "添加用户";
            uiSymbolButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolButton1.Click += uiSymbolButton1_Click;
            // 
            // uiSymbolButton2
            // 
            uiSymbolButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolButton2.Location = new Point(23, 388);
            uiSymbolButton2.MinimumSize = new Size(1, 1);
            uiSymbolButton2.Name = "uiSymbolButton2";
            uiSymbolButton2.Size = new Size(265, 60);
            uiSymbolButton2.Symbol = 362719;
            uiSymbolButton2.TabIndex = 4;
            uiSymbolButton2.Text = "修改用户";
            uiSymbolButton2.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolButton2.Click += uiSymbolButton2_Click;
            // 
            // uiSymbolButton3
            // 
            uiSymbolButton3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolButton3.Location = new Point(23, 477);
            uiSymbolButton3.MinimumSize = new Size(1, 1);
            uiSymbolButton3.Name = "uiSymbolButton3";
            uiSymbolButton3.Size = new Size(265, 60);
            uiSymbolButton3.Symbol = 561286;
            uiSymbolButton3.TabIndex = 4;
            uiSymbolButton3.Text = "删除用户";
            uiSymbolButton3.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolButton3.Click += uiSymbolButton3_Click;
            // 
            // uiDataGridView1
            // 
            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView1.BackgroundColor = Color.White;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView1.ColumnHeadersHeight = 32;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, User, password, role });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(334, 14);
            uiDataGridView1.Name = "uiDataGridView1";
            uiDataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            uiDataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            uiDataGridView1.Size = new Size(739, 523);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 5;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 170;
            // 
            // User
            // 
            User.DataPropertyName = "UserName";
            User.HeaderText = "用户名";
            User.MinimumWidth = 8;
            User.Name = "User";
            User.ReadOnly = true;
            User.Width = 225;
            // 
            // password
            // 
            password.DataPropertyName = "UserPassword";
            password.HeaderText = "密码";
            password.MinimumWidth = 8;
            password.Name = "password";
            password.ReadOnly = true;
            password.Width = 225;
            // 
            // role
            // 
            role.DataPropertyName = "Role";
            role.HeaderText = "角色";
            role.MinimumWidth = 8;
            role.Name = "role";
            role.ReadOnly = true;
            role.Width = 225;
            // 
            // UserManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiDataGridView1);
            Controls.Add(uiSymbolButton3);
            Controls.Add(uiSymbolButton2);
            Controls.Add(uiSymbolButton1);
            Controls.Add(uiComboBox1);
            Controls.Add(uiTextBox3);
            Controls.Add(uiTextBox2);
            Controls.Add(uiTextBox1);
            Controls.Add(uiLabel4);
            Controls.Add(uiLabel3);
            Controls.Add(uiLabel2);
            Controls.Add(uiLabel1);
            Name = "UserManage";
            Symbol = 61447;
            Text = "用户管理";
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn role;
    }
}