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

        public OdbcDataAdapter llenarTblCustom(string tabla, string clausula)//Leonel Dominguez
        {
            string sql = "SELECT * FROM " + tabla + " WHERE "+ clausula +";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public string[] Query(string campoSolicitado, string tabla, string clausula)//Leonel Dominguez
        {
            string[] respuesta = new string[100];
            string sql = "SELECT "+campoSolicitado+ " FROM colchoneria." + tabla+ " WHERE "+clausula+";";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                Array.Resize(ref respuesta, reader.FieldCount);
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        respuesta[i] = reader.GetValue(i).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() +
                    " \n Error en query hacia la tabla de " + tabla);
            }
            return respuesta;
        }

        public string[] Select(string campoSolicitado, string tabla)//Leonel Dominguez
        {
            string[] respuesta = new string[100];
            string sql = "SELECT " + campoSolicitado + " FROM " + tabla + ";";
            int j = 0;
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        respuesta[j] = reader.GetValue(i).ToString();
                        j++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() +
                    " \n Error en SELECT hacia la tabla de " + tabla);
            }

            Array.Resize(ref respuesta, j);
            return respuesta;
        }

        public Boolean Insert(string campos, string tabla, string datos)//Leonel Dominguez
        {
            Boolean respuesta = false;
            string sql = "INSERT INTO "+ tabla + " (" + campos + ") values (" + datos + ");";
            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            try
            {
                command.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception ex)
            {
                respuesta = false;
                Console.WriteLine(ex.Message.ToString() +
                    " \n Error en guardar registro en "+ tabla);   
            }
            return respuesta;
        }

        public Boolean Delete(string tabla, string clausula)//Leonel Dominguez
        {
            Boolean respuesta = false;
            string sql = "DELETE FROM "+ tabla +" WHERE "+ clausula +";";
            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            try
            {
                command.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception ex)
            {
                respuesta = false;
                Console.WriteLine(ex.Message.ToString() +
                    " \n Error en guardar registro en " + tabla);
            }
            return respuesta;
        }

        public int CountQuery(string tabla, string clausulas)
        {
            string sql = "SELECT COUNT(*) FROM colchoneria." + tabla +" WHERE "+ clausulas +";";
            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count;
        }

    }
}
