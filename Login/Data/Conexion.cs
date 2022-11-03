using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Login.Data
{
    internal class Conexion
    {
        SqlConnection con;

        public Conexion()
        {
            con = new SqlConnection(@"Data Source = PTMNTB0117\INSTANCIAGOLARTE; Initial Catalog = Grupo42; Integrated Security = True");
        }

        public SqlConnection Conectar()
        {
            try
            {
                con.Open();
                return con;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool Desconectar()
        {
            try
            {
                con.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
