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
    public partial class ContactoClientes : Form
    {
        public ContactoClientes()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form formEliminarContacto = new EliminarContactoClientes();
            formEliminarContacto.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form formModificarContacto = new ModificarContactoClientes();
            formModificarContacto.ShowDialog();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form formAgregarContacto = new AgregarContactoClientes();
            formAgregarContacto.ShowDialog();
        }
    }
}
