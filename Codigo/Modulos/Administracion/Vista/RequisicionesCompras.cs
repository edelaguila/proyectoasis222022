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
    public partial class RequisicionesCompras : Form
    {
        public RequisicionesCompras()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form formAgregarRequisicionesCompras = new AgregarRequisicionesCompras();
            formAgregarRequisicionesCompras.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form formEliminarRequisicionesCompras = new EliminarRequisicionesCompras();
            formEliminarRequisicionesCompras.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form formModRequisicionesCompras = new ModificarRequisicionesCompras();
            formModRequisicionesCompras.ShowDialog();
        }
    }
}
