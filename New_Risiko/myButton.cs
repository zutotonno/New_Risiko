using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Risiko
{
    public partial class myButton : UserControl
    {
        Pen p = new Pen(Color.Black);
        Boolean over = false;
        Rectangle r;
        public myButton()
        {
            InitializeComponent();
            p.Width = 3;
            r= new Rectangle(1, 1, Width - 5, Height - 5);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            base.OnPaint(e);
            Graphics g = e.Graphics;
            System.Drawing.Drawing2D.GraphicsPath buttonPath =
                new System.Drawing.Drawing2D.GraphicsPath();
            buttonPath.AddEllipse(r);
            e.Graphics.DrawEllipse(p, r);
        }
    }
}
