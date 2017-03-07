using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Risiko
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        Boolean on = false;
        Stack stack = new Stack();
        Game game = new Game();
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Size form_size;
        Size panel_left_size;
        Size group_box_number_size;
        Size button_gioca_size;
        Size panel_bottom_size;
        Point panel_left_location;
        Point group_box_number_location;
        Point panel_bottom_location;
        Point button_gioca_location;
        Point button_editor_location;
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer myTimer_Gioca = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer myTimer_Editor = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer myTimer_Number = new System.Windows.Forms.Timer();
        List<List<Point>> continent = new List<List<Point>>();
        List<Point> nation = new List<Point>();
        List<Nation_Control> listControl = new List<Nation_Control>();
        List<Nation> listNation = new List<Nation>();
        LabelContainer labelContainer1 = new LabelContainer();
        int id = 0;
        Boolean isDrawing = false;
        Boolean inEditor = false;
        Boolean inGame = false;
        Boolean game_started = false;
        //int game_phase = 0; // 0 posizionamento,1 attacco, 2 sposamento
        int turn_player;
        String pos = "Posizionamento";
        String atk = "Attacco";
        String mov = "Spostamento";
        public List<Player> players = new List<Player>();
        List<Boolean> finish = new List<Boolean>();
        int phase=0;
        public Form1()
        {
            InitializeComponent();
            panel_left_size = new Size(panel_left.Size.Width, panel_left.Size.Height);
            panel_left_location = panel_left.Location;
            button_gioca_size = new Size(button_gioca.Size.Width, button_gioca.Size.Height);
            button_gioca_location = button_gioca.Location;
            button_editor_location = button_editor.Location;
            panel_bottom_location = panel_bottom.Location;
            group_box_number_size = groupBox_number.Size;
            group_box_number_location = groupBox_number.Location;
            labelContainer1.Location = new Point(50, 31);
            labelContainer1.Visible = false;
            Controls.Add(labelContainer1);
            myTimer.Tick += new EventHandler(_change);
            myTimer.Interval = 2;
            myTimer_Gioca.Tick += new EventHandler(_change_Gioca);
            myTimer_Gioca.Interval = 1;
            myTimer_Editor.Tick += new EventHandler(_change_Editor);
            myTimer_Editor.Interval = 1;
            myTimer_Number.Tick += new EventHandler(_change_Number);
            myTimer_Number.Interval = 1;
            pictureBox1.Name = "black";
            pictureBox2.Name = "red";
            pictureBox3.Name = "green";
            pictureBox4.Name = "blue";
            form_size = new Size(1000, 600);
            panel_bottom_size = new Size(1000, 35);
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            form_size = new Size(1000, 600);
            panel_bottom_size = new Size(1000, 35);
        }


        private void _change_Number(object sender, EventArgs e)
        {
            if (groupBox_number.Size.Height > 5)
            {
                groupBox_number.Size = new Size(groupBox_number.Width - 5, groupBox_number.Height - 5);
                if (groupBox_number.Height % 2 == 0)
                {
                    groupBox_number.Location = new Point(groupBox_number.Location.X + 5, groupBox_number.Location.Y + 5);
                }
            }
            else
            {
                myTimer_Number.Stop();
                String t;
                groupBox_number.Visible = false;
                groupBox_number.Enabled = false;
                if (radioButton2.Checked)
                    t = radioButton2.Text;
                else if (radioButton3.Checked)
                    t = radioButton3.Text;
                else
                    t = radioButton4.Text;
                label_number.Text = t;
                label_number.Visible = true;
            }
        }


        private void _change_Editor(object sender, EventArgs e)
        {
            if (button_editor.Size.Height > 3)
            {
                button_gioca.Size = new Size(button_gioca.Width - 2, button_gioca.Size.Height - 1);
                button_editor.Size = new Size(button_editor.Width - 2, button_editor.Size.Height - 1);
                if (button_gioca.Height % 2 == 0)
                {
                    button_gioca.Location = new Point(button_gioca.Location.X + 2, button_gioca.Location.Y + 1);
                    button_editor.Location = new Point(button_editor.Location.X + 2, button_editor.Location.Y + 1);
                }
            }
            else
            {
                myTimer_Editor.Stop();
                button_gioca.Visible = false;
                button_editor.Visible = false;
                System.Console.WriteLine(button_editor.Size.ToString());
            }
        }

        private void _change_Gioca(object sender, EventArgs e)
        {
            if (button_gioca.Size.Height > 3)
            {
           
                button_gioca.Size = new Size(button_gioca.Width - 2, button_gioca.Size.Height - 1);
                button_editor.Size = new Size(button_editor.Width - 2, button_editor.Size.Height - 1);
                if (button_gioca.Height % 2 == 0)
                {
                    button_gioca.Location = new Point(button_gioca.Location.X + 2, button_gioca.Location.Y + 1);
                    button_editor.Location = new Point(button_editor.Location.X + 2, button_editor.Location.Y + 1);
                }
            }
            else
            {
                myTimer_Gioca.Stop();
                button_gioca.Visible = false;
                button_editor.Visible = false;

            }
        }

        private void _change(object sender, EventArgs e)
        {
            if (panel_left.Size.Width>3) {
                panel_left.Size = new Size(panel_left.Size.Width-2, panel_left.Size.Height - 5);
            }
            else
            {
                myTimer.Stop();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!on)
            {
                panel_left.Size = new Size(panel_left.Size.Width + 100, panel_left.Size.Height);
                button2.Location = new Point(button2.Location.X + 100, button2.Location.Y);
                on = !on;
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
                panel_left.Size = new Size(panel_left.Size.Width - 100, panel_left.Size.Height);
                button2.Location = new Point(button2.Location.X - 100, button2.Location.Y);
                on = !on;
            }
        }

        private void button_back_MouseClick(object sender, MouseEventArgs e)
        {
            Boolean exit = true;
            if (game_started)
            {
                DialogResult dr = MessageBox.Show("Vuoi davvero uscire?",
                      "La partita in corso sarà cancellata", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        exit = true;
                        game_started = false;
                        break;
                    case DialogResult.No:
                        exit = false;
                        break;
                }
                if (exit)
                {
                    panel_dadi.Visible = false;
                    label_status.Visible = false;
                    label_number.Visible = false;
                    label_game.Visible = false;
                    inGame = false;
                    inEditor = false;
                    this.Size = form_size;
                    panel_bottom.Size = panel_bottom_size;
                    foreach (Nation_Control n in listControl)
                    {
                        n.setSelect(false);
                    }
                    groupBox_number.Size = group_box_number_size;
                    groupBox_number.Location = group_box_number_location;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    groupBox_number.Visible = false;
                    groupBox_number.Enabled = false;
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel4.Visible = false;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    label_name1.Visible = false;
                    label_name2.Visible = false;
                    label_name3.Visible = false;
                    label_name4.Visible = false;
                    button_ok4.Visible = true;
                    button_ok3.Visible = true;
                    button_ok2.Visible = true;
                    button_ok1.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    game.clearList();
                    players.Clear();
                    foreach (Nation_Control n in listControl)
                    {
                        n.clearTank();

                    }
                    foreach (Player p in players)
                    {
                        p.clearPlayer();
                    }
                    button_gioca.Size = new Size(125, 65);
                    button_editor.Size = new Size(125, 65);
                    button_editor.Location = button_editor_location;
                    button_gioca.Location = button_gioca_location;
                    button_editor.Visible = true;
                    button_gioca.Visible = true;
                    label_tank1.Visible = false;
                    label_tank2.Visible = false;
                    label_tank3.Visible = false;
                    label_tank4.Visible = false;
                    button_next1.Visible = false;
                    button_next2.Visible = false;
                    button_next3.Visible = false;
                    button_next4.Visible = false;
                    finish.Clear();
                    phase = 0;
                }
                    
            }
            else
            {
                myTimer.Start();
                this.Size = form_size;
                panel_bottom.Size = panel_bottom_size;
                groupBox_number.Visible = false;
                groupBox_number.Size = new Size(200,150);
                groupBox_number.Location = group_box_number_location;
                panel_bottom.Size = panel_bottom_size;
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel_bottom.Visible = true;
                inGame = false;
                inEditor = false;
                button_gioca.Size = new Size(125, 65);
                button_editor.Size = new Size(125, 65);
                button_editor.Location = button_editor_location;
                button_gioca.Location = button_gioca_location;
                button_editor.Visible = true;
                button_gioca.Visible = true;
            }
            
            
        }

        private void button_gioca_MouseClick(object sender, MouseEventArgs e)
        {
            if (listControl.Count > 3)
            {
                myTimer_Gioca.Start();
                label_status.Text = "Gioca";
                label_status.Visible = true;
                inGame = true;
                this.Size = new Size(this.Size.Width, this.Size.Height + 100);
                panel_bottom.Size = new Size(panel_bottom.Size.Width, panel_bottom.Size.Height + 100);
                groupBox_number.Visible = true;
                groupBox_number.Enabled = true;
            }
            else
            {
                MessageBox.Show("Non puoi giocare con meno di 4 Regioni!");
            }
                   
        }

        private void button_editor_MouseClick(object sender, MouseEventArgs e)
        {
            this.Size = form_size;
            myTimer_Editor.Start();
            inEditor = true;
            panel_left.Size = panel_left_size;
            panel_left.Location = panel_left_location;
            label_status.Text = "Editor";
            label_status.Visible = true;
            panel_left.Visible = true;
            panel_left.Enabled = true;
        }

        private void button_draw_MouseClick(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            //this.Invalidate();
        }

        private void button_create_MouseClick(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            if (nation.Count > 0)
            {
                Point[] edges = nation.ToArray();
                id++;
                Nation_Control aux = new Nation_Control(edges, id);
                Controls.Add(aux);
                listControl.Add(aux);
                continent.Add(nation);

                nation.Clear();
                //this.Invalidate();

            }
        }

        private void button_delete_MouseClick(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            foreach (Nation_Control u in listControl.Reverse<Nation_Control>())
            {
                if (u.getSelect())
                {
                    Controls.RemoveByKey(u.Name);
                    listControl.Remove(u);
                    foreach (Nation_Control u2 in listControl)
                    {
                        u2.deleteNear(u);
                    }
                }
            }
            this.Invalidate();
        }

        private void button_friend_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Nation_Control u1 in listControl)
            {
                foreach (Nation_Control u2 in listControl)
                {
                    if (u1.getSelect())
                    {

                        if (u2.getSelect())
                        {
                            u1.setNear(u2);
                        }

                    }

                }
            }
            this.Invalidate();
        }

        private void button_scissor_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Nation_Control n in listControl)
            {
                if (n.getSelect())
                {
                    foreach (Nation_Control u in listControl)
                    {
                        if (u.getNear().Contains(n))
                        {
                            u.clearNear(n);
                        }
                    }

                }
            }
            this.Invalidate();
        }

        private void button_save_MouseClick(object sender, MouseEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).ToString() + @"\continent";
            sf.AddExtension = true;
            sf.DefaultExt = "bin";
            sf.Filter = "(*.bin)|*.*";
            sf.ShowDialog();
            String file = sf.FileName;
            foreach (Nation_Control u in listControl)
            {
                Nation n = new Nation(u.getEdges(), u.getID(), u.getNearId(), u.getColor());
                listNation.Add(n);
            }
            try
            {
                BinarySerialization.WriteToBinaryFile(file, listNation, false);
            }
            catch (ArgumentException) { }
            this.Invalidate();
        }

        private void button_load_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Nation_Control u in listControl)
            {
                Controls.RemoveByKey(u.Name);
            }
            continent.Clear();
            listControl.Clear();
            OpenFileDialog sf = new OpenFileDialog();
            sf.InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).ToString() + @"\continent";
            sf.AddExtension = true;
            sf.DefaultExt = "bin";
            sf.Filter = "(*.bin)|*.*";
            sf.ShowDialog();
            String file = sf.FileName;
            listNation.Clear();
            try
            {
                listNation = BinarySerialization.ReadFromBinaryFile<List<Nation>>(file);
                foreach (Nation _n in listNation)
                {
                    Nation_Control n = new Nation_Control(_n.getEdges(), _n.getId());
                    n.setColor(_n.getColor());
                    n.setSelect(false);
                    listControl.Add(n);
                    Controls.Add(n);
                }
                foreach (Nation_Control n in listControl)
                {
                    foreach (Nation _n in listNation)
                    {
                        if (_n.getId() == n.getID())
                        {
                            foreach (int i in _n.getNear())
                            {
                                foreach (Nation_Control n2 in listControl)
                                {
                                    if (n2.getID() == i)
                                    {
                                        n.setNear(n2);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (ArgumentException) { }
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (isDrawing)
            {
                foreach (Point c in nation)
                {
                    g.DrawEllipse(Pens.Red, new Rectangle(new Point(c.X - 5, c.Y - 5), Size = new Size(10, 10)));
                }


            }
            if (inGame || inEditor)
            {
                foreach (Nation_Control n in listControl)
                {
                    foreach (Nation_Control m in n.getNear())
                    {
                        g.DrawLine(Pens.Black, n.FindCentroid(), m.FindCentroid());
                    }
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                nation.Add(e.Location);
                this.Invalidate();
            }
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            radioButton2.Checked = true;
            myTimer_Number.Start();
            game.setNumber(2);
            panel1.Visible = true;
            panel2.Visible = true;
        }

        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            radioButton3.Checked = true;
            myTimer_Number.Start();
            game.setNumber(3);
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
        }

        private void radioButton4_MouseClick(object sender, MouseEventArgs e)
        {
            radioButton4.Checked = true;
            myTimer_Number.Start();
            game.setNumber(4);
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
        }

        private void button_ok1_MouseClick(object sender, MouseEventArgs e)
        {
            if (setName(textBox1.Text))
            {
                label_name1.Text = textBox1.Text;
                button_ok1.Visible = false;
                textBox1.Visible = false;
                label_name1.Visible = true;
                //pictureBox1.Tag = new Info_carro(label_name1.Text);
                if (game.getNumber())
                {
                    game_started = true;
                    startGame_Animation();
                }
            }
            else MessageBox.Show("Nome già esistente");
        }

        private void button_ok2_MouseClick(object sender, MouseEventArgs e)
        {
            if (setName(textBox2.Text))
            {
                label_name2.Text = textBox2.Text;
                button_ok2.Visible = false;
                textBox2.Visible = false;
                label_name2.Visible = true;
                //pictureBox2.Tag = new Info_carro(label_name2.Text);
                if (game.getNumber())
                {
                    game_started = true;
                    startGame_Animation();
                    //MessageBox.Show("INIZIO");
                }
            }
            else MessageBox.Show("Nome già esistente");
        }

        private void button_ok3_MouseClick(object sender, MouseEventArgs e)
        {
            if (setName(textBox3.Text))
            {
                label_name3.Text = textBox3.Text;
                button_ok3.Visible = false;
                textBox3.Visible = false;
                label_name3.Visible = true;
                //pictureBox3.Tag = new Info_carro(label_name3.Text);
                if (game.getNumber())
                {
                    game_started = true;
                    startGame_Animation();
                    //MessageBox.Show("INIZIO");
                }
            }
            else MessageBox.Show("Nome già esistente");
        }

        private void button_ok4_MouseClick(object sender, MouseEventArgs e)
        {
            if (setName(textBox4.Text))
            {
                label_name4.Text = textBox4.Text;
                button_ok4.Visible = false;
                textBox4.Visible = false;
                label_name4.Visible = true;
                //pictureBox4.Tag = new Info_carro(label_name4.Text);
                if (game.getNumber())
                {
                    game_started = true;
                    startGame_Animation();
                    //MessageBox.Show("INIZIO");
                }
            }
            else MessageBox.Show("Nome già esistente");

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (setName(textBox1.Text))
                {
                    label_name1.Text = textBox1.Text;
                    button_ok1.Visible = false;
                    textBox1.Visible = false;
                    label_name1.Visible = true;
                    //pictureBox1.Tag = new Info_carro(label_name1.Text);
                    if (game.getNumber())
                    {
                        game_started = true;
                        startGame_Animation();
                        //MessageBox.Show("INIZIO");
                    }
                }
                else MessageBox.Show("Nome già esistente");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (setName(textBox2.Text))
                {
                    label_name2.Text = textBox2.Text;
                    button_ok2.Visible = false;
                    textBox2.Visible = false;
                    label_name2.Visible = true;
                    //pictureBox2.Tag = new Info_carro(label_name2.Text);
                    if (game.getNumber())
                    {
                        game_started = true;
                        startGame_Animation();
                        //MessageBox.Show("INIZIO");
                    }
                }
                else MessageBox.Show("Nome già esistente");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (setName(textBox3.Text))
                {
                    label_name3.Text = textBox3.Text;
                    button_ok3.Visible = false;
                    textBox3.Visible = false;
                    label_name3.Visible = true;
                    //pictureBox3.Tag = new Info_carro(label_name3.Text);
                    if (game.getNumber())
                    {
                        game_started = true;
                        startGame_Animation();
                        //MessageBox.Show("INIZIO");
                    }
                }
                else MessageBox.Show("Nome già esistente");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (setName(textBox4.Text))
                {
                    label_name4.Text = textBox4.Text;
                    button_ok4.Visible = false;
                    textBox4.Visible = false;
                    label_name4.Visible = true;
                    //pictureBox4.Tag = new Info_carro(label_name4.Text);
                    if (game.getNumber())
                    {
                        game_started = true;
                        startGame_Animation();
                        //MessageBox.Show("INIZIO");
                    }
                }
                else MessageBox.Show("Nome già esistente");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private Boolean setName(String n)
        {
            return game.setName(n);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (game_started)
            {
                if (players[0].getNum() > players[0].getRegion()/3)
                {
                    panel1.AllowDrop = true;
                    PictureBox aux = new PictureBox();
                    aux.Tag = pictureBox1.Tag;
                    aux.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).ToString() + @"\carri\black.png");
                    pictureBox1.DoDragDrop(aux, DragDropEffects.Move);
                }
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (game_started)
            {
                if (players[1].getNum() > players[1].getRegion() / 3)
                {
                    panel2.AllowDrop = true;
                    PictureBox aux = new PictureBox();
                    aux.Tag = pictureBox2.Tag;
                    aux.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).ToString() + @"\carri\red.png");
                    pictureBox2.DoDragDrop(aux, DragDropEffects.Move);
                }
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (game_started)
            {
                if (players[2].getNum() > players[2].getRegion() / 3)
                {
                    panel3.AllowDrop = true;
                    PictureBox aux = new PictureBox();
                    aux.Tag = pictureBox3.Tag;
                    aux.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).ToString() + @"\carri\green.png");
                    pictureBox3.DoDragDrop(aux, DragDropEffects.Move);
                }
            }
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (game_started)
            {
                if (players[3].getNum() > players[3].getRegion() / 3)
                {
                    panel4.AllowDrop = true;
                    PictureBox aux = new PictureBox();
                    aux.Tag = pictureBox4.Tag;
                    aux.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).ToString() + @"\carri\blue.png");
                    pictureBox4.DoDragDrop(aux, DragDropEffects.Move);
                }
            }
        }

        private void startGame_Animation()
        {
            turn_player = 0;
            labelContainer1.Visible = true;
            labelContainer1.timer_start();
            game.setTankNumber(listControl.Count()*2);
            for(int i = 0; i < game.getPlayerNum(); i++)
            {
                players.Add(new Player(game.getTankNumber(), i,this));
            }
            init_game();
        }

        private void init_game()
        {
            int m = game.getPlayerNum();
            for (int i = 0; i < m; i++)
                finish.Add(false);
            foreach(Nation_Control n in listControl)
            {
                n.setPlayers(this,players);
                if (n.getID() % m == 0)
                {
                    n.addTank(pictureBox1);
                    players[0].addNumRegion();
                }
                if (n.getID() % m == 1)
                {
                    n.addTank(pictureBox2);
                    players[1].addNumRegion();
                }
                if (n.getID() % m == 2)
                {
                    n.addTank(pictureBox3);
                    players[2].addNumRegion();
                }
                if (n.getID() % m == 3)
                {
                    n.addTank(pictureBox4);
                    players[3].addNumRegion();
                }
            }
            
            if (panel1.Visible)
            {
                label_tank1.Visible = true;
                label_tank1.Text = players[0].getNum().ToString();
                label_tank1.Visible = true;
                button_next1.Visible = true;
            }
            if (panel2.Visible)
            {
                label_tank2.Visible = true;
                label_tank2.Text = players[1].getNum().ToString();
                label_tank2.Visible = true;
                button_next2.Visible = true;
            }
            if (panel3.Visible)
            {
                label_tank3.Visible = true;
                label_tank3.Text = players[2].getNum().ToString();
                label_tank3.Visible = true;
                button_next3.Visible = true;
            }
            if (panel4.Visible)
            {
                label_tank4.Visible = true;
                label_tank4.Text = players[3].getNum().ToString();
                label_tank4.Visible = true;
                button_next4.Visible = true;
            }

            pos_phase();
        }

        private void pos_phase()
        {
            foreach(Nation_Control n in listControl)
            {
                n.drawInitialTanks();
            }
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            label_game.Visible = true;
            label_game.Text = pos;
        }

        private void button_next1_MouseClick(object sender, MouseEventArgs e)
        {
            finish[0] = true;
            button_next1.ForeColor = Color.Gray;
            switch (phase)
            {
                case 0:
                    pictureBox1.Enabled = true;
                    if (!finish.Contains(false))
                    {
                        reinforce_phase();
                    }
                    break;
                case 1:
                    pictureBox1.Enabled = false;
                    if (!finish.Contains(false))
                    {
                        attack_phase();
                    }
                    break;
                case 2:
                    pictureBox1.Enabled = false;
                    if (!finish.Contains(false))
                    {
                        move_phase();
                    }
                    break;
                case 3:
                    pictureBox1.Enabled = true;
                    if (!finish.Contains(false))
                    {
                        reinforce_phase();
                    }
                    break;
            }
        }


        private void button_next2_MouseClick(object sender, MouseEventArgs e)
        {
            finish[1] = true;
            button_next2.ForeColor = Color.Gray;
            switch (phase)
            {
                case 0:
                    pictureBox2.Enabled = true;
                    if (!finish.Contains(false))
                    {
                        reinforce_phase();
                    }
                    break;
                case 1:
                    pictureBox2.Enabled = false;
                    if (!finish.Contains(false))
                    {
                        attack_phase();
                    }
                    break;
                case 2:
                    pictureBox2.Enabled = false;
                    if (!finish.Contains(false))
                    {
                        move_phase();
                    }
                    break;
                case 3:
                    pictureBox2.Enabled = true;
                    if (!finish.Contains(false))
                    {
                        reinforce_phase();
                    }
                    break;
            }
        }


        private void button_next3_MouseClick(object sender, MouseEventArgs e)
        {
            finish[2] = true;
            button_next3.ForeColor = Color.Gray;
            switch (phase)
            {
                case 0:
                    pictureBox3.Enabled = true;
                    if (!finish.Contains(false))
                    {
                        reinforce_phase();
                    }
                    break;
                case 1:
                    pictureBox3.Enabled = false;
                    if (!finish.Contains(false))
                    {
                        attack_phase();
                    }
                    break;
                case 2:
                    pictureBox3.Enabled = false;
                    if (!finish.Contains(false))
                    {
                        move_phase();
                    }
                    break;
                case 3:
                    pictureBox3.Enabled = true;
                    if (!finish.Contains(false))
                    {
                        reinforce_phase();
                    }
                    break;
            }
        }

        private void button_next4_MouseClick(object sender, MouseEventArgs e)
        {
            finish[3] = true;
            button_next4.ForeColor = Color.Gray;
            switch (phase)
            {
                case 0:
                    pictureBox4.Enabled = true;
                    if (!finish.Contains(false))
                    {
                        reinforce_phase();
                    }
                    break;
                case 1:
                    pictureBox4.Enabled = false;
                    if (!finish.Contains(false))
                    {
                        attack_phase();
                    }
                    break;
                case 2:
                    pictureBox4.Enabled = false;
                    if (!finish.Contains(false))
                    {
                        move_phase();
                    }
                    break;
                case 3:
                    pictureBox4.Enabled = true;
                    if (!finish.Contains(false))
                    {
                        reinforce_phase();
                    }
                    break;
            }
        }

        private void reinforce_phase()
        {
            phase = 1;
            label_game.Text = "Rinforzo";
            foreach (Player p in players)
            {
                p.increaseNum(p.getRegion() / 3,p.getID());
            }
            reset_finish();
        }

        private void attack_phase()
        {
            phase = 2;
            label_game.Text = "Attacco!";
            panel_dadi.Visible = true;
            foreach (Player p in players)
            {
                
            }
            reset_finish();
        }


        private void move_phase()
        {
            phase = 3;
            label_game.Text = "Spostamento";
            panel_dadi.Visible = false;
            foreach (Player p in players)
            {

            }
            reset_finish();
        }

        private void reset_finish()
        {
            button_next1.ForeColor = Color.White;
            button_next2.ForeColor = Color.White;
            button_next3.ForeColor = Color.White;
            button_next4.ForeColor = Color.White;
            for (int i = 0; i < finish.Count(); i++)
                finish[i] = false;
        }

    }
}
