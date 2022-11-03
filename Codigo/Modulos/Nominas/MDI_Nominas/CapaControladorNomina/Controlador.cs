using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModuloNomina;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControladorNomina
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTablaQuery(string tabla, string clausulas)
        {
            OdbcDataAdapter dt = sn.llenarTblCustom(tabla, clausulas);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void selectContratos(ComboBox combobox)
        {
            string campos = "pk_id_contrato, estado_contrato";
            string tabla = "tbl_contrato";
            string[] data = sn.Select(campos, tabla);

            if (data.Length > 0)
            {
                for (int i = 0; i < data.Length; i = i + 2)
                {
                    if (data[i + 1].Equals("1"))
                    {
                        combobox.Items.Add(data[i]);
                    }
                }
            }
        }

        public void queryContrato(string idContrato, TextBox[] textboxs)
        {
            string campos = "salario_contrato";
            string tabla = "tbl_contrato";
            string clausula = "pk_id_contrato = " + idContrato;
            string[] data = sn.Query(campos, tabla, clausula);

            if (data.Length > 0)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    textboxs[i].Text = data[i];
                }
            }
        }

        public void asignarContratoPercepcion(string datos)
        {
            string campos = "fk_id_contrato, fk_id_prestdeduc";
            string tabla = "tbl_asignacion_contratopercepciones";
            if(!sn.Insert(campos, tabla, datos))
            {
                MessageBox.Show("NO SE PUDO REGISTRAR LA ASIGNACIÓN");
            }
        }

        public Boolean validarRegistro(string contrato, string percepcion)
        {
            Boolean respuesta = false;
            string tabla = "tbl_asignacion_contratopercepciones";
            string clausula = "fk_id_contrato=" + contrato + " AND fk_id_prestdeduc=" + percepcion;

            respuesta = sn.CountQuery(tabla, clausula) == 0 ?  true : false;

            return respuesta;
        }

        public Boolean validarReporte(string idApp)
        {
            Boolean respuesta = false;
            string tabla = "tbl_regreporteria";
            string clausula = "aplicacion='" + idApp + "' AND estado='Visible'";
            respuesta = sn.CountQuery(tabla, clausula) == 0 ? false : true;
            return respuesta;
        }
        public string buscarPathReporte(string idApp)
        {
            string path = "";
            string campos = "ruta";
            string tabla = "tbl_regreporteria";
            string clausula = "aplicacion='" + idApp +"'";
            string[] data = sn.Query(campos, tabla, clausula);
            return path = data[0];
        }

        public void eliminarContratoPercepcion(string contrato, string percepcion)
        {
            string tabla = "tbl_asignacion_contratopercepciones";
            string clausula = "fk_id_contrato=" + contrato + " AND fk_id_prestdeduc=" + percepcion;
            if (!sn.Delete(tabla, clausula))
            {
                MessageBox.Show("NO SE PUDO ELIMINADA LA ASIGNACIÓN");
            }
        }

        public void EditarTabla(string[] columnas, int[] tamaño, DataGridView tabla)//LEONEL DOMINGUEZ
        {
            for (int i = 0; i < tabla.ColumnCount; i++)
            {
                tabla.Columns[i].HeaderText = columnas[i];
                tabla.Columns[i].Width = tamaño[i];
                tabla.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            tabla.RowHeadersVisible = false;
        }

    }
}
