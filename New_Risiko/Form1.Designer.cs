namespace New_Risiko
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_up = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.button_delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_load = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_scissor = new System.Windows.Forms.Button();
            this.button_friend = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.button_draw = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.button_editor = new System.Windows.Forms.Button();
            this.button_gioca = new System.Windows.Forms.Button();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_next4 = new System.Windows.Forms.Button();
            this.label_tank4 = new System.Windows.Forms.Label();
            this.label_name4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button_ok4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_next3 = new System.Windows.Forms.Button();
            this.label_tank3 = new System.Windows.Forms.Label();
            this.label_name3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_ok3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_next2 = new System.Windows.Forms.Button();
            this.label_tank2 = new System.Windows.Forms.Label();
            this.label_name2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_ok2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_next1 = new System.Windows.Forms.Button();
            this.label_tank1 = new System.Windows.Forms.Label();
            this.label_name1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_ok1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox_number = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label_number = new System.Windows.Forms.Label();
            this.label_game = new System.Windows.Forms.Label();
            this.panel_dadi = new System.Windows.Forms.Panel();
            this.dado3 = new New_Risiko.UserContainer();
            this.dado2 = new New_Risiko.UserContainer();
            this.dado1 = new New_Risiko.UserContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_up.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_number.SuspendLayout();
            this.panel_dadi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_up
            // 
            this.panel_up.BackColor = System.Drawing.Color.Transparent;
            this.panel_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_up.BackgroundImage")));
            this.panel_up.Controls.Add(this.label3);
            this.panel_up.Controls.Add(this.label_game);
            this.panel_up.Controls.Add(this.label1);
            this.panel_up.Controls.Add(this.button_back);
            this.panel_up.Controls.Add(this.button1);
            this.panel_up.Location = new System.Drawing.Point(0, 0);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(1000, 32);
            this.panel_up.TabIndex = 0;
            this.panel_up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Risiko!";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Transparent;
            this.button_back.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.ForeColor = System.Drawing.Color.Transparent;
            this.button_back.Image = ((System.Drawing.Image)(resources.GetObject("button_back.Image")));
            this.button_back.Location = new System.Drawing.Point(917, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(49, 30);
            this.button_back.TabIndex = 8;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_back_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(972, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_left.Controls.Add(this.button_delete);
            this.panel_left.Controls.Add(this.label2);
            this.panel_left.Controls.Add(this.button_load);
            this.panel_left.Controls.Add(this.button_save);
            this.panel_left.Controls.Add(this.button_scissor);
            this.panel_left.Controls.Add(this.button_friend);
            this.panel_left.Controls.Add(this.button_create);
            this.panel_left.Controls.Add(this.button_draw);
            this.panel_left.Controls.Add(this.button2);
            this.panel_left.Enabled = false;
            this.panel_left.Location = new System.Drawing.Point(0, 32);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(50, 568);
            this.panel_left.TabIndex = 1;
            this.panel_left.Visible = false;
            // 
            // button_delete
            // 
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_delete.Image = ((System.Drawing.Image)(resources.GetObject("button_delete.Image")));
            this.button_delete.Location = new System.Drawing.Point(-2, 177);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(150, 40);
            this.button_delete.TabIndex = 9;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_delete_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "EDITOR";
            this.label2.Visible = false;
            // 
            // button_load
            // 
            this.button_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_load.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_load.Image = ((System.Drawing.Image)(resources.GetObject("button_load.Image")));
            this.button_load.Location = new System.Drawing.Point(-2, 436);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(150, 40);
            this.button_load.TabIndex = 6;
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_load_MouseClick);
            // 
            // button_save
            // 
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_save.Image = ((System.Drawing.Image)(resources.GetObject("button_save.Image")));
            this.button_save.Location = new System.Drawing.Point(-1, 372);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(150, 40);
            this.button_save.TabIndex = 5;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_save_MouseClick);
            // 
            // button_scissor
            // 
            this.button_scissor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scissor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_scissor.Image = ((System.Drawing.Image)(resources.GetObject("button_scissor.Image")));
            this.button_scissor.Location = new System.Drawing.Point(-2, 305);
            this.button_scissor.Name = "button_scissor";
            this.button_scissor.Size = new System.Drawing.Size(150, 40);
            this.button_scissor.TabIndex = 4;
            this.button_scissor.UseVisualStyleBackColor = true;
            this.button_scissor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_scissor_MouseClick);
            // 
            // button_friend
            // 
            this.button_friend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_friend.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_friend.Image = ((System.Drawing.Image)(resources.GetObject("button_friend.Image")));
            this.button_friend.Location = new System.Drawing.Point(-2, 238);
            this.button_friend.Name = "button_friend";
            this.button_friend.Size = new System.Drawing.Size(150, 40);
            this.button_friend.TabIndex = 3;
            this.button_friend.UseVisualStyleBackColor = true;
            this.button_friend.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_friend_MouseClick);
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_create.Image = ((System.Drawing.Image)(resources.GetObject("button_create.Image")));
            this.button_create.Location = new System.Drawing.Point(-2, 115);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(150, 40);
            this.button_create.TabIndex = 2;
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_create_MouseClick);
            // 
            // button_draw
            // 
            this.button_draw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_draw.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_draw.Image = ((System.Drawing.Image)(resources.GetObject("button_draw.Image")));
            this.button_draw.Location = new System.Drawing.Point(-2, 54);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(150, 40);
            this.button_draw.TabIndex = 1;
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_draw_MouseClick);
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(-2, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 40);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(938, 35);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(50, 17);
            this.label_status.TabIndex = 4;
            this.label_status.Text = "Editor";
            this.label_status.Visible = false;
            // 
            // button_editor
            // 
            this.button_editor.BackColor = System.Drawing.Color.White;
            this.button_editor.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_editor.Image = ((System.Drawing.Image)(resources.GetObject("button_editor.Image")));
            this.button_editor.Location = new System.Drawing.Point(599, 500);
            this.button_editor.Name = "button_editor";
            this.button_editor.Size = new System.Drawing.Size(125, 65);
            this.button_editor.TabIndex = 3;
            this.button_editor.Text = "Editor";
            this.button_editor.UseVisualStyleBackColor = false;
            this.button_editor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_editor_MouseClick);
            // 
            // button_gioca
            // 
            this.button_gioca.BackColor = System.Drawing.Color.Transparent;
            this.button_gioca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_gioca.BackgroundImage")));
            this.button_gioca.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gioca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_gioca.Image = ((System.Drawing.Image)(resources.GetObject("button_gioca.Image")));
            this.button_gioca.Location = new System.Drawing.Point(283, 500);
            this.button_gioca.Name = "button_gioca";
            this.button_gioca.Size = new System.Drawing.Size(125, 65);
            this.button_gioca.TabIndex = 2;
            this.button_gioca.Text = "Gioca";
            this.button_gioca.UseVisualStyleBackColor = false;
            this.button_gioca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_gioca_MouseClick);
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.Black;
            this.panel_bottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_bottom.BackgroundImage")));
            this.panel_bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_bottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_bottom.Controls.Add(this.panel4);
            this.panel_bottom.Controls.Add(this.panel3);
            this.panel_bottom.Controls.Add(this.panel2);
            this.panel_bottom.Controls.Add(this.panel1);
            this.panel_bottom.Location = new System.Drawing.Point(0, 565);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1000, 135);
            this.panel_bottom.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button_next4);
            this.panel4.Controls.Add(this.label_tank4);
            this.panel4.Controls.Add(this.label_name4);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.button_ok4);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Location = new System.Drawing.Point(761, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 117);
            this.panel4.TabIndex = 3;
            this.panel4.Visible = false;
            // 
            // button_next4
            // 
            this.button_next4.FlatAppearance.BorderSize = 3;
            this.button_next4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_next4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_next4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next4.ForeColor = System.Drawing.Color.White;
            this.button_next4.Location = new System.Drawing.Point(83, 64);
            this.button_next4.Name = "button_next4";
            this.button_next4.Size = new System.Drawing.Size(65, 30);
            this.button_next4.TabIndex = 12;
            this.button_next4.Text = "Procedi";
            this.button_next4.UseVisualStyleBackColor = true;
            this.button_next4.Visible = false;
            this.button_next4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_next4_MouseClick);
            // 
            // label_tank4
            // 
            this.label_tank4.AutoSize = true;
            this.label_tank4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tank4.ForeColor = System.Drawing.SystemColors.Control;
            this.label_tank4.Location = new System.Drawing.Point(154, 86);
            this.label_tank4.Name = "label_tank4";
            this.label_tank4.Size = new System.Drawing.Size(39, 27);
            this.label_tank4.TabIndex = 11;
            this.label_tank4.Text = "30";
            this.label_tank4.Visible = false;
            // 
            // label_name4
            // 
            this.label_name4.AutoSize = true;
            this.label_name4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_name4.Location = new System.Drawing.Point(29, 5);
            this.label_name4.Name = "label_name4";
            this.label_name4.Size = new System.Drawing.Size(123, 30);
            this.label_name4.TabIndex = 9;
            this.label_name4.Text = "Giocatore4";
            this.label_name4.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 49);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 45);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "4";
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            // 
            // button_ok4
            // 
            this.button_ok4.Location = new System.Drawing.Point(121, 9);
            this.button_ok4.Name = "button_ok4";
            this.button_ok4.Size = new System.Drawing.Size(31, 23);
            this.button_ok4.TabIndex = 8;
            this.button_ok4.Text = "OK";
            this.button_ok4.UseVisualStyleBackColor = true;
            this.button_ok4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_ok4_MouseClick);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(3, 6);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 26);
            this.textBox4.TabIndex = 8;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button_next3);
            this.panel3.Controls.Add(this.label_tank3);
            this.panel3.Controls.Add(this.label_name3);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.button_ok3);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Location = new System.Drawing.Point(522, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 117);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // button_next3
            // 
            this.button_next3.FlatAppearance.BorderSize = 3;
            this.button_next3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_next3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_next3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next3.ForeColor = System.Drawing.Color.White;
            this.button_next3.Location = new System.Drawing.Point(84, 64);
            this.button_next3.Name = "button_next3";
            this.button_next3.Size = new System.Drawing.Size(65, 30);
            this.button_next3.TabIndex = 11;
            this.button_next3.Text = "Procedi";
            this.button_next3.UseVisualStyleBackColor = true;
            this.button_next3.Visible = false;
            this.button_next3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_next3_MouseClick);
            // 
            // label_tank3
            // 
            this.label_tank3.AutoSize = true;
            this.label_tank3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tank3.ForeColor = System.Drawing.SystemColors.Control;
            this.label_tank3.Location = new System.Drawing.Point(154, 86);
            this.label_tank3.Name = "label_tank3";
            this.label_tank3.Size = new System.Drawing.Size(39, 27);
            this.label_tank3.TabIndex = 10;
            this.label_tank3.Text = "30";
            this.label_tank3.Visible = false;
            // 
            // label_name3
            // 
            this.label_name3.AutoSize = true;
            this.label_name3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_name3.Location = new System.Drawing.Point(30, 6);
            this.label_name3.Name = "label_name3";
            this.label_name3.Size = new System.Drawing.Size(123, 30);
            this.label_name3.TabIndex = 9;
            this.label_name3.Text = "Giocatore3";
            this.label_name3.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 45);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "3";
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            // 
            // button_ok3
            // 
            this.button_ok3.Location = new System.Drawing.Point(121, 9);
            this.button_ok3.Name = "button_ok3";
            this.button_ok3.Size = new System.Drawing.Size(31, 23);
            this.button_ok3.TabIndex = 7;
            this.button_ok3.Text = "OK";
            this.button_ok3.UseVisualStyleBackColor = true;
            this.button_ok3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_ok3_MouseClick);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 6);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 26);
            this.textBox3.TabIndex = 7;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button_next2);
            this.panel2.Controls.Add(this.label_tank2);
            this.panel2.Controls.Add(this.label_name2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button_ok2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(281, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 117);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // button_next2
            // 
            this.button_next2.FlatAppearance.BorderSize = 3;
            this.button_next2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_next2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_next2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next2.ForeColor = System.Drawing.Color.White;
            this.button_next2.Location = new System.Drawing.Point(84, 64);
            this.button_next2.Name = "button_next2";
            this.button_next2.Size = new System.Drawing.Size(65, 30);
            this.button_next2.TabIndex = 10;
            this.button_next2.Text = "Procedi";
            this.button_next2.UseVisualStyleBackColor = true;
            this.button_next2.Visible = false;
            this.button_next2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_next2_MouseClick);
            // 
            // label_tank2
            // 
            this.label_tank2.AutoSize = true;
            this.label_tank2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tank2.ForeColor = System.Drawing.SystemColors.Control;
            this.label_tank2.Location = new System.Drawing.Point(154, 86);
            this.label_tank2.Name = "label_tank2";
            this.label_tank2.Size = new System.Drawing.Size(39, 27);
            this.label_tank2.TabIndex = 9;
            this.label_tank2.Text = "30";
            this.label_tank2.Visible = false;
            // 
            // label_name2
            // 
            this.label_name2.AutoSize = true;
            this.label_name2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name2.ForeColor = System.Drawing.Color.DarkRed;
            this.label_name2.Location = new System.Drawing.Point(32, 5);
            this.label_name2.Name = "label_name2";
            this.label_name2.Size = new System.Drawing.Size(123, 30);
            this.label_name2.TabIndex = 8;
            this.label_name2.Text = "Giocatore2";
            this.label_name2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 45);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "2";
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // button_ok2
            // 
            this.button_ok2.Location = new System.Drawing.Point(121, 9);
            this.button_ok2.Name = "button_ok2";
            this.button_ok2.Size = new System.Drawing.Size(31, 23);
            this.button_ok2.TabIndex = 6;
            this.button_ok2.Text = "OK";
            this.button_ok2.UseVisualStyleBackColor = true;
            this.button_ok2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_ok2_MouseClick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(3, 6);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 26);
            this.textBox2.TabIndex = 6;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_next1);
            this.panel1.Controls.Add(this.label_tank1);
            this.panel1.Controls.Add(this.label_name1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_ok1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(36, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 118);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // button_next1
            // 
            this.button_next1.BackColor = System.Drawing.Color.Transparent;
            this.button_next1.FlatAppearance.BorderSize = 3;
            this.button_next1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_next1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_next1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next1.ForeColor = System.Drawing.Color.White;
            this.button_next1.Location = new System.Drawing.Point(85, 65);
            this.button_next1.Name = "button_next1";
            this.button_next1.Size = new System.Drawing.Size(65, 30);
            this.button_next1.TabIndex = 9;
            this.button_next1.Text = "Procedi";
            this.button_next1.UseVisualStyleBackColor = false;
            this.button_next1.Visible = false;
            this.button_next1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_next1_MouseClick);
            // 
            // label_tank1
            // 
            this.label_tank1.AutoSize = true;
            this.label_tank1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tank1.ForeColor = System.Drawing.SystemColors.Control;
            this.label_tank1.Location = new System.Drawing.Point(154, 87);
            this.label_tank1.Name = "label_tank1";
            this.label_tank1.Size = new System.Drawing.Size(39, 27);
            this.label_tank1.TabIndex = 8;
            this.label_tank1.Text = "30";
            this.label_tank1.Visible = false;
            // 
            // label_name1
            // 
            this.label_name1.AutoSize = true;
            this.label_name1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name1.Location = new System.Drawing.Point(28, 4);
            this.label_name1.Name = "label_name1";
            this.label_name1.Size = new System.Drawing.Size(123, 30);
            this.label_name1.TabIndex = 7;
            this.label_name1.Text = "Giocatore1";
            this.label_name1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 45);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "1";
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // button_ok1
            // 
            this.button_ok1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok1.Location = new System.Drawing.Point(115, 7);
            this.button_ok1.Name = "button_ok1";
            this.button_ok1.Size = new System.Drawing.Size(31, 23);
            this.button_ok1.TabIndex = 5;
            this.button_ok1.Text = "OK";
            this.button_ok1.UseVisualStyleBackColor = true;
            this.button_ok1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_ok1_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-3, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // groupBox_number
            // 
            this.groupBox_number.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox_number.Controls.Add(this.radioButton4);
            this.groupBox_number.Controls.Add(this.radioButton3);
            this.groupBox_number.Controls.Add(this.radioButton2);
            this.groupBox_number.Enabled = false;
            this.groupBox_number.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_number.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_number.Location = new System.Drawing.Point(397, 210);
            this.groupBox_number.Name = "groupBox_number";
            this.groupBox_number.Size = new System.Drawing.Size(200, 150);
            this.groupBox_number.TabIndex = 6;
            this.groupBox_number.TabStop = false;
            this.groupBox_number.Text = "Inserisci numero Giocatori";
            this.groupBox_number.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(24, 105);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(144, 34);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "4";
            this.radioButton4.Text = "4 Giocatori";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton4_MouseClick);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(24, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(144, 34);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "3";
            this.radioButton3.Text = "3 Giocatori";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton3_MouseClick);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(24, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(144, 34);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "2 Giocatori";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.BackColor = System.Drawing.Color.Transparent;
            this.label_number.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_number.Location = new System.Drawing.Point(917, 56);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(46, 18);
            this.label_number.TabIndex = 7;
            this.label_number.Text = "label3";
            this.label_number.Visible = false;
            // 
            // label_game
            // 
            this.label_game.AutoSize = true;
            this.label_game.BackColor = System.Drawing.Color.Transparent;
            this.label_game.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_game.ForeColor = System.Drawing.Color.White;
            this.label_game.Location = new System.Drawing.Point(616, 0);
            this.label_game.Name = "label_game";
            this.label_game.Size = new System.Drawing.Size(160, 29);
            this.label_game.TabIndex = 8;
            this.label_game.Text = "Posizionamento";
            this.label_game.Visible = false;
            // 
            // panel_dadi
            // 
            this.panel_dadi.Controls.Add(this.dado3);
            this.panel_dadi.Controls.Add(this.dado2);
            this.panel_dadi.Controls.Add(this.dado1);
            this.panel_dadi.Location = new System.Drawing.Point(57, 35);
            this.panel_dadi.Name = "panel_dadi";
            this.panel_dadi.Size = new System.Drawing.Size(940, 530);
            this.panel_dadi.TabIndex = 9;
            this.panel_dadi.Visible = false;
            // 
            // dado3
            // 
            this.dado3.BackColor = System.Drawing.Color.Gray;
            this.dado3.Location = new System.Drawing.Point(531, 0);
            this.dado3.Name = "dado3";
            this.dado3.Size = new System.Drawing.Size(100, 532);
            this.dado3.TabIndex = 2;
            // 
            // dado2
            // 
            this.dado2.BackColor = System.Drawing.Color.Gray;
            this.dado2.Location = new System.Drawing.Point(387, 0);
            this.dado2.Name = "dado2";
            this.dado2.Size = new System.Drawing.Size(100, 532);
            this.dado2.TabIndex = 1;
            // 
            // dado1
            // 
            this.dado1.BackColor = System.Drawing.Color.Gray;
            this.dado1.Location = new System.Drawing.Point(258, 0);
            this.dado1.Name = "dado1";
            this.dado1.Size = new System.Drawing.Size(100, 532);
            this.dado1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(542, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fase :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.ControlBox = false;
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.groupBox_number);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.button_editor);
            this.Controls.Add(this.button_gioca);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_up);
            this.Controls.Add(this.panel_dadi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.panel_bottom.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_number.ResumeLayout(false);
            this.groupBox_number.PerformLayout();
            this.panel_dadi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_draw;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_friend;
        private System.Windows.Forms.Button button_scissor;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_editor;
        private System.Windows.Forms.Button button_gioca;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.GroupBox groupBox_number;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_ok1;
        private System.Windows.Forms.Label label_name4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button_ok4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label_name3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_ok3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_name2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_ok2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_name1;
        private System.Windows.Forms.Label label_game;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label_tank4;
        public System.Windows.Forms.Label label_tank3;
        public System.Windows.Forms.Label label_tank2;
        public System.Windows.Forms.Label label_tank1;
        private System.Windows.Forms.Button button_next1;
        private System.Windows.Forms.Button button_next4;
        private System.Windows.Forms.Button button_next3;
        private System.Windows.Forms.Button button_next2;
        private System.Windows.Forms.Panel panel_dadi;
        private UserContainer dado3;
        private UserContainer dado2;
        private UserContainer dado1;
        private System.Windows.Forms.Label label3;
    }
}

