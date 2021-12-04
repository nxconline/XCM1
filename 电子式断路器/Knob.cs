using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 电子式断路器
{
    public partial class Knob : Control
    {
        public Knob()
        {
            InitializeComponent();
            this.Diamter = 100;
            this.Size = new Size(Diamter+30, Diamter+30);
            this.ScaleNum = 10;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        public int Diamter { get; set; }
        public int ScaleNum { get; set; }
        public string[] Scales { get; set; }
        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using(Pen pen = new Pen(Color.Black,2))
            {
                //绘制外圆               
                Rectangle rect = new Rectangle(15, 15, this.Diamter, this.Diamter);
                rect.Inflate(-(int)pen.Width, -(int)pen.Width);
                g.DrawEllipse(pen, rect);
                //绘制刻度
                float radius = this.Diamter / 2;
                Matrix matrix = new Matrix();
                matrix.Translate(this.Width / 2, this.Width / 2);
                g.Transform = matrix;
                for (int i = 0; i < ScaleNum; i++)
                {
                    g.DrawLine(pen, new PointF(0, radius-pen.Width), new PointF(0, radius- pen.Width-10));
                    matrix.RotateAt(360/ScaleNum, new PointF(0, 0));
                    g.Transform = matrix;
                }
                matrix.Reset();
                //绘制数字
                for (int i = 0; i < ScaleNum; i++)
                {
                    Scales = new string[] {"250", "250", "250", "250", "250", "250", "250", "250", "250", "250" };
                    float x = (float)((this.Width/2) * Math.Cos(-90 + i * 360 / ScaleNum));
                    float y = (float)((this.Width / 2) * Math.Sin(-90 + i * 360 / ScaleNum));
                    g.DrawString(this.Scales[i], this.Font, Brushes.Black, new PointF(x,y));
                }
            }

            base.OnPaint(pe);
        }
    }
}
