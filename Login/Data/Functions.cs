using Login.Data;
using System.Data;
using System.Data.SqlClient;

namespace Login.Data
{
    public class prodFunctions
    {
        public static decimal getVentaTotal()
        {
            Conexion con = new Conexion();
            string sqlProcVentaTotal = "EXEC ProcVentaTotal";
            SqlCommand cmdSqlProcVentaTotal = new SqlCommand(sqlProcVentaTotal, con.Conectar());
            using (SqlDataReader saReader = cmdSqlProcVentaTotal.ExecuteReader())
                if (saReader.Read())
                {
                    decimal decimVentaTotal = saReader.GetDecimal(0);
                    //decimal ventaTotal = getVentaTotal();
                    //procVenta.Text = "$" + ventaTotal.ToString();
                    con.Desconectar();
                    return decimVentaTotal;

                }
                else
                {
                    con.Desconectar();
                    return 0;
                }


           
        }
        public static string getIdUsuarioActivo()
        {
            string sql = "Select concat(Nombre,' ', Apellido)  from Usuario where ACTIVO = 1";
            string returnValue = "";
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand(sql, con.Conectar());
                DataTable resultado = new DataTable();
                using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    resultado.Load(reader);
                    returnValue = resultado.Rows[0][0].ToString();
                    con.Desconectar();

                    return returnValue;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener el usuario activo.\n" + ex);
                throw;
            }

        }
    }
}
