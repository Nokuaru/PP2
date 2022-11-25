using Login.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            Conexion con = new Conexion();
            string sql = "SELECT * FROM V_Producto_Productos;";
            SqlCommand cmd = new SqlCommand(sql, con.Conectar());
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dtProducto = new DataTable();
            dtProducto.Load(dr);
            dgProductos.DataSource = dtProducto.DefaultView;
            sql = "SELECT * FROM V_Venta_ListadoVentas ORDER BY Fecha DESC;";
            cmd = new SqlCommand(sql, con.Conectar());
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dtVenta = new DataTable();
            dtVenta.Load(dr);
            dgVenta.DataSource = dtVenta.DefaultView;
            con.Desconectar();

        }


    }
}
