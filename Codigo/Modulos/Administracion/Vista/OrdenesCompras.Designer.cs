
namespace Vista
{
    partial class OrdenesCompras
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ref_prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_can = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc_asoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forma_envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 139);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Proveedor,
            this.Nombre,
            this.Estatus,
            this.ref_prov,
            this.fecha_doc,
            this.fecha_rec,
            this.fecha_can,
            this.Almacen,
            this.doc_asoc,
            this.Serie,
            this.Folio,
            this.total_doc,
            this.forma_envio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1060, 311);
            this.dataGridView1.TabIndex = 3;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            // 
            // ref_prov
            // 
            this.ref_prov.HeaderText = "Referencia Proveedor";
            this.ref_prov.Name = "ref_prov";
            // 
            // fecha_doc
            // 
            this.fecha_doc.HeaderText = "Fecha de documento";
            this.fecha_doc.Name = "fecha_doc";
            // 
            // fecha_rec
            // 
            this.fecha_rec.HeaderText = "Fecha de recepcion";
            this.fecha_rec.Name = "fecha_rec";
            // 
            // fecha_can
            // 
            this.fecha_can.HeaderText = "Fecha de cancelacion";
            this.fecha_can.Name = "fecha_can";
            // 
            // Almacen
            // 
            this.Almacen.HeaderText = "Almacen";
            this.Almacen.Name = "Almacen";
            // 
            // doc_asoc
            // 
            this.doc_asoc.HeaderText = "Con documento asociado";
            this.doc_asoc.Name = "doc_asoc";
            // 
            // Serie
            // 
            this.Serie.HeaderText = "Serie";
            this.Serie.Name = "Serie";
            // 
            // Folio
            // 
            this.Folio.HeaderText = "Folio";
            this.Folio.Name = "Folio";
            // 
            // total_doc
            // 
            this.total_doc.HeaderText = "Total del documento";
            this.total_doc.Name = "total_doc";
            // 
            // forma_envio
            // 
            this.forma_envio.HeaderText = "Forma de envio del documento";
            this.forma_envio.Name = "forma_envio";
            // 
            // OrdenesCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "OrdenesCompras";
            this.Text = "OrdenesCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref_prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_can;
        private System.Windows.Forms.DataGridViewTextBoxColumn Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_asoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn forma_envio;
    }
}