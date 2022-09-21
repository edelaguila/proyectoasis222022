using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo;

namespace Capa_Controlador
{
   public class csContralador
    {
        Sentencias sn = new Sentencias();


        public void actualizarConsultaa(string ntabla, string tabla)//Funcion para llenar tabla
        {
            OdbcDataAdapter dt = sn.actualizarConsulta(ntabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            tabla.DataSource = table;

        }
    }
}
