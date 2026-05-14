namespace SprayingProcessSystem
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            uiPanel1 = new Sunny.UI.UIPanel();
            lbl_Exit = new Sunny.UI.UISymbolLabel();
            lbl_Time = new Sunny.UI.UILabel();
            lbl_Min = new Sunny.UI.UISymbolLabel();
            lbl_Humidness = new Sunny.UI.UILabel();
            uiLabel6 = new Sunny.UI.UILabel();
            lbl_Temperature = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            st_AlarmInfo = new Sunny.UI.UIScrollingText();
            uiLabel1 = new Sunny.UI.UILabel();
            pictureBox2 = new PictureBox();
            lbl_Subhead = new Sunny.UI.UILabel();
            lbl_Title = new Sunny.UI.UILabel();
            pictureBox1 = new PictureBox();
            uiLabel3 = new Sunny.UI.UILabel();
            lbl_ProducteCount = new Sunny.UI.UILedLabel();
            uiLabel5 = new Sunny.UI.UILabel();
            uiLedLabel2 = new Sunny.UI.UILedLabel();
            uiLabel7 = new Sunny.UI.UILabel();
            uiLedLabel1 = new Sunny.UI.UILedLabel();
            uiLabel8 = new Sunny.UI.UILabel();
            uiLabel9 = new Sunny.UI.UILabel();
            uiLedLabel3 = new Sunny.UI.UILedLabel();
            uiLabel10 = new Sunny.UI.UILabel();
            uiLedBulb1 = new Sunny.UI.UILedBulb();
            uiLabel11 = new Sunny.UI.UILabel();
            uiLabel12 = new Sunny.UI.UILabel();
            uiLabel13 = new Sunny.UI.UILabel();
            uiLabel14 = new Sunny.UI.UILabel();
            uiLabel15 = new Sunny.UI.UILabel();
            uiLabel16 = new Sunny.UI.UILabel();
            uiLabel17 = new Sunny.UI.UILabel();
            uiLabel18 = new Sunny.UI.UILabel();
            uiLabel19 = new Sunny.UI.UILabel();
            uiLabel20 = new Sunny.UI.UILabel();
            led_ProducteState = new Sunny.UI.UILedBulb();
            uiStyleManager1 = new Sunny.UI.UIStyleManager(components);
            Footer.SuspendLayout();
            Header.SuspendLayout();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Footer
            // 
            Footer.Controls.Add(uiLedBulb1);
            Footer.Controls.Add(uiLabel11);
            Footer.Controls.Add(uiLabel20);
            Footer.Controls.Add(uiLabel18);
            Footer.Controls.Add(uiLabel16);
            Footer.Controls.Add(uiLabel14);
            Footer.Controls.Add(uiLabel12);
            Footer.Controls.Add(uiLabel15);
            Footer.Controls.Add(uiLabel19);
            Footer.Controls.Add(uiLabel17);
            Footer.Controls.Add(uiLabel13);
            Footer.Controls.Add(uiLabel10);
            Footer.Location = new Point(195, 664);
            Footer.Size = new Size(1085, 56);
            // 
            // Aside
            // 
            Aside.Location = new Point(0, 115);
            Aside.Size = new Size(195, 605);
            Aside.BeforeExpand += Aside_BeforeExpand;
            // 
            // Header
            // 
            Header.Controls.Add(led_ProducteState);
            Header.Controls.Add(uiLedLabel3);
            Header.Controls.Add(uiLedLabel1);
            Header.Controls.Add(uiLedLabel2);
            Header.Controls.Add(lbl_ProducteCount);
            Header.Controls.Add(uiLabel5);
            Header.Controls.Add(uiLabel9);
            Header.Controls.Add(uiLabel8);
            Header.Controls.Add(uiLabel7);
            Header.Controls.Add(uiLabel3);
            Header.Controls.Add(uiPanel1);
            Header.Location = new Point(0, 0);
            Header.NodeInterval = 0;
            Header.NodeSize = new Size(70, 50);
            Header.Size = new Size(1280, 115);
            Header.Text = "主窗体";
            Header.MenuItemClick += Header_MenuItemClick;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(lbl_Exit);
            uiPanel1.Controls.Add(lbl_Time);
            uiPanel1.Controls.Add(lbl_Min);
            uiPanel1.Controls.Add(lbl_Humidness);
            uiPanel1.Controls.Add(uiLabel6);
            uiPanel1.Controls.Add(lbl_Temperature);
            uiPanel1.Controls.Add(uiLabel4);
            uiPanel1.Controls.Add(st_AlarmInfo);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Controls.Add(pictureBox2);
            uiPanel1.Controls.Add(lbl_Subhead);
            uiPanel1.Controls.Add(lbl_Title);
            uiPanel1.Controls.Add(pictureBox1);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(1272, 58);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            uiPanel1.MouseDown += Panel_MouseDown;
            uiPanel1.MouseMove += Panel_MouseMove;
            // 
            // lbl_Exit
            // 
            lbl_Exit.BackColor = Color.Transparent;
            lbl_Exit.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_Exit.Location = new Point(1216, 12);
            lbl_Exit.MinimumSize = new Size(1, 1);
            lbl_Exit.Name = "lbl_Exit";
            lbl_Exit.Size = new Size(46, 35);
            lbl_Exit.Symbol = 61453;
            lbl_Exit.SymbolSize = 45;
            lbl_Exit.TabIndex = 12;
            lbl_Exit.Click += lbl_Exit_Click;
            // 
            // lbl_Time
            // 
            lbl_Time.BackColor = Color.Transparent;
            lbl_Time.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Time.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_Time.Location = new Point(1038, 9);
            lbl_Time.Name = "lbl_Time";
            lbl_Time.Size = new Size(104, 43);
            lbl_Time.TabIndex = 11;
            lbl_Time.Text = "2024-10-12";
            lbl_Time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Min
            // 
            lbl_Min.BackColor = Color.Transparent;
            lbl_Min.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_Min.Location = new Point(1157, 14);
            lbl_Min.MinimumSize = new Size(1, 1);
            lbl_Min.Name = "lbl_Min";
            lbl_Min.Size = new Size(46, 35);
            lbl_Min.Symbol = 61544;
            lbl_Min.SymbolSize = 45;
            lbl_Min.TabIndex = 12;
            lbl_Min.Click += lbl_Min_Click;
            // 
            // lbl_Humidness
            // 
            lbl_Humidness.BackColor = Color.Transparent;
            lbl_Humidness.Font = new Font("宋体", 10.5F);
            lbl_Humidness.ForeColor = Color.Green;
            lbl_Humidness.Location = new Point(968, 32);
            lbl_Humidness.Name = "lbl_Humidness";
            lbl_Humidness.Size = new Size(46, 20);
            lbl_Humidness.TabIndex = 10;
            lbl_Humidness.TagString = "厂内湿度";
            lbl_Humidness.Text = "60%";
            // 
            // uiLabel6
            // 
            uiLabel6.BackColor = Color.Transparent;
            uiLabel6.Font = new Font("宋体", 7.5F);
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Image = Properties.Resources.湿度;
            uiLabel6.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel6.Location = new Point(921, 5);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(102, 27);
            uiLabel6.TabIndex = 9;
            uiLabel6.Text = "厂房湿度";
            uiLabel6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Temperature
            // 
            lbl_Temperature.BackColor = Color.Transparent;
            lbl_Temperature.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_Temperature.ForeColor = Color.Green;
            lbl_Temperature.Location = new Point(852, 32);
            lbl_Temperature.Name = "lbl_Temperature";
            lbl_Temperature.Size = new Size(63, 23);
            lbl_Temperature.TabIndex = 8;
            lbl_Temperature.TagString = "厂内温度";
            lbl_Temperature.Text = "25℃";
            // 
            // uiLabel4
            // 
            uiLabel4.BackColor = Color.Transparent;
            uiLabel4.Font = new Font("宋体", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Image = Properties.Resources.温度;
            uiLabel4.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel4.Location = new Point(815, 5);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(100, 31);
            uiLabel4.TabIndex = 7;
            uiLabel4.Text = "厂房温度";
            uiLabel4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // st_AlarmInfo
            // 
            st_AlarmInfo.Active = true;
            st_AlarmInfo.BackColor = Color.Transparent;
            st_AlarmInfo.Font = new Font("宋体", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            st_AlarmInfo.Location = new Point(496, 8);
            st_AlarmInfo.MinimumSize = new Size(1, 1);
            st_AlarmInfo.Name = "st_AlarmInfo";
            st_AlarmInfo.Size = new Size(318, 41);
            st_AlarmInfo.TabIndex = 5;
            st_AlarmInfo.Text = "系统正常";
            st_AlarmInfo.MouseDown += Panel_MouseDown;
            st_AlarmInfo.MouseMove += Panel_MouseMove;
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(403, 11);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(87, 37);
            uiLabel1.TabIndex = 4;
            uiLabel1.Text = "张钰春";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.用户;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(348, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 48);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lbl_Subhead
            // 
            lbl_Subhead.BackColor = Color.Transparent;
            lbl_Subhead.Font = new Font("宋体", 8F);
            lbl_Subhead.ForeColor = SystemColors.Highlight;
            lbl_Subhead.Location = new Point(82, 36);
            lbl_Subhead.Name = "lbl_Subhead";
            lbl_Subhead.Size = new Size(232, 23);
            lbl_Subhead.TabIndex = 2;
            lbl_Subhead.Text = "Spray Process SCADA System";
            // 
            // lbl_Title
            // 
            lbl_Title.BackColor = Color.Transparent;
            lbl_Title.Font = new Font("宋体", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbl_Title.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_Title.Location = new Point(63, 2);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(279, 35);
            lbl_Title.TabIndex = 1;
            lbl_Title.Text = "喷涂工艺SCADA系统";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.喷涂生产;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(13, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 48);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            uiLabel3.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Image = Properties.Resources.产量;
            uiLabel3.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel3.Location = new Point(0, 58);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(134, 57);
            uiLabel3.TabIndex = 1;
            uiLabel3.Text = "生产计数";
            uiLabel3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_ProducteCount
            // 
            lbl_ProducteCount.BackColor = Color.Transparent;
            lbl_ProducteCount.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_ProducteCount.ForeColor = Color.DeepSkyBlue;
            lbl_ProducteCount.Location = new Point(140, 59);
            lbl_ProducteCount.MinimumSize = new Size(1, 1);
            lbl_ProducteCount.Name = "lbl_ProducteCount";
            lbl_ProducteCount.Size = new Size(88, 56);
            lbl_ProducteCount.TabIndex = 2;
            lbl_ProducteCount.TagString = "生产计数";
            lbl_ProducteCount.Text = "5000";
            // 
            // uiLabel5
            // 
            uiLabel5.BackColor = Color.Transparent;
            uiLabel5.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Image = Properties.Resources.产量;
            uiLabel5.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel5.Location = new Point(235, 58);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(134, 58);
            uiLabel5.TabIndex = 1;
            uiLabel5.Text = "不良计数";
            uiLabel5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiLedLabel2
            // 
            uiLedLabel2.BackColor = Color.Transparent;
            uiLedLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLedLabel2.ForeColor = Color.DeepSkyBlue;
            uiLedLabel2.Location = new Point(375, 58);
            uiLedLabel2.MinimumSize = new Size(1, 1);
            uiLedLabel2.Name = "uiLedLabel2";
            uiLedLabel2.Size = new Size(82, 58);
            uiLedLabel2.TabIndex = 2;
            uiLedLabel2.TagString = "不良计数";
            uiLedLabel2.Text = "5000";
            // 
            // uiLabel7
            // 
            uiLabel7.BackColor = Color.Transparent;
            uiLabel7.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel7.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel7.Image = Properties.Resources.生产节拍;
            uiLabel7.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel7.Location = new Point(464, 58);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new Size(134, 58);
            uiLabel7.TabIndex = 1;
            uiLabel7.Text = "生产节拍";
            uiLabel7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiLedLabel1
            // 
            uiLedLabel1.BackColor = Color.Transparent;
            uiLedLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLedLabel1.ForeColor = Color.DeepSkyBlue;
            uiLedLabel1.Location = new Point(600, 59);
            uiLedLabel1.MinimumSize = new Size(1, 1);
            uiLedLabel1.Name = "uiLedLabel1";
            uiLedLabel1.Size = new Size(59, 58);
            uiLedLabel1.TabIndex = 2;
            uiLedLabel1.TagString = "生产节拍";
            uiLedLabel1.Text = "60S";
            // 
            // uiLabel8
            // 
            uiLabel8.BackColor = Color.Transparent;
            uiLabel8.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel8.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel8.Image = Properties.Resources.报警数;
            uiLabel8.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel8.Location = new Point(670, 58);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new Size(134, 58);
            uiLabel8.TabIndex = 1;
            uiLabel8.Text = "累计报警";
            uiLabel8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiLabel9
            // 
            uiLabel9.BackColor = Color.Transparent;
            uiLabel9.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel9.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel9.Image = Properties.Resources.生产节拍;
            uiLabel9.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel9.Location = new Point(898, 59);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new Size(125, 56);
            uiLabel9.TabIndex = 1;
            uiLabel9.Text = "系统状态";
            uiLabel9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiLedLabel3
            // 
            uiLedLabel3.BackColor = Color.Transparent;
            uiLedLabel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLedLabel3.ForeColor = Color.DeepSkyBlue;
            uiLedLabel3.Location = new Point(810, 58);
            uiLedLabel3.MinimumSize = new Size(1, 1);
            uiLedLabel3.Name = "uiLedLabel3";
            uiLedLabel3.Size = new Size(82, 58);
            uiLedLabel3.TabIndex = 2;
            uiLedLabel3.TagString = "累计报警";
            uiLedLabel3.Text = "5000";
            // 
            // uiLabel10
            // 
            uiLabel10.BackColor = Color.Transparent;
            uiLabel10.Font = new Font("宋体", 10F);
            uiLabel10.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel10.Image = Properties.Resources.连接状态;
            uiLabel10.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel10.Location = new Point(3, 13);
            uiLabel10.Name = "uiLabel10";
            uiLabel10.Size = new Size(154, 34);
            uiLabel10.TabIndex = 0;
            uiLabel10.Text = "PLC连接状态";
            uiLabel10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiLedBulb1
            // 
            uiLedBulb1.BackColor = Color.Transparent;
            uiLedBulb1.Location = new Point(157, 11);
            uiLedBulb1.Name = "uiLedBulb1";
            uiLedBulb1.Size = new Size(35, 35);
            uiLedBulb1.TabIndex = 3;
            uiLedBulb1.Text = "uiLedBulb1";
            // 
            // uiLabel11
            // 
            uiLabel11.BackColor = Color.Transparent;
            uiLabel11.Font = new Font("宋体", 10F);
            uiLabel11.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel11.Image = Properties.Resources.CPU信息;
            uiLabel11.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel11.Location = new Point(209, 13);
            uiLabel11.Name = "uiLabel11";
            uiLabel11.Size = new Size(114, 34);
            uiLabel11.TabIndex = 0;
            uiLabel11.Text = "CPU信息";
            uiLabel11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiLabel12
            // 
            uiLabel12.BackColor = Color.Transparent;
            uiLabel12.Font = new Font("宋体", 10F);
            uiLabel12.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel12.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel12.Location = new Point(313, 13);
            uiLabel12.Name = "uiLabel12";
            uiLabel12.Size = new Size(54, 34);
            uiLabel12.TabIndex = 0;
            uiLabel12.Text = "58%";
            uiLabel12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel13
            // 
            uiLabel13.BackColor = Color.Transparent;
            uiLabel13.Font = new Font("宋体", 10F);
            uiLabel13.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel13.Image = Properties.Resources.内存信息;
            uiLabel13.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel13.Location = new Point(369, 13);
            uiLabel13.Name = "uiLabel13";
            uiLabel13.Size = new Size(120, 34);
            uiLabel13.TabIndex = 0;
            uiLabel13.Text = "内存信息";
            uiLabel13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiLabel14
            // 
            uiLabel14.BackColor = Color.Transparent;
            uiLabel14.Font = new Font("宋体", 10F);
            uiLabel14.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel14.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel14.Location = new Point(482, 13);
            uiLabel14.Name = "uiLabel14";
            uiLabel14.Size = new Size(46, 34);
            uiLabel14.TabIndex = 0;
            uiLabel14.Text = "58%";
            uiLabel14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel15
            // 
            uiLabel15.BackColor = Color.Transparent;
            uiLabel15.Font = new Font("宋体", 10F);
            uiLabel15.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel15.Image = Properties.Resources.软件版本;
            uiLabel15.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel15.Location = new Point(527, 13);
            uiLabel15.Name = "uiLabel15";
            uiLabel15.Size = new Size(120, 34);
            uiLabel15.TabIndex = 0;
            uiLabel15.Text = "软件版本";
            uiLabel15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiLabel16
            // 
            uiLabel16.BackColor = Color.Transparent;
            uiLabel16.Font = new Font("宋体", 10F);
            uiLabel16.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel16.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel16.Location = new Point(642, 13);
            uiLabel16.Name = "uiLabel16";
            uiLabel16.Size = new Size(49, 34);
            uiLabel16.TabIndex = 0;
            uiLabel16.Text = "V1.0";
            uiLabel16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel17
            // 
            uiLabel17.BackColor = Color.Transparent;
            uiLabel17.Font = new Font("宋体", 10F);
            uiLabel17.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel17.Image = Properties.Resources.授权;
            uiLabel17.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel17.Location = new Point(703, 13);
            uiLabel17.Name = "uiLabel17";
            uiLabel17.Size = new Size(120, 34);
            uiLabel17.TabIndex = 0;
            uiLabel17.Text = "是否授权";
            uiLabel17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiLabel18
            // 
            uiLabel18.BackColor = Color.Transparent;
            uiLabel18.Font = new Font("宋体", 10F);
            uiLabel18.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel18.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel18.Location = new Point(819, 13);
            uiLabel18.Name = "uiLabel18";
            uiLabel18.Size = new Size(33, 34);
            uiLabel18.TabIndex = 0;
            uiLabel18.Text = "是";
            uiLabel18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel19
            // 
            uiLabel19.BackColor = Color.Transparent;
            uiLabel19.Font = new Font("宋体", 10F);
            uiLabel19.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel19.Image = Properties.Resources.期限;
            uiLabel19.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel19.Location = new Point(858, 13);
            uiLabel19.Name = "uiLabel19";
            uiLabel19.Size = new Size(124, 34);
            uiLabel19.TabIndex = 0;
            uiLabel19.Text = "使用期限";
            uiLabel19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiLabel20
            // 
            uiLabel20.BackColor = Color.Transparent;
            uiLabel20.Font = new Font("宋体", 10F);
            uiLabel20.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel20.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel20.Location = new Point(977, 12);
            uiLabel20.Name = "uiLabel20";
            uiLabel20.Size = new Size(100, 34);
            uiLabel20.TabIndex = 0;
            uiLabel20.Text = "试用5分钟";
            uiLabel20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // led_ProducteState
            // 
            led_ProducteState.BackColor = Color.Transparent;
            led_ProducteState.BlinkInterval = 500;
            led_ProducteState.Location = new Point(1029, 64);
            led_ProducteState.Name = "led_ProducteState";
            led_ProducteState.Size = new Size(45, 45);
            led_ProducteState.TabIndex = 4;
            led_ProducteState.Text = "uiLedBulb1";
            // 
            // uiStyleManager1
            // 
            uiStyleManager1.DPIScale = true;
            uiStyleManager1.GlobalFont = true;
            // 
            // FrmMain
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 720);
            CloseAskString = "是否关闭系统";
            EscClose = true;
            Name = "FrmMain";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "主窗体";
            ZoomScaleRect = new Rectangle(22, 22, 800, 450);
            Shown += FrmMain_Shown;
            Footer.ResumeLayout(false);
            Header.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel lbl_Title;
        private PictureBox pictureBox1;
        private Sunny.UI.UILabel lbl_Subhead;
        private Sunny.UI.UILabel uiLabel1;
        private PictureBox pictureBox2;
        private Sunny.UI.UIScrollingText st_AlarmInfo;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel lbl_Temperature;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel lbl_Humidness;
        private Sunny.UI.UISymbolLabel lbl_Min;
        private Sunny.UI.UILabel lbl_Time;
        private Sunny.UI.UISymbolLabel lbl_Exit;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILedLabel uiLedLabel1;
        private Sunny.UI.UILedLabel uiLedLabel2;
        private Sunny.UI.UILedLabel lbl_ProducteCount;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILedLabel uiLedLabel3;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILedBulb uiLedBulb1;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel16;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UILabel uiLabel17;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UILabel uiLabel18;
        private Sunny.UI.UILabel uiLabel19;
        private Sunny.UI.UILabel uiLabel20;
        private Sunny.UI.UILedBulb led_ProducteState;
        private Sunny.UI.UIStyleManager uiStyleManager1;
    }
}
