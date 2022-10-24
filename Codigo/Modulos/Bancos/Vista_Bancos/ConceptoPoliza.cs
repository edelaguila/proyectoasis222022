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
    public partial class ConceptoPoliza : Form
    {
        public ConceptoPoliza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imprimir frm_imp = new Imprimir();
            frm_imp.Show();
        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "7007";
            TextBox[] Grupotextbox = { txt_tipopoli, txt_clave, txt_despoli };
            TextBox[] Idtextbox = { txt_tipopoli, txt_clave };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_conceptopoliza");
        }
    }
}
