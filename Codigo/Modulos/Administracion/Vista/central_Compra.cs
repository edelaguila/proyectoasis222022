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
    public partial class central_Compra : Form
    {
        public central_Compra()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            //Metodo para cubrir los paneles
            panelCompras.Visible = false;
            panelClientes.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelCompras.Visible == true)
                panelCompras.Visible = false;
            if (panelClientes.Visible == true)
                panelClientes.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
            if (panel2.Visible == true)
                panel2.Visible = false;
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

        private void btnCompras_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCompras);
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formulario = new ComprasCompras();
            formulario.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnRecepción_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formRecepcionesCompras = new RecepcionesCompras();
            formRecepcionesCompras.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formOrdenesCompras = new OrdenesCompras();
            formOrdenesCompras.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnRequisiciones_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formRequisicionesCompras = new RequisicionesCompras();
            formRequisicionesCompras.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formReportesCompras = new ReportesCompras();
            formReportesCompras.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnComprobantesCompras_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formComprobantesCompras = new ComprobantesCompras();
            formComprobantesCompras.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientes);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formClientes = new ClienteClientes();
            formClientes.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnContactoClientes_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formContactoClientes = new ContactoClientes();
            formContactoClientes.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formCobrosDia = new CobrosDeDiaClientes();
            formCobrosDia.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnReporteCliente_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formReportesClientes = new ReporteClientesClientes();
            formReportesClientes.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnComprobantesClientes_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formComprobantesClientes = new ComprobantesClientes();
            formComprobantesClientes.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnMovimientosCLientes_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formMovClientes = new MovimientosClientes();
            formMovClientes.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnCajaClientes_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formProveedoresProveedores = new ProveedoresProveedores();
            formProveedoresProveedores.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnContactosProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formContactoProveedores = new ContactoProveedores();
            formContactoProveedores.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnPagosDia_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formPagosDiaProveedores = new PagosDiaProveedores();
            formPagosDiaProveedores.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnReportesProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formReporteProveedores = new ReporteProveedores();
            formReporteProveedores.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnComprobantesProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnMovimientosProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formMovimientosProveedores = new MovimientosProveedores();
            formMovimientosProveedores.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnCajaProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formFacturaVentas = new FacturaVentas();
            formFacturaVentas.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formPedidosVentas = new PedidosVentas();
            formPedidosVentas.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnDevolucionesVentas_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formDevolucionesVentas = new DevolucionesVentas();
            formDevolucionesVentas.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formCotizacionesVentas = new CotizacionesVentas();
            formCotizacionesVentas.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formVendedoresVentas = new VendedoresVentas();
            formVendedoresVentas.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formMovimientosVentas = new Pedidos();
            formMovimientosVentas.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formVentasVentas = new VentasVentas();
            formVentasVentas.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            Form formListadoPrecios = new ListadoPrecios();
            formListadoPrecios.ShowDialog();
            hideSubMenu();
        }
    }
}
