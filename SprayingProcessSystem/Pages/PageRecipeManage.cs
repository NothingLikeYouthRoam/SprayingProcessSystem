using Castle.Components.DictionaryAdapter.Xml;
using HZY.Framework.DependencyInjection;
using Mapster;
using MiniExcelLibs;
using Sunny.UI;
using System.BLL;
using System.BLL.Manager;
using System.Helper;

namespace SprayingProcessSystem.Pages
{
    public partial class PageRecipeManage : UIPage, ISingletonSelfDependency
    {

        private readonly RecipeManager _recipeManager;

        public PageRecipeManage(RecipeManager recipeManager)
        {
            InitializeComponent();
            _recipeManager = recipeManager;
            Load += PageRecipeManager_Load;
            uiDataGridView1.AutoGenerateColumns = false;
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

        private async void PageRecipeManager_Load(object? sender, EventArgs e)
        {
            await LoadRecipe();
        }

        private async Task LoadRecipe()
        {
            var res = await _recipeManager.GetRecipeListAsync();
            if (res.Status == SystemEnums.Result.Success)
            {
                uiDataGridView1.DataSource = res.Data;
            }
            else
            {
                LogExtension.ShowMessage("获取配方列表失败", Microsoft.Extensions.Logging.LogLevel.Information);
            }
        }

        private async void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (uiTextBox15.Text.IsNullOrEmpty())
            {
                UIMessageTip.ShowWarning("请输入产品类型");
                return;
            }
            AddRecipeDto addRecipeDto = new AddRecipeDto()
            {
                产品类型 = uiTextBox15.Text
            };
            foreach (var item in uiTitlePanel1.Controls)
            {
                if (item is UserSetValue usv)
                {
                    addRecipeDto.GetType().GetProperty(usv.VariableName).SetValue(addRecipeDto, usv.VarValue);
                }
            }
            var result = await _recipeManager.AddRecipeAsync(addRecipeDto);
            if (result.Status == SystemEnums.Result.Success)
            {
                UIMessageTip.ShowOk("添加配方成功");
                await LoadRecipe();
            }
            else
            {
                UIMessageTip.ShowWarning(result.Msg);
                LogExtension.ShowMessage(result.Msg, Microsoft.Extensions.Logging.LogLevel.Information);
            }
        }

