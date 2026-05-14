using HZY.Framework.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using Sunny.UI;
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace SprayingProcessSystem.Pages
{
    public partial class PageTotalEquipmentControl : UIPage, ISingletonSelfDependency
    {

        private readonly ILogger<PageTotalEquipmentControl> _logger;

        public PageTotalEquipmentControl(ILogger<PageTotalEquipmentControl> logger)
        {
            _logger = logger;
            LogExtension.ShowMessage = ShowLog;
            InitializeComponent();
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

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (!Globals.SiemensClient.Connected)
            {
                UIMessageTip.ShowError("请先连接西门子PLC");
                return;
            }
            UISymbolButton btn = sender as UISymbolButton;
            if (Globals.PlcWrite(btn.TagString, true))
            {
                UIMessageTip.ShowOk("写入成功");
                ShowLog($"写入{btn.TagString}成功");
            }
            else
            {
                UIMessageTip.ShowError($"写入{btn.TagString}失败");
                ShowLog($"写入{btn.TagString}失败");
            }
        }

        private void userCounterButton1_Click(object sender, EventArgs e)
        {
            if (!Globals.SiemensClient.Connected)
            {
                UIMessageTip.ShowError("请先连接西门子PLC");
                return;
            }
            if (Globals.PlcWrite(userCounterButton1.VariableName, !userCounterButton1.CounterButtonState))
            {
                userCounterButton1.CounterButtonState = !userCounterButton1.CounterButtonState;
                UIMessageTip.ShowOk("写入成功");
                ShowLog($"写入{userCounterButton1.VariableName}成功");
            }
            else
            {
                UIMessageTip.ShowError("写入失败");
                ShowLog($"写入{userCounterButton1.VariableName}失败");
            }
        }

        private void userDeviceUnitControl1_Click(object sender, EventArgs e)
        {
            UserDeviceUnitControl userDeviceUnitControl = sender as UserDeviceUnitControl;
            if (!Globals.SiemensClient.Connected)
            {
                userDeviceUnitControl.State = false;
                UIMessageTip.ShowError("请先连接西门子PLC");
                return;
            }
            bool state = userDeviceUnitControl.State;
            string varName = state ? userDeviceUnitControl.CloseVariableName : userDeviceUnitControl.OpenVariableName;
            if (Globals.PlcWrite(varName, state))
            {
                UIMessageTip.ShowOk("写入成功");
                ShowLog($"写入{varName}成功");
            }
            else
            {
                UIMessageTip.ShowError("写入失败");
                ShowLog($"写入{varName}成功");
            }
        }

        private void ShowLog(string log, LogLevel logLevel=LogLevel.Information)
        {
            uiTextBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "=>" + log + Environment.NewLine);
            switch (logLevel)
            {
                case LogLevel.Information:
                    _logger.LogInformation(log);
                    break;
                case LogLevel.Warning:
                    _logger.LogWarning(log);
                    break;
                case LogLevel.Error:
                    _logger.LogError(log);
                    break;
            }
        }
    }
}
