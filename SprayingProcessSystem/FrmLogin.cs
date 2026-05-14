using HZY.Framework.DependencyInjection;
using Sunny.UI;
using System.BLL;
using System.Helper;

namespace SprayingProcessSystem
{
    public partial class FrmLogin : UILoginForm, ISingletonSelfDependency
    {

        private readonly UserManager _userManager;

        public FrmLogin(UserManager userManager)
        {
            InitializeComponent();
            _userManager = userManager;
        }

        private async void FrmLogin_ButtonLoginClick(object sender, EventArgs e)
        {
            var res = await _userManager.LoginAsync(new UserLoginDto() { UserName = UserName, UserPassword = Password });
            if (res.Status==SystemEnums.Result.Success)
            {
                IsLogin = true;
                this.ShowSuccessTip("登录成功");
                Close();
            }
            else
            {
                this.ShowErrorTip(res.Msg);
            }
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
    }
}
