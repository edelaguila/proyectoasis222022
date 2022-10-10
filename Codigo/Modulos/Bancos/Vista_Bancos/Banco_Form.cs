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
    public partial class Banco_Form : Form
    {
        public Banco_Form()
        {
            InitializeComponent();
            HideStart();
        }
        private void HideStart()
        {
            //Metodo para cubrir los paneles
            panelConceptosBanc.Visible = false;
            panelPartidasCont.Visible = false;
            panelMantenimientos.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelConceptosBanc.Visible == true)
                panelConceptosBanc.Visible = false;
            if (panelPartidasCont.Visible == true)
                panelPartidasCont.Visible = false;
            if (panelMantenimientos.Visible == true)
                panelMantenimientos.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }
        private void Banco_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMantenimientos);
        }

        private void btnConceptosBanc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelConceptosBanc);
        }

        private void btnPartidasCont_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPartidasCont);
        }

        private void btnCheques_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Cheque frm_cheque = Cheque.ventana_unica();
            frm_cheque.MdiParent = this;
            frm_cheque.Show();
            logop.Visible = false;
        }

        private void btnDepositos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnNC_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnMovBanc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnTipoDeCambio_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPolizas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Polizas pol = new Polizas();
            pol.MdiParent = this;
            pol.Show();
            logop.Visible = false;
        }

        private void btnIngresosEgresos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnRepBanc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnBancos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            MantBancos frm_mtbancos = new MantBancos();
            frm_mtbancos.MdiParent = this;
            frm_mtbancos.Show();
            logop.Visible = false;
        }

        private void btnCuentasBanc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            MntCuentas frm_cuentas = new MntCuentas();
            frm_cuentas.MdiParent = this;
            frm_cuentas.Show();
            logop.Visible = false;
        }
    }
}
