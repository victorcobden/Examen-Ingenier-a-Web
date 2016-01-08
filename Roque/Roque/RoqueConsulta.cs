using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Roque
{
    public class RoqueConsulta
    {
        conexion cn = new conexion();
        //Metodo extraerdatos
        public DataTable extraerdatos(string nombresp)
        {
            //Llama a un SP que requiere un parametro de tipo string
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.desconectar();
            //Devuelve un dataTable
            return dt;
        }
        public DataTable extraerdatos(string nombresp, string nom_param1, string val_param1, string nom_param2, double val_param2, string nom_param3, double val_param3)
        {
            //Llama a un SP que requiere un parametro de tipo string
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add(nom_param1, SqlDbType.Int).Value = val_param1;
            da.SelectCommand.Parameters.Add(nom_param2, SqlDbType.Money).Value = val_param2;
            da.SelectCommand.Parameters.Add(nom_param3, SqlDbType.Money).Value = val_param3;
            
            da.Fill(dt);
            cn.desconectar();
            //Devuelve un dataTable
            return dt;
        }
        public DataTable extraerdatos(string nombresp, string nom_param1, string val_param1)
        {
            //Llama a un SP que requiere un parametro de tipo string
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = cn.sqlcad;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cn.conectar();
            da.SelectCommand = cmd;
            da.SelectCommand.Parameters.Add(nom_param1, SqlDbType.Int).Value = val_param1;
            da.Fill(dt);
            cn.desconectar();
            //Devuelve un dataTable
            return dt;
        }
    }
}