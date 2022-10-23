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
    public partial class ConceptoBancario : Form
    {
        public ConceptoBancario()
        {
            InitializeComponent();
        }

        private void ConceptoBancario_Load(object sender, EventArgs e)
        {

            
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(comboBox1.SelectedItem);
            textBox5.Text = Convert.ToString(comboBox2.SelectedItem);
            NavegadorVista.Navegador.idApp = "7004";
            TextBox[] Grupotextbox = { textBox1,textBox2,textBox3,textBox4,textBox5};
            TextBox[] Idtextbox = { textBox1, textBox2 };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_conceptosbancario");
        }
    }
}
