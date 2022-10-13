using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador_Bancos;


namespace Vista_Bancos
{
    public partial class Cheque : Form
    {
        Convertir con = new Convertir();
        private static Cheque instancia = null;
        
        public static Cheque ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new Cheque();
                return instancia;
            }
            return instancia;
        }
        public Cheque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_montoLetras.Text = con.enletras(txt_Monto.Text).ToUpper();
        }
    }
}
