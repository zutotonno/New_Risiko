using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace New_Risiko
{
    [Serializable]
    public partial class Nation_Control : UserControl
    {

        Point[] edges;
        int id;
        Boolean selected = false;
        Boolean toDraw = true;
        List<Nation_Control> near = new List<Nation_Control>();
        Image bg;
        List<PictureBox> tank_list = new List<PictureBox>();
        Form1 main_form = new Form1();
        List<Player> list_player = new List<Player>();
        Boolean drop = false;
        int phase;
        Boolean dragging = false;
        public Nation_Control(Point[] edges, int id)
        {
            this.edges = edges;
            this.id = id;
            InitializeComponent();
            this.Name = id.ToString();
        }

        public Nation_Control(int id)
        {
            this.id = id;
            phase = 0;
        }


        private void Nation_Control_Load(object sender, EventArgs e)
        {
            bg = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).ToString() + @"\texture\road.jpg");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            if (toDraw)
            {
                Rectangle r = new Rectangle(0, 0, Width, Height);
                System.Drawing.Drawing2D.GraphicsPath buttonPath =
                    new System.Drawing.Drawing2D.GraphicsPath();
                buttonPath.AddLines(edges);
                buttonPath.CloseFigure();
                this.Region = new System.Drawing.Region(buttonPath);
                this.BackgroundImage = bg;
                if (selected)
                    e.Graphics.FillRegion(Brushes.LightBlue, this.Region);
                if (drop)
                    try
                    {
                        int delta = 0;
                        foreach (PictureBox i in tank_list)
                        {
                            e.Graphics.DrawImage(i.Image, new Point(FindCentroid().X - 37 + delta, FindCentroid().Y - 28));
                            delta += 5;

                        }
                    }
                    catch (ArgumentException) { }
            }


        }
        public void setToDraw(Boolean t)
        {
            toDraw = t;
            this.Invalidate();
        }

        public int getID()
        {
            return id;
        }
        public Point[] getEdges()
        {
            return this.edges;
        }

        public Color getColor()
        {
            return Color.Blue;
        }
        public void setColor(SolidBrush color)
        {
        }
        public List<int> getNearId()
        {

            List<int> _n = new List<int>();
            foreach (Nation_Control u in near)
            {
                _n.Add(u.getID());
            }
            return _n;
        }
        public void setNear(Nation_Control u)
        {
            if (!near.Contains(u) && !this.Equals(u))
                near.Add(u);
        }
        public void clearNear()
        {
            near.Clear();
        }
        public void deleteNear(Nation_Control u)
        {
            if (u.getID() != this.getID())
                near.Remove(u);
        }
        public void clearNear(Nation_Control u)
        {
            near.Remove(u);
        }
        public List<Nation_Control> getNear()
        {
            return near;
        }
        public Boolean getSelect()
        {
            return selected;
        }
        public void setColor(Color color)
        {
            selected = !selected;
            this.Invalidate();
        }


        protected override void OnMouseDown(MouseEventArgs e)
        {

            selected = !selected;
            this.Invalidate();
        }

        public void setSelect(Boolean b)
        {
            selected = false;

        }

        public Point FindCentroid()
        {
            // Add the first point at the end of the array.
            int num_points = edges.Length;
            Point[] pts = new Point[num_points + 1];
            edges.CopyTo(pts, 0);
            pts[num_points] = edges[0];

            // Find the centroid.
            float X = 0;
            float Y = 0;
            float second_factor;
            for (int i = 0; i < num_points; i++)
            {
                second_factor =
                    pts[i].X * pts[i + 1].Y -
                    pts[i + 1].X * pts[i].Y;
                X += (pts[i].X + pts[i + 1].X) * second_factor;
                Y += (pts[i].Y + pts[i + 1].Y) * second_factor;
            }

            // Divide by 6 times the polygon's area.
            float polygon_area = PolygonArea();
            X /= (6 * polygon_area);
            Y /= (6 * polygon_area);

            // If the values are negative, the polygon is
            // oriented counterclockwise so reverse the signs.
            if (X < 0)
            {
                X = -X;
                Y = -Y;
            }

            return new Point((int)X, (int)Y);
        }

        private float SignedPolygonArea()
        {
            // Add the first point to the end.
            int num_points = edges.Length;
            Point[] pts = new Point[num_points + 1];
            edges.CopyTo(pts, 0);
            pts[num_points] = edges[0];

            // Get the areas.
            float area = 0;
            for (int i = 0; i < num_points; i++)
            {
                area +=
                    (pts[i + 1].X - pts[i].X) *
                    (pts[i + 1].Y + pts[i].Y) / 2;
            }

            // Return the result.
            return area;
        }

        public float PolygonArea()
        {
            // Return the absolute value of the signed area.
            // The signed area is negative if the polyogn is
            // oriented clockwise.
            return Math.Abs(SignedPolygonArea());
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Nation_Control p = obj as Nation_Control;
            if ((System.Object)p == null)
            {
                return false;
            }

            return (id == p.id);
        }

        private void Nation_Control_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            dragging = true;
        }

        private void Nation_Control_DragDrop(object sender, DragEventArgs e)
        {
            ((PictureBox)e.Data.GetData(typeof(PictureBox))).Parent = (Nation_Control)sender;
            PictureBox aux = ((PictureBox)e.Data.GetData(typeof(PictureBox)));
            if ((tank_list.Count==0) || aux.Tag.ToString().Equals(tank_list.First().Tag.ToString()))
            { 
                drop = true;
                tank_list.Add(aux);
                this.Invalidate();
                if (aux.Tag.ToString() == "1")
                {
                    list_player[0].decreaseNum(1,0);
                    main_form.label_tank1.Text = list_player[0].getNum().ToString();
                }
                else if (aux.Tag.ToString() == "2")
                {
                    list_player[1].decreaseNum(1,1);
                    main_form.label_tank2.Text = list_player[1].getNum().ToString();
                }
                else if (aux.Tag.ToString() == "3")
                {
                    list_player[2].decreaseNum(1,2);
                    main_form.label_tank3.Text = list_player[2].getNum().ToString();
                }
                else
                {
                    list_player[3].decreaseNum(1,3);
                    main_form.label_tank4.Text = list_player[3].getNum().ToString();
                }
            }
        }

        public void setPlayers(Form1 f,List<Player> p)
        {
            main_form = f;
            list_player = p;
        }

        public void clearTank()
        {
            tank_list.Clear();
            this.Invalidate();
        }

        public void addTank(PictureBox p)
        {
            tank_list.Add(p);
            this.Invalidate();
        }
        
        public void drawInitialTanks()
        {
            drop = true;
            this.Invalidate();
        }

        private void Nation_Control_MouseHover(object sender, EventArgs e)
        {
            int num = tank_list.Count();
            if (num > 0 )
            {
                Nation_Control n = (Nation_Control)sender;
                int visibleTime = 1000;
                ToolTip tt = new ToolTip();
                Point cx = FindCentroid();
                tt.Show(num.ToString(), n, cx.X - 10, cx.Y, visibleTime);
            }
        }
    }
}
