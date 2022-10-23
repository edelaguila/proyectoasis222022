
namespace ComprasVista
{
    partial class Caja_Clientes
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
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_CajaClientes = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CajaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.navegador1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 181);
            this.panel1.TabIndex = 12;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(142, 255);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(260, 20);
            this.txtIdCliente.TabIndex = 37;
            this.txtIdCliente.Tag = "FkId_Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Id_Cliente";
            // 
            // txtIdCaja
            // 
            this.txtIdCaja.Location = new System.Drawing.Point(142, 202);
            this.txtIdCaja.Name = "txtIdCaja";
            this.txtIdCaja.Size = new System.Drawing.Size(260, 20);
            this.txtIdCaja.TabIndex = 31;
            this.txtIdCaja.Tag = "PkId_CajaClientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Id_Caja";
            // 
            // Dgv_CajaClientes
            // 
            this.Dgv_CajaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CajaClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_CajaClientes.Location = new System.Drawing.Point(0, 300);
            this.Dgv_CajaClientes.Name = "Dgv_CajaClientes";
            this.Dgv_CajaClientes.Size = new System.Drawing.Size(884, 261);
            this.Dgv_CajaClientes.TabIndex = 38;
            this.Dgv_CajaClientes.Tag = "tblcajaclientes";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(144, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(610, 169);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(552, 193);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(257, 20);
            this.txtSaldo.TabIndex = 40;
            this.txtSaldo.Tag = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Saldo";
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(552, 250);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(257, 20);
            this.txtAbono.TabIndex = 42;
            this.txtAbono.Tag = "Abono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Abono";
            // 
            // Caja_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dgv_CajaClientes);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdCaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Caja_Clientes";
            this.Text = "Caja_Clientes";
            this.Load += new System.EventHandler(this.Caja_Clientes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CajaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdCaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_CajaClientes;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label label3;
    }
}