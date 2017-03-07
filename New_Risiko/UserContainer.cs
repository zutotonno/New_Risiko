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
    public partial class UserContainer : UserControl
    {
        Matrix wv = new Matrix();
        float velocity = 0;
        float gravity, h_max;
        Point start, end;
        Boolean init = false;
        System.DateTime time_now, time_before;
        double time_end;
        float delta_time, delta_space;
        Timer timer = new Timer();
        float count, time_acc;
        float sec, position;
        float energia_potenziale;
        //PictureBox dado = new PictureBox();
        //Image[] dice_index = new Image[6];
        //dado_box dado = new dado_box();
        Point dado_loc;
        Image actual_image;
        public UserContainer()
        {
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
            timer.Tick += new EventHandler(timer_Tick);
            sec = 0.025f; //0.01f;
            timer.Interval = (int)(sec * 1000f);
            gravity = 9.81f * 40f;

            InitializeComponent();
            dado_box1.Enabled = false;
            dado_box1.Invalidate();
            dado_box1.Location = new Point(13, this.Height-dado_box1.Height);
            System.Console.WriteLine("container: " + this.Location + " dado_box:" + dado_box1.Location);
        }
        private void UserContainer_MouseDown(object sender, MouseEventArgs e)
        {
            if (!init)
            {


                Boolean isINX = (e.X < dado_box1.Location.X + dado_box1.Width) && (e.X > dado_box1.Location.X);
                Boolean isINY = (e.Y > dado_box1.Location.Y) && (e.Y < dado_box1.Location.Y + dado_box1.Height);
                if (isINX && isINY)
                {
                    init = true;
                    start = e.Location;
                    timer.Stop();
                    time_before = DateTime.Now;
                    dado_loc = dado_box1.Location;
                    count = 0;
                    float h = Math.Abs(dado_box1.Location.Y - this.Height);
                    energia_potenziale = (float)Math.Sqrt((double)(2f * gravity * h));
                    //Console.WriteLine("Energia potenziale: " + energia_potenziale + " h: "+h);
                }
            }
        }

        private void dado_container_Paint(object sender, PaintEventArgs e)
        {
            /*Graphics g = e.Graphics;
            //dado.Invalidate();
            //g.Transform = wv;
            //g.DrawImage(dado.Image, dado.Location);
            Pen p = new Pen(Color.White);
            p.Width = 5f;
            p.EndCap = LineCap.ArrowAnchor;
            g.DrawLine(p, new Point(this.Width/2,this.Height/2),new Point(this.Width / 2 +40, this.Height/2));
            g.DrawLine(p, new Point(this.Width / 2, this.Height / 2), new Point(this.Width / 2, this.Height / 2 - 40));*/

        }

        private void UserContainer_MouseUp(object sender, MouseEventArgs e)
        {
            if (init)
            {
                end = e.Location;
                time_now = DateTime.Now;
                time_end = time_now.Subtract(time_before).TotalMilliseconds;
                delta_time = (float)(time_end) / 1000f;
                delta_space = (Math.Abs((end.Y - start.Y)));
                velocity = (delta_space / delta_time) / 3f;//    px/s
                h_max = (0.5f * (velocity * velocity)) / gravity;
                //if (delta_space > 10)
                velocity = velocity + energia_potenziale; // velocità iniziale + velocità finale
                //else velocity = energia_potenziale/2f;
                //velocity = energia_potenziale/3f;
                float t_max = velocity / gravity;
                count = 0;
                time_acc = 0;
                timer.Start();
                dado_box1.timer_start();
                init = false;
            }
        }




        private void timer_Tick(object sender, EventArgs e)
        {
            count += 2;
            this.Invalidate();
            time_acc = sec * count;
            position = dado_loc.Y - (velocity * time_acc) + 0.5f * (gravity * time_acc * time_acc);
            dado_box1.Location = new Point(dado_box1.Location.X, (int)(position));
            if (dado_box1.Location.Y + dado_box1.Height <= this.Height)
            {

                //if (count % 10 == 0)
                //{
                //wv.RotateAt(20f, new Point(this.Width / 2, this.Height / 2));
                // Random j = new Random();
                //int i = j.Next(0, 6);
                //dado.Image = dice_index[i];
                //wv.Translate(-this.Width, -this.Height);
                //wv.RotateAt(5f, new Point(this.Width/2,this.Height/2));
                //Graphics g = this.CreateGraphics();
                //g.RotateTransform(45f);
                //dice_result = i;

                //}
                //System.Console.WriteLine("dado_position: " + dado.Location.Y + " dado_loc: " +dado_loc.Y);
            }
            else
            {
                if (velocity > 10)
                {
                    velocity = velocity / 2.25f;
                    dado_loc = new Point(dado_box1.Location.X, this.Height - dado_box1.Height);
                    count = 0;
                }
                else
                {
                    System.Console.WriteLine("Finito :" + dado_box1.Location.Y);
                    timer.Stop();
                    dado_box1.timer_stop();
                    //MessageBox.Show("E' uscito: " + (dice_result + 1));
                }
            }
        }

        public void setDice(Boolean v)
        {
            this.Invalidate();
            dado_box1.Visible = v;
        }
    }
}
