using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class RecepcionesCompras : Form
    {
        public RecepcionesCompras()
        {
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form formAgregarRecepciones = new Agregar_RececpcionesCompras();
            formAgregarRecepciones.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form formModRecepciones = new Modificar_RecepcionesCompras();
            formModRecepciones.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form formEliminarRecepciones = new EliminarRecepcionesCompras();
            formEliminarRecepciones.ShowDialog();
        }
    }
}
