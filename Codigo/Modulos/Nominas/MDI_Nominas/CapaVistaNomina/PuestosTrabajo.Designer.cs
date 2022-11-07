
namespace CapaVistaNomina
{
    partial class PuestosTrabajo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnombrepuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidpuesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridPuestosTrabajo = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuestosTrabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 48);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PUESTOS DE TRABAJO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtestado);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtnombrepuesto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtidpuesto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridPuestosTrabajo);
            this.panel2.Location = new System.Drawing.Point(34, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 310);
            this.panel2.TabIndex = 2;
            // 
            // txtestado
            // 
            this.txtestado.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtestado.Location = new System.Drawing.Point(128, 120);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(80, 22);
            this.txtestado.TabIndex = 18;
            this.txtestado.Tag = "estado_puesto";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(64, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label8.Location = new System.Drawing.Point(16, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Estado";
            // 
            // txtnombrepuesto
            // 
            this.txtnombrepuesto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtnombrepuesto.Location = new System.Drawing.Point(16, 72);
            this.txtnombrepuesto.Name = "txtnombrepuesto";
            this.txtnombrepuesto.Size = new System.Drawing.Size(192, 22);
            this.txtnombrepuesto.TabIndex = 15;
            this.txtnombrepuesto.Tag = "nombre_puesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(16, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre De Puesto";
            // 
            // txtidpuesto
            // 
            this.txtidpuesto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtidpuesto.Location = new System.Drawing.Point(16, 25);
            this.txtidpuesto.Name = "txtidpuesto";
            this.txtidpuesto.Size = new System.Drawing.Size(192, 22);
            this.txtidpuesto.TabIndex = 5;
            this.txtidpuesto.Tag = "pk_id_puesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(16, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Puesto de Trabajo";
            // 
            // dataGridPuestosTrabajo
            // 
            this.dataGridPuestosTrabajo.AllowUserToAddRows = false;
            this.dataGridPuestosTrabajo.AllowUserToDeleteRows = false;
            this.dataGridPuestosTrabajo.AllowUserToResizeColumns = false;
            this.dataGridPuestosTrabajo.AllowUserToResizeRows = false;
            this.dataGridPuestosTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPuestosTrabajo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPuestosTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPuestosTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPuestosTrabajo.Location = new System.Drawing.Point(240, 16);
            this.dataGridPuestosTrabajo.MultiSelect = false;
            this.dataGridPuestosTrabajo.Name = "dataGridPuestosTrabajo";
            this.dataGridPuestosTrabajo.ReadOnly = true;
            this.dataGridPuestosTrabajo.RowHeadersVisible = false;
            this.dataGridPuestosTrabajo.RowHeadersWidth = 51;
            this.dataGridPuestosTrabajo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridPuestosTrabajo.ShowEditingIcon = false;
            this.dataGridPuestosTrabajo.Size = new System.Drawing.Size(464, 287);
            this.dataGridPuestosTrabajo.TabIndex = 0;
            this.dataGridPuestosTrabajo.Tag = "tbl_puestosdetrabajo";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(88, 56);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 3;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // PuestosTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 533);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PuestosTrabajo";
            this.Text = "PuestosTrabajo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuestosTrabajo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnombrepuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidpuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridPuestosTrabajo;
        private NavegadorVista.Navegador navegador1;
    }
}