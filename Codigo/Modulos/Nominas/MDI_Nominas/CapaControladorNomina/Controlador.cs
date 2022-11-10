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

        public void llenarListPuestos(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListaPuesto(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void llenarListDepartamentos(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListaDepartamentos(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void llenarListPuestos2(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListaPuesto2(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void llenarListTrabajadores(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListaTrabajador(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void llenarListContrato(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListaContratos(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void llenarListTrabajadores2(string ntabla, DataGridView tabla)
        {
            OdbcDataAdapter dt = sn.llenarListaTrabajador2(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void ingresar(TextBox[] textbox, string tabla)
        {
            string dato = " ";
            string tipo = " ";

            for (int x = 0; x < textbox.Length; x++)
            {

                if (x == textbox.Length - 1)
                {
                    dato += "'" + textbox[x].Text + "'";
                    tipo += textbox[x].Tag.ToString();
                }
                else
                {
                    dato += "'" + textbox[x].Text + "',";
                    tipo += textbox[x].Tag.ToString() + ",";
                }

            }
            sn.insertar(dato, tipo, tabla);
        }

        public void llenarListAsignaciones(string ntabla, DataGridView tabla, string id)
        {
            OdbcDataAdapter dt = sn.llenarListaAsignaciones(ntabla, id);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;
        }

        public void eliminarAsiganaciones(string tabla, string condicion1, int campo1, string condicion2, int campo2)
        {
            try
            {
                sn.eliminarAsiganaciones(tabla, condicion1, campo1, condicion2, campo2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar por permisos asignados");
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }
        }
    }
}
