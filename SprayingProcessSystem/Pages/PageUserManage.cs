using HZY.Framework.DependencyInjection;
using Sunny.UI;
using System.BLL;
using System.Helper;

namespace SprayingProcessSystem.Pages
{
    public partial class UserManage : UIPage, ISingletonSelfDependency
    {

        private readonly UserManager _userManager;

        public UserManage(UserManager userManager)
        {
            _userManager = userManager;
            InitializeComponent();
            uiComboBox1.SelectedIndex = -1;
            Load += PageUserManager_Load;
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

        private async void PageUserManager_Load(object? sender, EventArgs e)
        {
            await LoadData();
        }

        private async void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (!VaildInput())
            {
                return;
            }
            UserAddDto userAddDto = new UserAddDto()
            {
                UserName = uiTextBox1.Text,
                UserPassword = uiTextBox2.Text,
                Role = uiComboBox1.SelectedItem.ToString()
            };

            var result = await _userManager.AddUserAsync(userAddDto);
            if (result.Status == SystemEnums.Result.Success)
            {
                UIMessageTip.Show("添加成功！");
                LogExtension.ShowMessage("添加用户成功", Microsoft.Extensions.Logging.LogLevel.Information);
                await LoadData();
            }
            else
            {
                UIMessageTip.ShowError(result.Msg);
            }
        }

        private async Task LoadData()
        {
            var res = await _userManager.GetUserListAsync();
            if (res.Status == SystemEnums.Result.Success)
            {
                uiDataGridView1.DataSource = res.Data;
                uiDataGridView1.Refresh();
            }
            
        }

        private bool VaildInput()
        {
            if (uiTextBox1.Text.IsNullOrEmpty())
            {
                UIMessageTip.ShowWarning("用户名不能为空！");
                return false;
            }
            if (uiTextBox2.Text.IsNullOrEmpty())
            {
                UIMessageTip.ShowWarning("密码不能为空！");
                return false;
            }
            if (uiTextBox3.Text.IsNullOrEmpty())
            {
                UIMessageTip.ShowWarning("请确认密码！");
                return false;
            }
            if (uiTextBox3.Text != uiTextBox2.Text)
            {
                UIMessageTip.ShowWarning("两次输入密码不一致！");
                return false;
            }
            if (uiComboBox1.SelectedIndex == -1)
            {
                UIMessageTip.ShowWarning("请选择用户权限！");
                return false;
            }
            return true;
        }

        private async void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            if (!VaildInput())
            {
                return;
            }
            var userUpdateDto = new UserUpdateDto()
            {
                Id = int.Parse(uiDataGridView1.CurrentRow.Cells["Id"].Value.ToString()),
                UserName = uiTextBox1.Text,
                UserPassword = uiTextBox2.Text,
                Role = uiComboBox1.SelectedItem.ToString()
            };
            var result = await _userManager.UpdateUserAsync(userUpdateDto);
            if (result.Status==SystemEnums.Result.Success)
            {
                UIMessageTip.ShowOk("修改成功！");
                LogExtension.ShowMessage("修改用户成功！", Microsoft.Extensions.Logging.LogLevel.Information);
                await LoadData();
            }
            else
            {
                UIMessageTip.ShowWarning(result.Msg);
                LogExtension.ShowMessage(result.Msg, Microsoft.Extensions.Logging.LogLevel.Information);
            }
        }

        private async void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            if (this.uiDataGridView1.CurrentRow == null)
            {
                UIMessageTip.ShowWarning("请先选择一行");
                return;
            }
            UserDeleteDto userDeleteDto = new UserDeleteDto()
            {
                Id = int.Parse(uiDataGridView1.CurrentRow.Cells["Id"].Value.ToString())
            };
            var result = await _userManager.DeleteUserAsync(userDeleteDto);
            if (result.Status == SystemEnums.Result.Success)
            {
                UIMessageTip.ShowOk("删除成功！");
                LogExtension.ShowMessage("删除用户成功！", Microsoft.Extensions.Logging.LogLevel.Information);
                await LoadData();
            }
            else
            {
                UIMessageTip.ShowWarning(result.Msg);
                LogExtension.ShowMessage(result.Msg, Microsoft.Extensions.Logging.LogLevel.Information);
            }
        }

        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            var row = uiDataGridView1.Rows[index];
            uiTextBox1.Text = row.Cells["User"].Value.ToString();
            uiTextBox2.Text = row.Cells["password"].Value.ToString();
            uiTextBox3.Text = uiTextBox2.Text;
            uiComboBox1.SelectedItem = row.Cells["role"].Value.ToString();
        }
    }
}
