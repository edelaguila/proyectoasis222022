using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo
{
  public class Sentencias
    {
        Conexion con = new Conexion();
        public void actualizarConsulta(int _pk_Id_Nombre_Consulta, string _nombre_Consulta, string _nombre_Campo, string _alias, string _nombre_Tabla)

        {
            string sql = @"Update colchoneria.ConsultaInteligente set nombre_Consulta='_nombre_Consulta',  nombre_Tabla='_nombre_Tabla',
                            nombre_Campo='_nombre_Campo',alias = '_alias' where pk_Id_Nombre_Consulta = '_pk_Id_Nombre_Consulta'";

            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@pk_Id_Nombre_Consulta", OdbcType.Int).Value = _pk_Id_Nombre_Consulta;
            cmd.Parameters.Add("@nombre_Consulta", OdbcType.VarChar).Value = _nombre_Consulta;
            cmd.Parameters.Add("@nombre_Campo", OdbcType.VarChar).Value = _nombre_Campo;
            cmd.Parameters.Add("@nombre_Tabla", OdbcType.VarChar).Value = _nombre_Tabla;
            cmd.Parameters.Add("@alias", OdbcType.VarChar).Value = _alias;
        }

        public void actualizarLogico(int _pk_Id_Logico, string _nombre_Logico, string _valor_Logico, string _nombre_Campo)
        {
            string sql = @"Update colchoneria.Logico set pk_Id_Logico='_pk_Id_Logico',  nombre_Logico='_nombre_Logico',
                            valor_Logico='_valor_Logico' where pk_Id_Logico = '_pk_Id_Logico'";

            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@pk_Id_Logico", OdbcType.Int).Value = _pk_Id_Logico;
            cmd.Parameters.Add("@nombre_Logico", OdbcType.VarChar).Value = _nombre_Logico;
            cmd.Parameters.Add("@valor_Logico", OdbcType.VarChar).Value = _valor_Logico;
            cmd.Parameters.Add("@nombre_Campo", OdbcType.VarChar).Value = _nombre_Campo;
        }

        public void actualizarComparador(int pk_Id_Comparador, string _nombre_Comparador, string _valor_Comparador, string _nombre_Campo)
        {
            string sql = @"Update colchoneria.Comparador set pk_Id_Comparador='_pk_Id_Comparador',nombre_Comparador='_nombre_Comparador', nombre_Campo='_nombre_Campo',
                            valor_Comparador='_valor_Comparador' where pk_Id_Comparador = '_pk_Id_Comparador'";

            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@pk_Id_Comparador", OdbcType.Int).Value = pk_Id_Comparador;
            cmd.Parameters.Add("@nombre_Comparador", OdbcType.VarChar).Value = _nombre_Comparador;
            cmd.Parameters.Add("@valor_Comparador", OdbcType.VarChar).Value = _valor_Comparador;
            cmd.Parameters.Add("@nombre_Campo", OdbcType.VarChar).Value = _nombre_Campo;
        }

        public void actualizarAgruparOrdenar(int _pk_Id_Agrupar_Ordenar, string _nombre_Orden, string _valor_Comparador, string _nombre_Campo)
        {
            string sql = @"Update colchoneria.AgruparOrdenar set pk_Id_Agrupar_Ordenar='_pk_Id_Agrupar_Ordenar',nombre_Orden='_nombre_Orden', nombre_Campo='_nombre_Campo',
                            valor_Comparador='_valor_Comparador' where pk_Id_Agrupar_Ordenar = '_pk_Id_Agrupar_Ordenar'";

            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            cmd.ExecuteNonQuery();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@pk_Id_Agrupar_Ordenar", OdbcType.Int).Value = _pk_Id_Agrupar_Ordenar;
            cmd.Parameters.Add("@nombre_Orden", OdbcType.VarChar).Value = _nombre_Orden;
            cmd.Parameters.Add("@valor_Comparador", OdbcType.VarChar).Value = _valor_Comparador;
            cmd.Parameters.Add("@nombre_Campo", OdbcType.VarChar).Value = _nombre_Campo;
        }
    }
}
