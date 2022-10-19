
namespace Capa_VistaContabilidad
{
    partial class Activos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navegador1 = new NavegadorVista.Navegador();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(63, 24);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 0;
            // 
            // Activos
            // 
            this.ClientSize = new System.Drawing.Size(802, 392);
            this.Controls.Add(this.navegador1);
            this.Name = "Activos";
            this.Load += new System.EventHandler(this.Activos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel18;
        private FontAwesome.Sharp.IconButton iconButton26;
        private FontAwesome.Sharp.IconButton iconButton12;
        private FontAwesome.Sharp.IconButton iconButton25;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label31;
        private NavegadorVista.Navegador navegador1;
    }
}