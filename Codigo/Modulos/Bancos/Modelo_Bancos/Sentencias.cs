using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
namespace Modelo_Bancos
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        public OdbcDataAdapter llenartabla(string tabla)
        {


            string sql = "select * from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());

            return datatable;
        }
        public OdbcDataAdapter bitacora(string tabla)
        {


            string sql = "select * from " + tabla + " where fk_id_aplicacion between 7000 and 7999 ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());

            return datatable;
        }

    }
}
