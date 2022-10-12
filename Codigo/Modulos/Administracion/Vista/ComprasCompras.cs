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
    public partial class ComprasCompras : Form
    {
        public ComprasCompras()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form formulario = new AgregarComprasCompras();
            formulario.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form formAgregarCompras = new AgregarComprasCompras();
            formAgregarCompras.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form formEliminarCompras = new EliminarComprasCompras();
            formEliminarCompras.ShowDialog();
        }
    }
}
