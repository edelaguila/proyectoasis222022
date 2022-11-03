using System;
using System.Windows.Forms;

namespace CapaVistaNomina
{
    public partial class AsignacionContratoPestaciones : Form
    {
        CapaControladorNomina.Controlador controladorNomina = new CapaControladorNomina.Controlador();
        Seguridad_Controlador.Controlador controladorSeguridad = new Seguridad_Controlador.Controlador();
        public AsignacionContratoPestaciones()
        {
            InitializeComponent();
            asignarPermisos();
            txt_idContrato.Items.Add("Seleccione una opcion...");
            controladorNomina.selectContratos(txt_idContrato);
            tbl_percepciones.DataSource = controladorNomina.llenarTablaQuery("tbl_percepciones", "estado_prestdeduc = " + 1);
            diseñoTabla();
            
        }

        private void diseñoTabla()
        {
            string[] columnas = { "ID", "NOMBRE", "TIPO", "PORCENTAJE", "CANTIDAD FIJA", "ESTADO" };
            int[] tamanio = { 40, 250, 50, 100, 100, 65 };
            controladorNomina.EditarTabla(columnas, tamanio, tbl_percepciones);
        }
        private void diseñoTabla2()
        {
            string[] columnas = { "ID CONTRATO", "ID PERCEPCION" };
            int[] tamanio = { 100, 100 };
            controladorNomina.EditarTabla(columnas, tamanio, tbl_asignacion_contratopercepciones);
        }
        private void asignarPermisos()
        {
            btn_buscarContrato.Enabled = false;
            btn_asignarUU.Enabled = false;
            btn_asignarUT.Enabled = false;
            btn_quitarUU.Enabled = false;
            btn_quitarUT.Enabled = false;

            int[] permisos = controladorSeguridad.getPermisosAplicaion("6104");
            if (permisos[0] == 1)//Guardar
            {
                btn_buscarContrato.Enabled = true;
                btn_asignarUU.Enabled = true;
                btn_asignarUT.Enabled = true;
            }
            if (permisos[1] == 1)//Modifcar
            {

            }
            if (permisos[2] == 1)//Eliminar
            {
                btn_buscarContrato.Enabled = true;
                btn_quitarUU.Enabled = true;
                btn_quitarUT.Enabled = true;
            }
            if (permisos[3] == 1)//Consultar
            {

            }
            if (permisos[4] == 1)//Reportes
            {

            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            TextBox[] textboxs = { txtCadenas };
            if (txt_idContrato.SelectedIndex > 0)
            {
                controladorNomina.queryContrato(txt_idContrato.Text, textboxs);
                tbl_asignacion_contratopercepciones.DataSource = controladorNomina.llenarTablaQuery("tbl_asignacion_contratopercepciones", "fk_id_contrato = " + txt_idContrato.Text);
                diseñoTabla2();
                txt_idContrato.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCadenas.Text.Length != 0)
            {
                if (tbl_percepciones.RowCount > 0)
                {
                    if (controladorNomina.validarRegistro(txt_idContrato.Text, tbl_percepciones.CurrentRow.Cells[0].Value.ToString()))
                    {
                        controladorNomina.asignarContratoPercepcion(txt_idContrato.Text + "," + tbl_percepciones.CurrentRow.Cells[0].Value.ToString());
                        tbl_asignacion_contratopercepciones.DataSource = controladorNomina.llenarTablaQuery("tbl_asignacion_contratopercepciones", "fk_id_contrato = " + txt_idContrato.Text);
                        diseñoTabla2();
                    }
                    else
                    {
                        MessageBox.Show("ASIGNACIÓN YA EXISTE");
                    }
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios, seleccione un contrato");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtCadenas.Text.Length != 0)
            {
                if (tbl_asignacion_contratopercepciones.RowCount > 0)
                {
                    controladorNomina.eliminarContratoPercepcion(txt_idContrato.Text, tbl_asignacion_contratopercepciones.CurrentRow.Cells[1].Value.ToString());
                    tbl_asignacion_contratopercepciones.DataSource = controladorNomina.llenarTablaQuery("tbl_asignacion_contratopercepciones", "fk_id_contrato = " + txt_idContrato.Text);
                    diseñoTabla2();
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios, seleccione un contrato");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_idContrato.Enabled = true;
            txtCadenas.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCadenas.Text.Length != 0)
            {
                foreach (DataGridViewRow fila in tbl_percepciones.Rows)
                {
                    DataGridViewCell columna1 = fila.Cells[0];
                    if (controladorNomina.validarRegistro(txt_idContrato.Text, columna1.Value.ToString()))
                    {
                        controladorNomina.asignarContratoPercepcion(txt_idContrato.Text + "," + columna1.Value.ToString());
                        tbl_asignacion_contratopercepciones.DataSource = controladorNomina.llenarTablaQuery("tbl_asignacion_contratopercepciones", "fk_id_contrato = " + txt_idContrato.Text);
                        diseñoTabla2();
                    }
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios, seleccione un contrato");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtCadenas.Text.Length != 0)
            {
                foreach (DataGridViewRow fila in tbl_asignacion_contratopercepciones.Rows)
                {
                    DataGridViewCell columna1 = fila.Cells[1];
                    controladorNomina.eliminarContratoPercepcion(txt_idContrato.Text, columna1.Value.ToString());
                }
                tbl_asignacion_contratopercepciones.DataSource = controladorNomina.llenarTablaQuery("tbl_asignacion_contratopercepciones", "fk_id_contrato = " + txt_idContrato.Text);
                diseñoTabla2();
            }
            else
            {
                MessageBox.Show("Existen campos vacios, seleccione un contrato");
            }
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {

        }
    }
}
