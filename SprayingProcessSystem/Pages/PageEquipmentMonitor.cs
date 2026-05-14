using HZY.Framework.DependencyInjection;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SprayingProcessSystem.Pages
{
    public partial class PageEquipmentMonitor : UIPage, ISingletonSelfDependency
    {

        private List<Control> controls;

        public PageEquipmentMonitor()
        {
            InitializeComponent();
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            controls = Globals.GetAllControls(this);
            timer1.Start();
        }

        #region 窗体卡顿处理
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Globals.SiemensClient.Connected)
            {
                foreach (Control control in controls)
                {
                    if (control is UserDeviceState userDeviceState)
                    {
                        userDeviceState.State = Globals.DataDic[userDeviceState.VariableName].ToString() == "1";
                    }
                    else if (control is UserVarCurrentValue userVarCurrentValue)
                    {
                        userVarCurrentValue.VarValue = float.Parse(Globals.DataDic[userVarCurrentValue.VariableName].ToString());
                    }
                    else if (control is UserAlarmState userAlarmState)
                    {
                        userAlarmState.State = Globals.DataDic[userAlarmState.VariableName].ToString() != "1";
                    }
                }
            }
        }
    }
}
