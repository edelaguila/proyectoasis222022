using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComprasControlador;


namespace ComprasVista
{

    public partial class AyudaCajaClientes : Form
    {

        csControladort cn = new csControladort();
        csContralador a = new csContralador();
        string table, ttipo;

        public AyudaCajaClientes(string tabla, string tipo)
        {
            InitializeComponent();
            table = tabla;
            ttipo = tipo;

        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (Dgv_ayudacajac.CurrentCell != null)
            {


                a.IDS = Dgv_ayudacajac.CurrentRow.Cells[0].Value.ToString();

                this.Close();

            }
        }

        /*private void AyudaCajaClientes_Load(object sender, EventArgs e)
        {
            if (table.Equals("tblcajaclientes"))
            {
                a.llenartablaaCajaClientes(Dgv_ayudacajac);

            }
            else
            {
                a.llenartablaaCajaClientes(table, Dgv_ayudacajac);
            }
        }*/
    }
}
