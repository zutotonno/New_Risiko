namespace New_Risiko
{
    partial class UserContainer
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dado_box1 = new New_Risiko.dado_box();
            this.SuspendLayout();
            // 
            // dado_box1
            // 
            this.dado_box1.BackColor = System.Drawing.Color.Transparent;
            this.dado_box1.Location = new System.Drawing.Point(13, 376);
            this.dado_box1.Name = "dado_box1";
            this.dado_box1.Size = new System.Drawing.Size(84, 84);
            this.dado_box1.TabIndex = 0;
            // 
            // UserContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.dado_box1);
            this.DoubleBuffered = true;
            this.Name = "UserContainer";
            this.Size = new System.Drawing.Size(100, 532);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserContainer_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserContainer_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private dado_box dado_box1;
    }
}
