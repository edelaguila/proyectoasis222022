using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_Bancos
{
    public partial class NuevaPoliza : Form
    {
        public NuevaPoliza()
        {
            InitializeComponent();
        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "7008";
            TextBox[] Grupotextbox = { txt_descpoli,txt_nopoli };
            TextBox[] Idtextbox = { txt_descpoli, txt_nopoli };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_polizasbancarias");
        }

    }
}
