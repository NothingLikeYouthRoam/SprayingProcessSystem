namespace SprayingProcessSystem
{
    partial class UserCounterButton
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            btn_Counter = new Sunny.UI.UISymbolButton();
            SuspendLayout();
            // 
            // btn_Counter
            // 
            btn_Counter.Dock = DockStyle.Fill;
            btn_Counter.Font = new Font("微软雅黑", 14F);
            btn_Counter.Location = new Point(0, 0);
            btn_Counter.MinimumSize = new Size(1, 1);
            btn_Counter.Name = "btn_Counter";
            btn_Counter.Size = new Size(181, 84);
            btn_Counter.Symbol = 558653;
            btn_Counter.SymbolSize = 55;
            btn_Counter.TabIndex = 0;
            btn_Counter.Text = "11";
            btn_Counter.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_Counter.Click += UserCounterButton_Click;
            // 
            // UserCounterButton
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Transparent;
            Controls.Add(btn_Counter);
            FillColor = Color.Transparent;
            Name = "UserCounterButton";
            RectColor = Color.Transparent;
            Size = new Size(181, 84);
            Click += UserCounterButton_Click;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UISymbolButton btn_Counter;
    }
}
