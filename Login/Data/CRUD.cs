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
                string sql = "SELECT * FROM Producto;";
                SqlCommand cmd = new SqlCommand(sql, con.Conectar());
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dtProducto = new DataTable();
                dtProducto.Load(dr);
                con.Desconectar();
                return dtProducto;

            } catch (Exception ex)
            {
                return null;
            }
        }
    }
}
