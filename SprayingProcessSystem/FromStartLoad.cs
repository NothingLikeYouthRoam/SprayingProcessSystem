using HZY.Framework.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yale.SprayProcessSCADASystem
{
    public delegate void FrmStartLoadSchedule(int num);
    public partial class FromStartLoad : Form,ISingletonSelfDependency
    {
        public FromStartLoad()
        {
            InitializeComponent();

            this.ClientSize = new System.Drawing.Size(436, 312);
            this.Name = "FromStartLoad";
            this.ResumeLayout(false);
        }
        //用于处理数据的等待弹框
        public static Form MsgTips = new Form();


        private void ThreadFunc()
        {
            if (MsgTips.IsDisposed)
            {
                MsgTips = new Form();
            }

            Label lab = new Label();//在弹框中加入文字提示
            PictureBox Pic = new PictureBox();//在弹框中加入图片


            Pic.Anchor = AnchorStyles.Left;
            Pic.Image = global::SprayingProcessSystem.Properties.Resources._waiting;
            Pic.Location = new Point(118, 36);
            Pic.Name = "pictureBox1";
            Pic.Size = new Size(125, 125);
            Pic.TabIndex = 0;
            Pic.BackColor = Color.Transparent;
            Pic.TabStop = false;
            // 
            // label1
            // 
            lab.Anchor = (((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            lab.AutoSize = true;
            lab.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            lab.Location = new Point(55, 212);
            lab.Name = "label1";
            lab.Size = new Size(286, 24);
            lab.TabIndex = 1;
            lab.Text = "窗体正在初始化数据，请稍后.....";
            lab.ForeColor = Color.Aqua;
            lab.BackColor = Color.DarkCyan;



            // 
            // Form2
            // 

            MsgTips.AutoScaleDimensions = new SizeF(8F, 15F);
            MsgTips.AutoScaleMode = AutoScaleMode.Font;
            MsgTips.ClientSize = new Size(377, 303);
            MsgTips.Controls.Add(lab);
            MsgTips.Controls.Add(Pic);

            MsgTips.FormBorderStyle = FormBorderStyle.None;
            MsgTips.Opacity = 1D;
            MsgTips.StartPosition = FormStartPosition.CenterScreen;
            MsgTips.BackColor = Color.Red;
            MsgTips.TransparencyKey = Color.Red;




            Application.Run(MsgTips);





            //MsgTips.BackColor = Color.Red;
        }

        public void OpenFormThread()
        {
            ThreadStart Thrad = new ThreadStart(ThreadFunc);//相当于指针函数，绑定了一个方法
            Thread FormThread = new Thread(Thrad);
            FormThread.IsBackground = true;
            FormThread.SetApartmentState(ApartmentState.STA);
            FormThread.Start();
            this.Enabled = false;
            this.Opacity = 0.95D;
        }


        public void CloseFormThread()
        {
            if (MsgTips.InvokeRequired)
            {
                MsgTips.Invoke(new Action(() =>
                {

                    MsgTips.Close();
                    MsgTips.Dispose();
                    this.Opacity = 1D;
                    this.Enabled = true;
                }));

            }
            else
            {
                MsgTips.Close();
                MsgTips.Dispose();
                this.Opacity = 1D;
                this.Enabled = true;
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
