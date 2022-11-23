using Login.Data;
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
    }
}
