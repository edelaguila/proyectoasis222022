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
    public partial class ComprobantesCompras : Form
    {
        public ComprobantesCompras()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form formAgregarComprobantes = new AgregarComprobantesCompras();
            formAgregarComprobantes.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form formModComprobantes = new ModificarComprobantesCompras();
            formModComprobantes.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form formEliminarComprobantes = new EliminarComprobantesCompras();
            formEliminarComprobantes.ShowDialog();
        }
    }
}
