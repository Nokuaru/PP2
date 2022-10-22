using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Data;

namespace Login.Data
{
    internal class CRUD
    {
        public static DataTable cargar()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM Productos;";
                SqlCommand cmd = new SqlCommand(sql, con.Conectar());
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Desconectar();
                return dt;

            } catch (Exception ex)
            {
                return null;
            }
        }
    }
}
