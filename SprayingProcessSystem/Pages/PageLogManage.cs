using Dm;
using HZY.Framework.DependencyInjection;
using MiniExcelLibs;
using Sunny.UI;
using System.Data;
using System.Diagnostics;

namespace SprayingProcessSystem.Pages
{
    public partial class PageLogManage : UIPage, ISingletonSelfDependency
    {
        public PageLogManage()
        {
            InitializeComponent();
            InitCbData();
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

        private void InitCbData()
        {
            string logPath = Path.Combine(Application.StartupPath, "Logs");
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }
            string[] dirNames = Directory.GetDirectories(logPath);
            dirNames.ForEach(x =>
            {
                uiComboBox1.Items.Add(Path.GetFileName(x));
            });
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string logPath = Path.Combine(Application.StartupPath, "logs", uiComboBox1.SelectedItem.ToString());
            string[] dirNames = Directory.GetDirectories(logPath);
            uiComboBox2.Items.Clear();
            dirNames.ForEach(x =>
            {
                uiComboBox2.Items.Add(Path.GetFileName(x));
            });
        }

        private void uiComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedIndex == null)
            {
                UIMessageTip.ShowWarning("请先选择日期");
                return;
            }
            if (uiComboBox2.SelectedIndex == null)
            {
                UIMessageTip.ShowWarning("请先选择级别");
                return;
            }
            string logPath = Path.Combine(Application.StartupPath, "logs", uiComboBox1.SelectedItem.ToString(), uiComboBox2.SelectedItem.ToString());
            uiListBox1.Items.Clear();
            string[] fileName = Directory.GetFiles(logPath, "*.log");
            fileName.OrderBy(s => s).ToList().ForEach(s =>
            {
                uiListBox1.Items.Add(Path.GetFileName(s));
            });
        }

        private async void uiListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedIndex == null)
            {
                UIMessageTip.ShowWarning("请先选择日期");
                return;
            }
            if (uiComboBox2.SelectedIndex == null)
            {
                UIMessageTip.ShowWarning("请先选择级别");
                return;
            }
            if (uiListBox1.SelectedItem == null)
            {
                UIMessageTip.ShowWarning("请先选择日志文件");
                return;
            }
            try
            {
                string logPath = Path.Combine(Application.StartupPath, "Logs", uiComboBox1.SelectedItem.ToString(), uiComboBox2.SelectedItem.ToString(), uiListBox1.SelectedItem.ToString());
                string content = string.Empty;
                uiTextBox1.Text = "";
                using (StreamReader sr = new StreamReader(logPath))
                {
                    content = await sr.ReadToEndAsync();
                }
                uiTextBox1.Text = content;
            }
            catch (Exception ex)
            {

                LogExtension.ShowMessage(ex.Message, Microsoft.Extensions.Logging.LogLevel.Error);
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string logPath = Path.Combine(Application.StartupPath, "Logs");
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = logPath,
                UseShellExecute = true
            };
            Process process = new Process
            {
                StartInfo = startInfo
            };
            process.Start();
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            if (uiTextBox1.Text.Length == 0)
            {
                UIMessageTip.ShowWarning("请先选择日志文件");
                return;
            }
            string[] lines = uiTextBox1.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            DataTable dt = new DataTable();
            dt.Columns.Add("时间");
            dt.Columns.Add("日志等级");
            dt.Columns.Add("日志来源");
            dt.Columns.Add("日志内容");
            lines.ToList().ForEach(x =>
            {
                String[] items = x.Split(new string[] { "|" }, StringSplitOptions.None);
                if (items.Length == 4)
                {
                    DataRow dr = dt.NewRow();
                    dr["时间"] = items[0];
                    dr["日志等级"] = items[1];
                    dr["日志来源"] = items[2];
                    dr["日志内容"] = items[3];
                    dt.Rows.Add(dr);
                }
            });
            uiDataGridView1.DataSource = dt;
        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            if (uiTextBox1.Text.Length == 0)
            {
                UIMessageTip.ShowWarning("请先选择日志文件");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "文本文件|*.txt";
            sfd.InitialDirectory = Application.StartupPath;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.Write(uiTextBox1.Text);
                    }
                    LogExtension.ShowMessage("日志导出成功", Microsoft.Extensions.Logging.LogLevel.Information);
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = sfd.FileName,
                        UseShellExecute = true
                    };
                    Process process = new Process
                    {
                        StartInfo = startInfo
                    };
                    process.Start();
                }
                catch (Exception ex)
                {

                    UIMessageTip.ShowError(ex.Message);
                    LogExtension.ShowMessage(ex.Message, Microsoft.Extensions.Logging.LogLevel.Information);
                }
            }
        }

        private async void uiSymbolButton4_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.DataSource == null)
            {
                UIMessageTip.ShowWarning("请先显示表格");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel文件|*.xlsx";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dt = uiDataGridView1.DataSource as DataTable;
                    await MiniExcel.SaveAsAsync(sfd.FileName, dt);
                    LogExtension.ShowMessage("日志导出成功", Microsoft.Extensions.Logging.LogLevel.Information);
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = sfd.FileName,
                        UseShellExecute = true
                    };

                    Process process = new Process
                    {
                        StartInfo = startInfo
                    };
                    process.Start();
                }
                catch (Exception ex)
                {
                    UIMessageTip.ShowError(ex.Message);
                    LogExtension.ShowMessage(ex.Message, Microsoft.Extensions.Logging.LogLevel.Error);
                }

            }
        }
    }
}