        private async void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.CurrentRow == null)
            {
                UIMessageTip.ShowWarning("请选择一行！");
                return;
            }
            var id = uiDataGridView1.CurrentRow.Cells["Id"].Value.ToString().ToInt();
            var result = await _recipeManager.DeleteRecipeAsync(new DelRecipeDto() { Id = id });
            if (result.Status == SystemEnums.Result.Success)
            {
                UIMessageTip.ShowOk("删除配方成功");
                await LoadRecipe();
            }
            else
            {
                UIMessageTip.ShowWarning(result.Msg);
                LogExtension.ShowMessage(result.Msg, Microsoft.Extensions.Logging.LogLevel.Information);
            }
        }

        private async void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            var id = uiDataGridView1.Rows[index].Cells["Id"].Value.ToString().ToInt();
            var result = await _recipeManager.GetRecipeAsyncById(new GetRecipeByIdDto() { Id = id });
            if (result.Status == SystemEnums.Result.Success)
            {
                foreach (var item in uiTitlePanel1.Controls)
                {
                    if (item is UserSetValue usv)
                    {
                        usv.VarValue = result.Data[0].GetType().GetProperty(usv.VariableName).GetValue(result.Data[0]).ToString();
                    }
                }
                uiTextBox15.Text = result.Data[0].产品类型;
            }
        }

        private async void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.CurrentRow == null)
            {
                UIMessageTip.ShowWarning("请选择一行数据!");
                return;
            }
            UpdateRecipeDto updateRecipeDto = new UpdateRecipeDto();
            updateRecipeDto.Id = uiDataGridView1.CurrentRow.Cells["Id"].Value.ToString().ToInt();
            updateRecipeDto.产品类型 = uiTextBox15.Text;
            foreach (var item in uiTitlePanel1.Controls)
            {
                if (item is UserSetValue usv)
                {
                    updateRecipeDto.GetType().GetProperty(usv.VariableName).SetValue(updateRecipeDto, usv.VarValue);
                }
            }
            var result = await _recipeManager.UpdateRecipeAsync(updateRecipeDto);
            if (result.Status == SystemEnums.Result.Success)
            {
                UIMessageTip.ShowOk("修改配方成功");
                await LoadRecipe();
            }
            else
            {
                UIMessageTip.ShowWarning(result.Msg);
                LogExtension.ShowMessage(result.Msg, Microsoft.Extensions.Logging.LogLevel.Information);
            }
        }

        private async void uiSymbolButton4_Click(object sender, EventArgs e)
        {
            await LoadRecipe();
        }

        private void uiSymbolButton6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files(*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var rows = uiDataGridView1.DataSource as List<QueryRecipeResultDto>;
                    var filePath = saveFileDialog.FileName;
                    MiniExcel.SaveAs(filePath, rows);
                    UIMessageTip.ShowOk("导出成功!");
                }
                catch (Exception ex)
                {
                    UIMessageTip.ShowError("导出失败!");
                    LogExtension.ShowMessage(ex.Message, Microsoft.Extensions.Logging.LogLevel.Information);
                }
            }
        }

        private async void uiSymbolButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel files(*.xlsx)|*.xlsx";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = fileDialog.FileName;
                    var rows = MiniExcel.Query<QueryRecipeResultDto>(filePath).ToList();
                    var res = await _recipeManager.GetRecipeListAsync();
                    if (res.Status == SystemEnums.Result.Success)
                    {
                        var dbRows = res.Data;
                        foreach (var row in rows)
                        {
                            var dbRow = dbRows.FirstOrDefault(x => x.产品类型 == row.产品类型);
                            if (dbRow != null)
                            {
                                var updateDto = row.Adapt<UpdateRecipeDto>();
                                updateDto.Id = dbRow.Id;
                                var res1 = await _recipeManager.UpdateRecipeAsync(updateDto);
                                if (res1.Status != SystemEnums.Result.Success)
                                {
                                    UIMessageTip.ShowError("导入失败：" + res1.Msg);
                                    return;
                                }
                            }
                            else
                            {
                                var addDto = row.Adapt<AddRecipeDto>();
                                var res1 = await _recipeManager.AddRecipeAsync(addDto);
                                if (res1.Status != SystemEnums.Result.Success)
                                {
                                    UIMessageTip.ShowError("导入失败：" + res1.Msg);
                                    return;
                                }
                            }
                        }
                        UIMessageTip.ShowOk("导入成功！");
                        await LoadRecipe();
                    }
                    else
                    {
                        UIMessageTip.ShowError("导入失败:" + res.Msg);
                    }
                }
                catch (Exception)
                {
                    UIMessageTip.ShowError("导入失败");
                }
            }
        }

        private void uiSymbolButton7_Click(object sender, EventArgs e)
        {
            if (!Globals.SiemensClient.Connected)
            {
                UIMessageTip.ShowWarning("请先连接西门子客户端");
                return;
            }
            var res = UIMessageBox.ShowAsk("是否要下载到PLC？");
            if (res)
            {
                foreach(var item in uiTitlePanel1.Controls)
                {
                    if (item is UserSetValue usv)
                    {
                        if (usv.VarValue == string.Empty)
                        {
                            usv.VarValue = "0";
                        }
                        if (!Globals.PlcWrite(usv.VariableName,usv.VarValue, IoTClient.Enums.DataTypeEnum.Float))
                        {
                            new UIMessageForm().ShowErrorDialog($"{usv.VariableName}下载失败！");
                            return;
                        }
                    }
                }
                UIMessageTip.ShowOk("下载成功");
            }
        }
    }
}
