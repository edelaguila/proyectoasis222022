using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModuloNomina
{
    public class Sentencias
    {

        Conexion con = new Conexion();

        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarListaPuesto(string tabla)
        {
            string sql = "select  pk_id_puesto as ID, nombre_puesto AS Puesto, estado_puesto as Estado from tbl_puestosdetrabajo where estado_puesto != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
        public OdbcDataAdapter llenarListaDepartamentos(string tabla)
        {
            string sql = "select pk_id_departamento as ID, nombre_departamento AS Departamento, descripcion_departamento as Descripcion from tbl_departamentos where estado_departamento != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenarListaPuesto2(string tabla)
        {
            string sql = "select  pk_id_puesto as ID, nombre_puesto AS Puesto, estado_puesto as Estado from tbl_puestosdetrabajo where estado_puesto != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenarListaTrabajador(string tabla)
        {
            string sql = "select pk_id_trabajador as ID, nombre_trabajador AS Trabajador, estado_trabajador AS Estado from tbl_trabajador where estado_trabajador != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenarListaContratos(string tabla)
        {
            string sql = "select  pk_id_contrato as ID, tipoPago_contrato AS TipoContrato, estado_contrato as Estado from tbl_contrato where estado_contrato != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenarListaTrabajador2(string tabla)
        {
            string sql = "select pk_id_trabajador as ID, nombre_trabajador AS Trabajador, estado_trabajador AS Estado from tbl_trabajador where estado_trabajador != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public void insertar(string dato, string tipo, string tabla)
        {
            string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
            try
            {

                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener");
            }
        }

        public OdbcDataAdapter llenarListaAsignaciones(string tabla, string id)
        {
            string sql = "Select *from " + tabla + " where ID = " + id + " ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public void eliminarAsiganaciones(string tabla, string condicion1, int campo1, string condicion2, int campo2)
        {
            try
            {
                string sql = "DELETE FROM " + tabla + " where (" + condicion1 + " = " + campo1 + ") and (" + condicion2 + " =" + campo2 + ");";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }
        }

        public OdbcDataAdapter llenarListas(string tabla)
        {
            string sql = "select  *from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenarListContratos(string tabla)
        {
            string sql = "select pk_id_contrato as Contrato , salario_contrato as Salario  from tbl_contrato where estado_contrato != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
    }
}
