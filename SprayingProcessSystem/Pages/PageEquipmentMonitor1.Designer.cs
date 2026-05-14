namespace SprayingProcessSystem.Pages
{
    partial class PageEquipmentMonitor1
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
            components = new System.ComponentModel.Container();
            uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            userVarCurrentValue1 = new UserVarCurrentValue();
            userAlarmState2 = new UserAlarmState();
            userAlarmState1 = new UserAlarmState();
            userDeviceState1 = new UserDeviceState();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            userVarCurrentValue2 = new UserVarCurrentValue();
            userAlarmState3 = new UserAlarmState();
            userDeviceState3 = new UserDeviceState();
            userDeviceState2 = new UserDeviceState();
            uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            userAlarmState4 = new UserAlarmState();
            userDeviceState4 = new UserDeviceState();
            timer1 = new System.Windows.Forms.Timer(components);
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            uiTitlePanel3.SuspendLayout();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(userVarCurrentValue1);
            uiTitlePanel1.Controls.Add(userAlarmState2);
            uiTitlePanel1.Controls.Add(userAlarmState1);
            uiTitlePanel1.Controls.Add(userDeviceState1);
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel1.Location = new Point(0, 0);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(1085, 167);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "精洗工位";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userVarCurrentValue1
            // 
            userVarCurrentValue1.DeviceVarName = "精洗喷淋泵压力值";
            userVarCurrentValue1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userVarCurrentValue1.Location = new Point(22, 109);
            userVarCurrentValue1.MinimumSize = new Size(1, 1);
            userVarCurrentValue1.Name = "userVarCurrentValue1";
            userVarCurrentValue1.RectColor = Color.Transparent;
            userVarCurrentValue1.Size = new Size(431, 55);
            userVarCurrentValue1.TabIndex = 7;
            userVarCurrentValue1.Text = "userVarCurrentValue1";
            userVarCurrentValue1.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue1.Unit = "Map";
            userVarCurrentValue1.VariableName = "精洗喷淋泵压力值";
            userVarCurrentValue1.VarValue = 0F;
            // 
            // userAlarmState2
            // 
            userAlarmState2.DeviceName = "精洗低液位报警";
            userAlarmState2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userAlarmState2.Location = new Point(778, 44);
            userAlarmState2.MinimumSize = new Size(1, 1);
            userAlarmState2.Name = "userAlarmState2";
            userAlarmState2.RectColor = Color.Transparent;
            userAlarmState2.Size = new Size(258, 45);
            userAlarmState2.State = true;
            userAlarmState2.TabIndex = 6;
            userAlarmState2.Text = "userAlarmState2";
            userAlarmState2.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState2.VariableName = "精洗低液位报警";
            // 
            // userAlarmState1
            // 
            userAlarmState1.DeviceName = "精洗喷淋泵过载报警";
            userAlarmState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userAlarmState1.Location = new Point(408, 44);
            userAlarmState1.MinimumSize = new Size(1, 1);
            userAlarmState1.Name = "userAlarmState1";
            userAlarmState1.RectColor = Color.Transparent;
            userAlarmState1.Size = new Size(304, 45);
            userAlarmState1.State = true;
            userAlarmState1.TabIndex = 5;
            userAlarmState1.Text = "userAlarmState1";
            userAlarmState1.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState1.VariableName = "精洗喷淋泵过载报警";
            // 
            // userDeviceState1
            // 
            userDeviceState1.BackColor = Color.Transparent;
            userDeviceState1.DeviceRunName = "精洗洗喷淋泵运行状态";
            userDeviceState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceState1.Location = new Point(22, 44);
            userDeviceState1.MinimumSize = new Size(1, 1);
            userDeviceState1.Name = "userDeviceState1";
            userDeviceState1.RectColor = Color.Transparent;
            userDeviceState1.Size = new Size(333, 45);
            userDeviceState1.State = true;
            userDeviceState1.TabIndex = 4;
            userDeviceState1.Text = "userDeviceState1";
            userDeviceState1.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState1.VariableName = "精洗洗喷淋泵运行状态";
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(userVarCurrentValue2);
            uiTitlePanel2.Controls.Add(userAlarmState3);
            uiTitlePanel2.Controls.Add(userDeviceState3);
            uiTitlePanel2.Controls.Add(userDeviceState2);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel2.Location = new Point(0, 189);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(1085, 167);
            uiTitlePanel2.TabIndex = 1;
            uiTitlePanel2.Text = "水分炉工位";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userVarCurrentValue2
            // 
            userVarCurrentValue2.DeviceVarName = "水分炉测量温度";
            userVarCurrentValue2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userVarCurrentValue2.Location = new Point(22, 98);
            userVarCurrentValue2.MinimumSize = new Size(1, 1);
            userVarCurrentValue2.Name = "userVarCurrentValue2";
            userVarCurrentValue2.RectColor = Color.Transparent;
            userVarCurrentValue2.Size = new Size(405, 58);
            userVarCurrentValue2.TabIndex = 7;
            userVarCurrentValue2.Text = "userVarCurrentValue2";
            userVarCurrentValue2.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue2.Unit = "℃";
            userVarCurrentValue2.VariableName = "水分炉测量温度";
            userVarCurrentValue2.VarValue = 0F;
            // 
            // userAlarmState3
            // 
            userAlarmState3.DeviceName = "水分炉温度报警";
            userAlarmState3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userAlarmState3.Location = new Point(788, 47);
            userAlarmState3.MinimumSize = new Size(1, 1);
            userAlarmState3.Name = "userAlarmState3";
            userAlarmState3.RectColor = Color.Transparent;
            userAlarmState3.Size = new Size(258, 45);
            userAlarmState3.State = true;
            userAlarmState3.TabIndex = 6;
            userAlarmState3.Text = "userAlarmState3";
            userAlarmState3.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState3.VariableName = "水分炉温度报警";
            // 
            // userDeviceState3
            // 
            userDeviceState3.BackColor = Color.Transparent;
            userDeviceState3.DeviceRunName = "水分炉炉口风帘风机运行状态";
            userDeviceState3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceState3.Location = new Point(379, 47);
            userDeviceState3.MinimumSize = new Size(1, 1);
            userDeviceState3.Name = "userDeviceState3";
            userDeviceState3.RectColor = Color.Transparent;
            userDeviceState3.Size = new Size(403, 45);
            userDeviceState3.State = true;
            userDeviceState3.TabIndex = 5;
            userDeviceState3.Text = "userDeviceState3";
            userDeviceState3.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState3.VariableName = "水分炉炉口风帘风机运行状态";
            // 
            // userDeviceState2
            // 
            userDeviceState2.BackColor = Color.Transparent;
            userDeviceState2.DeviceRunName = "水分炉变频器运行状态";
            userDeviceState2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceState2.Location = new Point(22, 47);
            userDeviceState2.MinimumSize = new Size(1, 1);
            userDeviceState2.Name = "userDeviceState2";
            userDeviceState2.RectColor = Color.Transparent;
            userDeviceState2.Size = new Size(333, 45);
            userDeviceState2.State = true;
            userDeviceState2.TabIndex = 4;
            userDeviceState2.Text = "userDeviceState2";
            userDeviceState2.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState2.VariableName = "水分炉变频器运行状态";
            // 
            // uiTitlePanel3
            // 
            uiTitlePanel3.Controls.Add(userAlarmState4);
            uiTitlePanel3.Controls.Add(userDeviceState4);
            uiTitlePanel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel3.Location = new Point(0, 371);
            uiTitlePanel3.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel3.MinimumSize = new Size(1, 1);
            uiTitlePanel3.Name = "uiTitlePanel3";
            uiTitlePanel3.ShowText = false;
            uiTitlePanel3.Size = new Size(1085, 167);
            uiTitlePanel3.TabIndex = 2;
            uiTitlePanel3.Text = "冷却室工位";
            uiTitlePanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userAlarmState4
            // 
            userAlarmState4.DeviceName = "冷却室离心风机过载报警";
            userAlarmState4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userAlarmState4.Location = new Point(610, 74);
            userAlarmState4.MinimumSize = new Size(1, 1);
            userAlarmState4.Name = "userAlarmState4";
            userAlarmState4.RectColor = Color.Transparent;
            userAlarmState4.Size = new Size(344, 45);
            userAlarmState4.State = true;
            userAlarmState4.TabIndex = 5;
            userAlarmState4.Text = "userAlarmState4";
            userAlarmState4.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState4.VariableName = "冷却室离心风机过载报警";
            // 
            // userDeviceState4
            // 
            userDeviceState4.BackColor = Color.Transparent;
            userDeviceState4.DeviceRunName = "冷却室离心风机运行状态";
            userDeviceState4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceState4.Location = new Point(41, 74);
            userDeviceState4.MinimumSize = new Size(1, 1);
            userDeviceState4.Name = "userDeviceState4";
            userDeviceState4.RectColor = Color.Transparent;
            userDeviceState4.Size = new Size(356, 45);
            userDeviceState4.State = true;
            userDeviceState4.TabIndex = 4;
            userDeviceState4.Text = "userDeviceState4";
            userDeviceState4.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState4.VariableName = "冷却室离心风机运行状态";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // PageEquipmentMonitor1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel3);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageEquipmentMonitor1";
            Symbol = 57397;
            Text = "设备监控2";
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            uiTitlePanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private UserDeviceState userDeviceState1;
        private UserDeviceState userDeviceState3;
        private UserDeviceState userDeviceState2;
        private UserDeviceState userDeviceState4;
        private UserAlarmState userAlarmState2;
        private UserAlarmState userAlarmState1;
        private UserAlarmState userAlarmState3;
        private UserAlarmState userAlarmState4;
        private UserVarCurrentValue userVarCurrentValue1;
        private UserVarCurrentValue userVarCurrentValue2;
        private System.Windows.Forms.Timer timer1;
    }
}