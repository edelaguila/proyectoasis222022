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
    public partial class NavegadorI : UserControl
    {
        public NavegadorI()
        {
            InitializeComponent();

        }
        csControlador cn = new csControlador();
        public TextBox[] textbox = { };
        public TextBox[] textboxi = { };
        public DataGridView tabla;
        public Form formulario = new Form();
        int opcion;

        public int numeroform;
        Navegador nav = new Navegador();
        public void cargar(DataGridView dtabla, Form actual)
        {
            
            MessageBox.Show(numeroform.ToString());
            cn.evaluartags(textbox, dtabla, "controlempleados", actual);
            cn.llenartablaa(dtabla.Tag.ToString(), dtabla, numeroform, textbox);
                
        }
      
        private void NavegadorI_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(nav.ayudanumero.ToString());
            cn.llenartablaa(tabla.Tag.ToString(), tabla, numeroform, textbox);
            cn.enfocar(textboxi);
            opcion = 2;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            cn.llenartxt(textbox, tabla); 
            cn.crearid(textboxi, tabla);
            opcion = 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(nav.ayudanumero.ToString());
            cn.llenartablaa(tabla.Tag.ToString(), tabla, numero, textbox);
            cn.enfocar(textboxi);
            opcion = 3;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "b");
            cn.llenartxt(textbox, tabla);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "s");
            cn.llenartxt(textbox, tabla);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "i");
            cn.llenartxt(textbox, tabla);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            cn.moverseIF(tabla, "f");
            cn.llenartxt(textbox, tabla);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            formulario.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cn.desactivar(this);
            cn.limpiar(this);

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (opcion == 1)
            {
                cn.ingresar(textbox, tabla);
            }
            else if (opcion == 2)
            {
                cn.actualizar(textbox, tabla);
            }
            else if (opcion == 3)
            {
                cn.delete(textbox, tabla);
            }
        }
    }
}
