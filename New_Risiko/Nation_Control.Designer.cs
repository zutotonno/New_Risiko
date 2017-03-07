namespace New_Risiko
{
    partial class Nation_Control
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
            this.SuspendLayout();
            // 
            // Nation_Control
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Nation_Control";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.Nation_Control_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Nation_Control_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Nation_Control_DragEnter);
            this.MouseHover += new System.EventHandler(this.Nation_Control_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
