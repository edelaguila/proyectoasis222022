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
    public partial class ClienteClientes : Form
    {
        public ClienteClientes()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form formAgregarClientes = new AgregarClientesClientes();
            formAgregarClientes.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form formEliminarClientes = new EliminarClientesClientes();
            formEliminarClientes.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form formModificarClientes = new ModificarClientesClientes();
            formModificarClientes.ShowDialog();
        }

        private void ClienteClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
