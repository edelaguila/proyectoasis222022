using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
namespace Vista
{

  

    public partial class Navegador : UserControl
    {
        public Navegador()
        {
            InitializeComponent();
        }
        public Form formulario = new Form();
        public DataGridView tabla;
        public Label ayudanumero;
        public TextBox ayuda;
        
        csControlador cn = new csControlador();
        public void cargar(DataGridView dtabla)
        {
            cn.llenartablaa(dtabla.Tag.ToString(), dtabla);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

           
            formulario.Show();
        }

        private void Navegador_Load(object sender, EventArgs e)
        {

           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            NavegadorI navi = new NavegadorI();
           navi.numeroform = cn.buscarposicion(tabla);
            //ayuda.Text = numero.ToString();
           
            MessageBox.Show(navi.numeroform.ToString());
            formulario.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int numero = cn.buscarposicion(tabla);
            ayudanumero.Tag = numero.ToString();
            formulario.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "b");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "s");
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "f");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "i");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            formulario.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}
