using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace New_Risiko
{
    public partial class dado_box : UserControl
    {
        PictureBox dado = new PictureBox();
        Matrix wv = new Matrix();

        Timer timer = new Timer();
        float sec;
        Image[] dice_index = new Image[6];
        Image actual_image;
        Point centre;
        Boolean dir=true;
        public dado_box()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            timer.Tick += new EventHandler(timer_Tick);
            sec = 0.030f; //0.01f;
            timer.Interval = (int)(sec * 1000f);
            centre = new Point(this.Width / 2, this.Height / 2);
            for (int i = 0; i < 6; i++)
            {
                if(dir)
                    dice_index[i] = Image.FromFile("../img/dadi_rossi/" + i + ".png");
                else
                    dice_index[i] = Image.FromFile("../img/dadi_blu/" + i + ".png");

            }
            actual_image = dice_index[0];
            dado.Size = new Size(64, 64);
            dado.Image = actual_image;
            dado.Visible = true;
            dado.Location = new Point(5, 5);
            this.Invalidate();
            System.Console.WriteLine("position: " + this.Location);
        }
        public void timer_start()
        {
            timer.Start();
        }
        public void timer_stop()
        {
            timer.Stop();
            wv.Reset();
            wv.Translate(0, 12);
            this.Invalidate();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Random j = new Random();
            int i = j.Next(0, 6);
            dado.Image = dice_index[i];
            wv.RotateAt(20f, centre);
            this.Invalidate();
        }

        public void setDir(Boolean b)
        {
            dir = b;
        
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Transform = wv;

            g.DrawImage(dado.Image, new Point(6, 9));
        }
    }
}
