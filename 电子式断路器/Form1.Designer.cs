
namespace 电子式断路器
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.knob1 = new 电子式断路器.Knob();
            this.SuspendLayout();
            // 
            // knob1
            // 
            this.knob1.Diamter = 100;
            this.knob1.Location = new System.Drawing.Point(318, 218);
            this.knob1.Name = "knob1";
            this.knob1.ScaleNum = 10;
            this.knob1.Scales = new string[] {
        "250",
        "250",
        "250",
        "250",
        "250",
        "250",
        "250",
        "250",
        "250",
        "250"};
            this.knob1.Size = new System.Drawing.Size(130, 130);
            this.knob1.TabIndex = 0;
            this.knob1.Text = "knob1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.knob1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Knob knob1;
    }
}

