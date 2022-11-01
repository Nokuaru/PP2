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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            cargarCombobox();
            recargarProductos();

        }

        public void cargarCombobox()
        {
            Conexion con = new Conexion();
            string sqlProveedor = "SELECT RazonSocial from Proveedor";
            SqlCommand cmdProveedor = new SqlCommand(sqlProveedor, con.Conectar());
            using (SqlDataReader saReader = cmdProveedor.ExecuteReader())
            {
                while (saReader.Read())
                {
                    string name = saReader.GetString(0);
                    combProveedor.Items.Add(name);
                }
            }
            con.Desconectar();

            string sqlCategoria = "SELECT DescripcionCatProd from CategoriaProducto";
            SqlCommand cmdCategoria = new SqlCommand(sqlCategoria, con.Conectar());
            using (SqlDataReader saReader = cmdCategoria.ExecuteReader())
            {
                while (saReader.Read())
                {
                    string name = saReader.GetString(0);
                    combCategoria.Items.Add(name);
                }
            }
            con.Desconectar();
        }


        public void recargarProductos()
        {
            Conexion con = new Conexion();
            string sql = "SELECT * FROM V_Producto_Productos;";
            SqlCommand cmd = new SqlCommand(sql, con.Conectar());
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dtProducto = new DataTable();
            dtProducto.Load(dr);
            dgProductos.DataSource = dtProducto.DefaultView;
            con.Desconectar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            var categoria = getIDCategoria();
            var proveedor = getIDProveedor();
            //MessageBox.Show(categoria);
            //MessageBox.Show(proveedor);
            Conexion con = new Conexion();
            string nombre = txtNombre.Text;
            string cantidad = txtCantidad.Text;
            string preciocompra = txtPrecioCompra.Text;
            string precioventa = txtPrecioVenta.Text;
            string sql = "INSERT INTO Producto VALUES ('" + categoria + "'," + proveedor + ",'" + nombre + "'," + cantidad + "," + preciocompra + "," + precioventa + ")";
            SqlCommand cmd = new SqlCommand(sql, con.Conectar());
            cmd.ExecuteNonQuery();
            con.Desconectar();
            recargarProductos();

        }



        public string getIDCategoria()
        {
            Conexion con = new Conexion();
            string sql = "SELECT * FROM CategoriaProducto WHERE DescripcionCatProd = '" + combCategoria.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, con.Conectar());
            DataTable resultado = new DataTable();

            using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                resultado.Load(reader);
                var guardarCategoria = resultado.Rows[0][0].ToString();
                return guardarCategoria;
            }
            
        }

        public string getIDProveedor()
        {
            Conexion con = new Conexion();
            string sql = "SELECT * FROM Proveedor WHERE RazonSocial = '" + combProveedor.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, con.Conectar());
            DataTable resultado = new DataTable();
            using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                resultado.Load(reader);
                string guardarProveedor = resultado.Rows[0][0].ToString();
                return guardarProveedor;
            }



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (combCategoria.Text == "Categoria")
            {
                combCategoria.Text = "";
                Conexion con = new Conexion();
                string sql = "SELECT * FROM V_Producto_Productos WHERE Nombre like \'%" + txtNombre.Text + "%\' AND [Tipo de Producto] like \'%" + combCategoria.Text + "%\';";
                SqlCommand cmd = new SqlCommand(sql, con.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dtProducto = new DataTable();
                dtProducto.Load(dr);
                dgProductos.DataSource = dtProducto.DefaultView;
                combCategoria.Text = "Categoria";

            } else { 

            Conexion con = new Conexion();
            string sql = "SELECT * FROM V_Producto_Productos WHERE Nombre like \'%" + txtNombre.Text + "%\' AND [Tipo de Producto] like \'%" + combCategoria.Text +"%\' AND Proveedor like \'%" + combProveedor.Text +"%\';";
            SqlCommand cmd = new SqlCommand(sql, con.Conectar());
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dtProducto = new DataTable();
            dtProducto.Load(dr);
            dgProductos.DataSource = dtProducto.DefaultView;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            combCategoria.SelectedIndex = -1;
            combProveedor.SelectedIndex = -1;
        }
    }
}
