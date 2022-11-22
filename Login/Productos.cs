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
            //MessageBox.Show(categoria);
            //MessageBox.Show(proveedor);
            agregarProducto();
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

        public void agregarProducto()
        {
            if (txtID.Text == "")
            {

                try
                {


                    if (txtNombre.Text != null && txtCantidad.Text != null && txtPrecioCompra.Text != null && txtPrecioCompra.Text != null && txtPrecioVenta.Text != null)
                    {
                        Conexion con = new Conexion();
                        var categoria = getIDCategoria();
                        var proveedor = getIDProveedor();
                        string nombre = txtNombre.Text;
                        string cantidad = txtCantidad.Text;
                        string preciocompra = txtPrecioCompra.Text;
                        string precioventa = txtPrecioVenta.Text;
                        string sql = "INSERT INTO Producto VALUES ('" + categoria + "'," + proveedor + ",'" + nombre + "'," + cantidad + "," + preciocompra + "," + precioventa + ")";
                        SqlCommand cmd = new SqlCommand(sql, con.Conectar());
                        cmd.ExecuteNonQuery();
                        con.Desconectar();
                        recargarProductos();
                        resetearCamposProductos();
                    }
                    else
                        MessageBox.Show("Debe completar todos los datos para agregar un nuevo producto", "Error");



                }
                catch

                {
                    MessageBox.Show("Debe completar todos los datos par agregar un nuevo producto", "Categoría vacía");
                }
            }

            else

            {
                try

                {

                    if (txtNombre.Text != null && txtCantidad.Text != null && txtPrecioCompra.Text != null && txtPrecioCompra.Text != null && txtPrecioVenta.Text != null)
                    {
                        string idCategoria = getIDCategoria();
                        string idProveedor = getIDProveedor();

                        Conexion con = new Conexion();
                        var categoria = getIDCategoria();
                        var proveedor = getIDProveedor();
                        string nombre = txtNombre.Text;
                        string cantidad = txtCantidad.Text;
                        string preciocompra = txtPrecioCompra.Text;
                        string precioventa = txtPrecioVenta.Text;
                        string idproducto = txtID.Text;
                        string sql = "UPDATE Producto SET idCategoria='" + idCategoria + "',idProveedor='" + idProveedor + "',Nombre='" + nombre + "',Cantidad='" + cantidad + "',PrecioUnitarioCompra='" + preciocompra + "',PrecioUnitarioVenta='" + precioventa + "'    WHERE idProducto='" + idproducto + "'";
                        SqlCommand cmd = new SqlCommand(sql, con.Conectar());
                        cmd.ExecuteNonQuery();
                        con.Desconectar();
                        recargarProductos();
                        resetearCamposProductos();
                    }
                    else
                        MessageBox.Show("Debe completar todos los datos para modificar el producto con ID "+txtID, "Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

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
                string sql = "SELECT * FROM V_Producto_Productos WHERE Nombre like \'%" + txtNombre.Text + "%\' AND [Tipo de Producto] like \'%" + combCategoria.Text + "%\' AND Proveedor like \'%" + combProveedor.Text + "%\';";
                SqlCommand cmd = new SqlCommand(sql, con.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dtProducto = new DataTable();
                dtProducto.Load(dr);
                dgProductos.DataSource = dtProducto.DefaultView;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetearCamposProductos();
        }
    

        private void resetearCamposProductos()
        {
                txtNombre.Text = "";
                txtCantidad.Text = "";
                txtPrecioCompra.Text = "";
                txtPrecioVenta.Text = "";
                combCategoria.SelectedIndex = -1;
                combProveedor.SelectedIndex = -1;
                txtID.Text = null;
            }



        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProductos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if ((MessageBox.Show("¿Está seguro que quiere eliminar este registro?", "IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    int rowIndex = dgProductos.CurrentRow.Index;
                    //MessageBox.Show(rowIndex.ToString());
                    //string columnName = dgProductos.Columns[2].Name;
                    string idNumber = dgProductos[2, rowIndex].Value.ToString();
                    //MessageBox.Show(cellValue);

                    try { 
                    Conexion con = new Conexion();
                    string sql = "DELETE FROM PRODUCTO WHERE idProducto = '"+idNumber+ "';";
                    SqlCommand cmd = new SqlCommand(sql, con.Conectar());
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    recargarProductos();
                    resetearCamposProductos();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pueden eliminar productos con ventas asociadas");
                    }


                }
            }

            if (dgProductos.Columns[e.ColumnIndex].Name == "Editar")
            {
                    int rowIndex = dgProductos.CurrentRow.Index;
                    //MessageBox.Show(rowIndex.ToString());
                    //string columnName = dgProductos.Columns[2].Name;
                    string idNumber = dgProductos[2, rowIndex].Value.ToString();
                    //MessageBox.Show(cellValue);

                    try
                    {
                    txtNombre.Text = dgProductos[4, rowIndex].Value.ToString();
                    txtCantidad.Text = dgProductos[6, rowIndex].Value.ToString();
                    combCategoria.Text = dgProductos[3, rowIndex].Value.ToString();
                    combProveedor.Text = dgProductos[5, rowIndex].Value.ToString();
                    txtPrecioCompra.Text = dgProductos[7, rowIndex].Value.ToString();
                    txtPrecioVenta.Text = dgProductos[8, rowIndex].Value.ToString();
                    txtID.Text = idNumber;



                }
                    catch (Exception)
                    {
                        
                    }


                }
            }

        }
    }





