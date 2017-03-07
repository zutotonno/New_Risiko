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

namespace New_Risiko
{
    public partial class LabelContainer : UserControl
    {
        Matrix wv = new Matrix();
        Timer timer = new Timer();
        Boolean end = false;
        Point centre;
        int duration;
        public LabelContainer()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 3;
            duration = 0;
        }

        public void timer_start()
        {
            end = false;
            duration = 0;
            wv.Reset();
            centre = new Point(this.Width / 2, this.Height / 2);
            this.Invalidate();
            timer.Start();
        }
        private void timer_stop()
        {
            timer.Stop();
            end = true;
            this.Invalidate();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            duration+=3;
            if (duration < 242)
            {
                wv.RotateAt(20f, centre);
                wv.Scale(0.98f, 0.98f);
                this.Invalidate();
            }
            else
            {
                timer_stop();
                this.Visible = false;
                //this.Dispose();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Transform = wv;
            if (!end)
            {
                g.Transform = wv;
                g.DrawString("Game Starting", label1.Font, Brushes.Black, label1.Location);
            }
        }

        private void LabelContainer_Load(object sender, EventArgs e)
        {

        }
    }
}
