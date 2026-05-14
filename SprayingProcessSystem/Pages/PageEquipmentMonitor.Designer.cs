namespace SprayingProcessSystem.Pages
{
    partial class PageEquipmentMonitor
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
            userVarCurrentValue2 = new UserVarCurrentValue();
            userVarCurrentValue1 = new UserVarCurrentValue();
            userAlarmState1 = new UserAlarmState();
            userDeviceState2 = new UserDeviceState();
            userDeviceState1 = new UserDeviceState();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            userAlarmState3 = new UserAlarmState();
            userVarCurrentValue3 = new UserVarCurrentValue();
            userAlarmState2 = new UserAlarmState();
            userDeviceState3 = new UserDeviceState();
            uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            userVarCurrentValue4 = new UserVarCurrentValue();
            userVarCurrentValue5 = new UserVarCurrentValue();
            userAlarmState5 = new UserAlarmState();
            userDeviceState5 = new UserDeviceState();
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
            uiTitlePanel1.Controls.Add(userVarCurrentValue2);
            uiTitlePanel1.Controls.Add(userVarCurrentValue1);
            uiTitlePanel1.Controls.Add(userAlarmState1);
            uiTitlePanel1.Controls.Add(userDeviceState2);
            uiTitlePanel1.Controls.Add(userDeviceState1);
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel1.Location = new Point(0, 0);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(1085, 167);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "脱脂工位";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userVarCurrentValue2
            // 
            userVarCurrentValue2.DeviceVarName = "脱脂pH值";
            userVarCurrentValue2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userVarCurrentValue2.Location = new Point(619, 101);
            userVarCurrentValue2.MinimumSize = new Size(1, 1);
            userVarCurrentValue2.Name = "userVarCurrentValue2";
            userVarCurrentValue2.RectColor = Color.Transparent;
            userVarCurrentValue2.Size = new Size(391, 58);
            userVarCurrentValue2.TabIndex = 11;
            userVarCurrentValue2.Text = "userVarCurrentValue2";
            userVarCurrentValue2.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue2.Unit = "PH";
            userVarCurrentValue2.VariableName = "脱脂pH值";
            userVarCurrentValue2.VarValue = 0F;
            // 
            // userVarCurrentValue1
            // 
            userVarCurrentValue1.DeviceVarName = "脱脂喷淋泵压力值";
            userVarCurrentValue1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userVarCurrentValue1.Location = new Point(73, 101);
            userVarCurrentValue1.MinimumSize = new Size(1, 1);
            userVarCurrentValue1.Name = "userVarCurrentValue1";
            userVarCurrentValue1.RectColor = Color.Transparent;
            userVarCurrentValue1.Size = new Size(455, 58);
            userVarCurrentValue1.TabIndex = 1;
            userVarCurrentValue1.Text = "userVarCurrentValue1";
            userVarCurrentValue1.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue1.Unit = "Map";
            userVarCurrentValue1.VariableName = "脱脂喷淋泵压力值";
            userVarCurrentValue1.VarValue = 0F;
            // 
            // userAlarmState1
            // 
            userAlarmState1.DeviceName = "脱脂低液位报警";
            userAlarmState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userAlarmState1.Location = new Point(781, 41);
            userAlarmState1.MinimumSize = new Size(1, 1);
            userAlarmState1.Name = "userAlarmState1";
            userAlarmState1.RectColor = Color.Transparent;
            userAlarmState1.Size = new Size(258, 45);
            userAlarmState1.State = true;
            userAlarmState1.TabIndex = 3;
            userAlarmState1.Text = "userAlarmState1";
            userAlarmState1.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState1.VariableName = "脱脂低液位报警";
            // 
            // userDeviceState2
            // 
            userDeviceState2.BackColor = Color.Transparent;
            userDeviceState2.DeviceRunName = "脱脂排风机运行状态";
            userDeviceState2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceState2.Location = new Point(395, 41);
            userDeviceState2.MinimumSize = new Size(1, 1);
            userDeviceState2.Name = "userDeviceState2";
            userDeviceState2.RectColor = Color.Transparent;
            userDeviceState2.Size = new Size(308, 45);
            userDeviceState2.State = true;
            userDeviceState2.TabIndex = 10;
            userDeviceState2.Text = "userDeviceState2";
            userDeviceState2.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState2.VariableName = "脱脂排风机运行状态";
            // 
            // userDeviceState1
            // 
            userDeviceState1.BackColor = Color.Transparent;
            userDeviceState1.DeviceRunName = "脱脂喷淋泵运行状态";
            userDeviceState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceState1.Location = new Point(41, 41);
            userDeviceState1.MinimumSize = new Size(1, 1);
            userDeviceState1.Name = "userDeviceState1";
            userDeviceState1.RectColor = Color.Transparent;
            userDeviceState1.Size = new Size(299, 45);
            userDeviceState1.State = true;
            userDeviceState1.TabIndex = 3;
            userDeviceState1.Text = "userDeviceState1";
            userDeviceState1.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState1.VariableName = "脱脂喷淋泵运行状态";
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(userAlarmState3);
            uiTitlePanel2.Controls.Add(userVarCurrentValue3);
            uiTitlePanel2.Controls.Add(userAlarmState2);
            uiTitlePanel2.Controls.Add(userDeviceState3);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel2.Location = new Point(0, 189);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(1085, 167);
            uiTitlePanel2.TabIndex = 1;
            uiTitlePanel2.Text = "粗洗工位";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userAlarmState3
            // 
            userAlarmState3.DeviceName = "粗洗低液位报警";
            userAlarmState3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userAlarmState3.Location = new Point(781, 48);
            userAlarmState3.MinimumSize = new Size(1, 1);
            userAlarmState3.Name = "userAlarmState3";
            userAlarmState3.RectColor = Color.Transparent;
            userAlarmState3.Size = new Size(258, 45);
            userAlarmState3.State = true;
            userAlarmState3.TabIndex = 12;
            userAlarmState3.Text = "userAlarmState3";
            userAlarmState3.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState3.VariableName = "粗洗低液位报警";
            // 
            // userVarCurrentValue3
            // 
            userVarCurrentValue3.DeviceVarName = "粗洗喷淋泵压力值";
            userVarCurrentValue3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userVarCurrentValue3.Location = new Point(73, 99);
            userVarCurrentValue3.MinimumSize = new Size(1, 1);
            userVarCurrentValue3.Name = "userVarCurrentValue3";
            userVarCurrentValue3.RectColor = Color.Transparent;
            userVarCurrentValue3.Size = new Size(455, 58);
            userVarCurrentValue3.TabIndex = 13;
            userVarCurrentValue3.Text = "userVarCurrentValue3";
            userVarCurrentValue3.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue3.Unit = "Map";
            userVarCurrentValue3.VariableName = "粗洗喷淋泵压力值";
            userVarCurrentValue3.VarValue = 0F;
            // 
            // userAlarmState2
            // 
            userAlarmState2.DeviceName = "粗洗喷淋泵过载报警";
            userAlarmState2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userAlarmState2.Location = new Point(395, 48);
            userAlarmState2.MinimumSize = new Size(1, 1);
            userAlarmState2.Name = "userAlarmState2";
            userAlarmState2.RectColor = Color.Transparent;
            userAlarmState2.Size = new Size(308, 45);
            userAlarmState2.State = true;
            userAlarmState2.TabIndex = 11;
            userAlarmState2.Text = "userAlarmState2";
            userAlarmState2.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState2.VariableName = "粗洗喷淋泵过载报警";
            // 
            // userDeviceState3
            // 
            userDeviceState3.BackColor = Color.Transparent;
            userDeviceState3.DeviceRunName = "粗洗喷淋泵运行状态";
            userDeviceState3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceState3.Location = new Point(41, 48);
            userDeviceState3.MinimumSize = new Size(1, 1);
            userDeviceState3.Name = "userDeviceState3";
            userDeviceState3.RectColor = Color.Transparent;
            userDeviceState3.Size = new Size(299, 45);
            userDeviceState3.State = true;
            userDeviceState3.TabIndex = 10;
            userDeviceState3.Text = "userDeviceState3";
            userDeviceState3.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState3.VariableName = "粗洗喷淋泵运行状态";
            // 
            // uiTitlePanel3
            // 
            uiTitlePanel3.Controls.Add(userVarCurrentValue4);
            uiTitlePanel3.Controls.Add(userVarCurrentValue5);
            uiTitlePanel3.Controls.Add(userAlarmState5);
            uiTitlePanel3.Controls.Add(userDeviceState5);
            uiTitlePanel3.Controls.Add(userAlarmState4);
            uiTitlePanel3.Controls.Add(userDeviceState4);
            uiTitlePanel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel3.Location = new Point(0, 366);
            uiTitlePanel3.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel3.MinimumSize = new Size(1, 1);
            uiTitlePanel3.Name = "uiTitlePanel3";
            uiTitlePanel3.ShowText = false;
            uiTitlePanel3.Size = new Size(1085, 181);
            uiTitlePanel3.TabIndex = 2;
            uiTitlePanel3.Text = "陶化工位";
            uiTitlePanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userVarCurrentValue4
            // 
            userVarCurrentValue4.DeviceVarName = "陶化喷淋泵压力值";
            userVarCurrentValue4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userVarCurrentValue4.Location = new Point(3, 116);
            userVarCurrentValue4.MinimumSize = new Size(1, 1);
            userVarCurrentValue4.Name = "userVarCurrentValue4";
            userVarCurrentValue4.RectColor = Color.Transparent;
            userVarCurrentValue4.Size = new Size(428, 58);
            userVarCurrentValue4.TabIndex = 2;
            userVarCurrentValue4.Text = "userVarCurrentValue4";
            userVarCurrentValue4.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue4.Unit = "Map";
            userVarCurrentValue4.VariableName = "陶化喷淋泵压力值";
            userVarCurrentValue4.VarValue = 0F;
            // 
            // userVarCurrentValue5
            // 
            userVarCurrentValue5.DeviceVarName = "陶化pH值";
            userVarCurrentValue5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userVarCurrentValue5.Location = new Point(437, 116);
            userVarCurrentValue5.MinimumSize = new Size(1, 1);
            userVarCurrentValue5.Name = "userVarCurrentValue5";
            userVarCurrentValue5.RectColor = Color.Transparent;
            userVarCurrentValue5.Size = new Size(366, 58);
            userVarCurrentValue5.TabIndex = 2;
            userVarCurrentValue5.Text = "userVarCurrentValue5";
            userVarCurrentValue5.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue5.Unit = "PH";
            userVarCurrentValue5.VariableName = "陶化pH值";
            userVarCurrentValue5.VarValue = 0F;
            // 
            // userAlarmState5
            // 
            userAlarmState5.DeviceName = "陶化低液位报警";
            userAlarmState5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userAlarmState5.Location = new Point(822, 121);
            userAlarmState5.MinimumSize = new Size(1, 1);
            userAlarmState5.Name = "userAlarmState5";
            userAlarmState5.RectColor = Color.Transparent;
            userAlarmState5.Size = new Size(258, 45);
            userAlarmState5.State = true;
            userAlarmState5.TabIndex = 4;
            userAlarmState5.Text = "userAlarmState5";
            userAlarmState5.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState5.VariableName = "陶化低液位报警";
            // 
            // userDeviceState5
            // 
            userDeviceState5.BackColor = Color.Transparent;
            userDeviceState5.DeviceRunName = "陶化排风机运行状态";
            userDeviceState5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userDeviceState5.Location = new Point(395, 53);
            userDeviceState5.MinimumSize = new Size(1, 1);
            userDeviceState5.Name = "userDeviceState5";
            userDeviceState5.RectColor = Color.Transparent;
            userDeviceState5.Size = new Size(308, 45);
            userDeviceState5.State = true;
            userDeviceState5.TabIndex = 11;
            userDeviceState5.Text = "userDeviceState5";
            userDeviceState5.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState5.VariableName = "陶化排风机运行状态";
            // 
            // userAlarmState4
            // 
            userAlarmState4.DeviceName = "陶化喷淋泵过载报警";
            userAlarmState4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            userAlarmState4.Location = new Point(781, 53);
            userAlarmState4.MinimumSize = new Size(1, 1);
            userAlarmState4.Name = "userAlarmState4";
            userAlarmState4.RectColor = Color.Transparent;
            userAlarmState4.Size = new Size(299, 45);
            userAlarmState4.State = true;
            userAlarmState4.TabIndex = 12;
            userAlarmState4.Text = "userAlarmState4";
            userAlarmState4.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState4.VariableName = "陶化喷淋泵过载报警";
            // 
            // userDeviceState4
            // 
            userDeviceState4.BackColor = Color.Transparent;
            userDeviceState4.DeviceRunName = "陶化喷淋泵运行状态";
            userDeviceState4.Font = new Font("宋体", 10F);
            userDeviceState4.Location = new Point(41, 53);
            userDeviceState4.MinimumSize = new Size(1, 1);
            userDeviceState4.Name = "userDeviceState4";
            userDeviceState4.RectColor = Color.Transparent;
            userDeviceState4.Size = new Size(299, 45);
            userDeviceState4.State = true;
            userDeviceState4.TabIndex = 10;
            userDeviceState4.Text = "userDeviceState4";
            userDeviceState4.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState4.VariableName = "陶化喷淋泵运行状态";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // PageEquipmentMonitor
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel3);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageEquipmentMonitor";
            Symbol = 57397;
            Text = "设备监控1";
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
        private UserDeviceState userDeviceState2;
        private UserAlarmState userAlarmState1;
        private UserVarCurrentValue userVarCurrentValue1;
        private UserVarCurrentValue userVarCurrentValue2;
        private UserAlarmState userAlarmState3;
        private UserAlarmState userAlarmState2;
        private UserDeviceState userDeviceState3;
        private UserAlarmState userAlarmState5;
        private UserAlarmState userAlarmState4;
        private UserDeviceState userDeviceState5;
        private UserDeviceState userDeviceState4;
        private UserVarCurrentValue userVarCurrentValue3;
        private UserVarCurrentValue userVarCurrentValue4;
        private UserVarCurrentValue userVarCurrentValue5;
        private System.Windows.Forms.Timer timer1;
    }
}