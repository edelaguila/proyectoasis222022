
namespace ComprasVista
{
    partial class AyudaCajaClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.Dgv_ayudacajac = new System.Windows.Forms.DataGridView();
            this.btninsertar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ayudacajac)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Codigo";
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Location = new System.Drawing.Point(226, 106);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(316, 20);
            this.Txt_codigo.TabIndex = 63;
            // 
            // Dgv_ayudacajac
            // 
            this.Dgv_ayudacajac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ayudacajac.Location = new System.Drawing.Point(21, 158);
            this.Dgv_ayudacajac.Name = "Dgv_ayudacajac";
            this.Dgv_ayudacajac.Size = new System.Drawing.Size(759, 274);
            this.Dgv_ayudacajac.TabIndex = 61;
            // 
            // btninsertar
            // 
            this.btninsertar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btninsertar.FlatAppearance.BorderSize = 2;
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btninsertar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btninsertar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btninsertar.IconSize = 40;
            this.btninsertar.Location = new System.Drawing.Point(348, 18);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(69, 61);
            this.btninsertar.TabIndex = 62;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // AyudaCajaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_codigo);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.Dgv_ayudacajac);
            this.Name = "AyudaCajaClientes";
            this.Text = "AyudaCajaClientes";
            //this.Load += new System.EventHandler(this.AyudaCajaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ayudacajac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_codigo;
        private FontAwesome.Sharp.IconButton btninsertar;
        private System.Windows.Forms.DataGridView Dgv_ayudacajac;
    }
}