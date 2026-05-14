using HZY.Framework.DependencyInjection;
using MiniExcelLibs;
using Sunny.UI;
using System.BLL;
using System.BLL.Manager;
using System.Helper;

namespace SprayingProcessSystem.Pages
{
    public partial class PageReportManage : UIPage, ISingletonSelfDependency
    {

        private readonly DataManager _dataManager;

        private BaseResult<QueryDataResultDto> res;

        public PageReportManage(DataManager dataManager)
        {
            _dataManager = dataManager;
            InitializeComponent();
            uiDatetimePicker1.Value = DateTime.Now.AddDays(-1);
            uiDatetimePicker2.Value = DateTime.Now;
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

        private async void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            DateTime t1 = uiDatetimePicker1.Value;
            DateTime t2 = uiDatetimePicker2.Value;
            if (t1 > t2)
            {
                UIMessageTip.ShowWarning("开始时间不可以大于结束时间！");
                return;
            }
            QueryDataDto queryDataDto = new QueryDataDto() { StartTime = t1, EndTime = t2 };
            res = await _dataManager.GetDataListByTimeAsync(queryDataDto);
            if (res.Status == SystemEnums.Result.Success)
            {
                // 设置分页总数
                uiPagination1.TotalCount = res.Data.Count;
                // 设置每页的数量
                uiPagination1.PageSize = 15;
                uiPagination1.ActivePage = 1;
            }
        }

        private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            var data = res.Data.Skip(pageIndex * count).Take(count).ToList();
            uiDataGridView1.DataSource = null;
            uiDataGridView1.DataSource = data;
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel 文件(*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = saveFileDialog.FileName;
                    var rows = uiDataGridView1.DataSource as List<QueryDataResultDto>;
                    MiniExcel.SaveAs(filePath, rows);
                    UIMessageTip.ShowError("导出成功！");

                }
                catch (Exception ex)
                {

                    UIMessageTip.ShowError("导出失败：" + ex.Message);
                    LogExtension.ShowMessage("导出失败：" + ex.Message, Microsoft.Extensions.Logging.LogLevel.Error);
                }
            }
        }
    }
}
