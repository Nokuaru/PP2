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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        { 

            //Combos de la factura
            string consultaComboCliente = "SELECT idCliente,Nombre FROM Cliente ORDER BY Nombre DESC";
            CargaCombos(combCliente, consultaComboCliente, "idCliente", "Nombre");
            String consultaComboTComprobante = "SELECT idTipoComprobante, DescripcionTipoComprobante FROM TipoComprobante";
            CargaCombos(combTipoComprobante, consultaComboTComprobante, "idTipoComprobante", "DescripcionTipoComprobante");
            String consutaComboFPago = "SELECT idFormaPago, DescripcionFormaPago FROM FormaPago";
            CargaCombos(combFormaPago, consutaComboFPago, "idFormaPago", "DescripcionFormaPago");

            //Combos del detalle de factura
            string consultaComboProducto = "SELECT idCategoria, DescripcionCatProd FROM CategoriaProducto";
            

        }



        /// <summary>
        ///  Carga en el <paramref name="nombreCombobox"/> los valores de <paramref name="consulta"/>. La <paramref name="consulta"/> debe retornar: <c>Clave de  tabla </c> | <c>Valor para mostrar</c> .
        ///  En el parámetro <paramref name="idDeConsulta"/> se espera una cadea con exactamente el nombre de la columna PK.
        ///  En el parámetro <paramref name="valorParaMostrarDeConsulta"/> se espera una cadena con el nombre de la columna a mostrar en el combo.
        /// </summary>
        /// <param name="nombreCombobox"></param>
        /// <param name="consulta"></param>
        /// <param name="idDeConsulta"></param>
        /// <param name="valorParaMostrarDeConsulta"></param>
        private void CargaCombos(ComboBox nombreCombobox, string consulta, string idDeConsulta, string valorParaMostrarDeConsulta)
        {

            nombreCombobox.DataSource = null;
            nombreCombobox.Items.Clear();

            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand(consulta, con.Conectar());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                
                nombreCombobox.ValueMember = idDeConsulta;
                nombreCombobox.DisplayMember = valorParaMostrarDeConsulta;
                nombreCombobox.DataSource = dt;
                //Ver como insertar un vacío y seleccionarlo por default para poder saber cuando se selecciona un valor
                //nombreCombobox.SelectedIndex = 0;
                //nombreCombobox.Items.Insert(0, "A");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga del combo " + nombreCombobox.Name + " " + ex);
                throw;
            }


        }


        private void ActualizaSubtotalLinea(double precioUnitario)
        {
            double valorSubtotalLinea = precioUnitario * (int)txtNumericBox.Value;

            txtSubtotalLinea.Text = valorSubtotalLinea.ToString();

        }


        private double getPrecioUnitario()
        {

            string idProducto = combNombreProducto.SelectedValue.ToString();
            string sql = "SELECT PrecioUnitarioVenta FROM Producto WHERE idProducto=" + idProducto;

            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand(sql, con.Conectar());
            DataTable resultado = new DataTable();
            using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                resultado.Load(reader);
                double precioUnitario;

                
                precioUnitario =Double.Parse(resultado. Rows[0][0].ToString());
                con.Desconectar();

                return precioUnitario;
            }
            

        }

        private void CargaDataGridDetalle()
        {
            string tipoProducto, nombreProducto, cantidad, idTipoProducto, subtotal;

            tipoProducto = combNombreProducto.Text;
            idTipoProducto = combNombreProducto.SelectedValue.ToString();
            nombreProducto = combProducto.Text.ToString();
            cantidad = txtNumericBox.Value.ToString();
            subtotal = txtSubtotalLinea.Text;
            string[] filaParaAgregar = { tipoProducto, nombreProducto, cantidad, subtotal.ToString(),subtotal };
            dataGridDetalleVenta.Rows.Add(filaParaAgregar);

        }
        private void CargaComboProductos()
        {   //limpio el combo
            combProducto.Items.Clear();
            combProducto.DataSource = null;

            try
            {

                Conexion con = new Conexion();
                string consulta = "SELECT idCategoria,DescripcionCatProd FROM [CategoriaProducto]";

                SqlCommand cmd = new SqlCommand(consulta, con.Conectar());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                combProducto.ValueMember = "idCategoria";
                combProducto.DisplayMember = "DescripcionCatProd";
                combProducto.DataSource = dt;
                /*
                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string name = saReader.GetString(0);
                        combProveedor.Items.Add(name);
                    }
                }*/
                con.Desconectar();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error al cargar combo de productos"+ex.Message);
                throw;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void combProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {



                combNombreProducto.Enabled = true;
                int iDCategoria = int.Parse(combProducto.SelectedValue.ToString());
                string consulta = "SELECT idProducto,Nombre from Producto WHERE idCategoria = '" + iDCategoria + "'";
                CargaCombos(combNombreProducto, consulta, "idProducto", "Nombre");


            }
            catch (Exception)
            {
                MessageBox.Show("Error en cmbProducto_SelectionChangeMomitted");
                throw;
            }
        }

        private void combNombreProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {

            txtNumericBox.Enabled = true;


            ActualizaSubtotalLinea(getPrecioUnitario());

        }

        private void btnAgregarAVenta_Click(object sender, EventArgs e)
        {
            CargaDataGridDetalle();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            
            string idCliente, idFormaPago, idTipoComprobante, numeroComprobante, consCombProducto;
            idCliente= combCliente.SelectedValue.ToString();
            idFormaPago = combFormaPago.SelectedValue.ToString();
            idTipoComprobante = combTipoComprobante.SelectedValue.ToString();
            numeroComprobante = txtNumeroComprobante.Text;

            string cons = "INSERT INTO Venta(idCliente,idUsuario,idTipoComprobante,idEstadoVenta,idFormaPago, NumeroComprobante) VALUES	("+idCliente+",1000,"+ idTipoComprobante + ",3,"+idFormaPago+","+numeroComprobante+")";

            string filasAfectadas = null;
            Conexion con = new Conexion();
            
            SqlCommand cmd = new SqlCommand(cons, con.Conectar());
            filasAfectadas = cmd.ExecuteNonQuery().ToString();

            if(filasAfectadas.Length > 0)
            {
                MessageBox.Show("Factura creada con éxito. Agregue los items correspondientes");
                tableLayoutPanel1.Enabled = true;
                btnAgregarAVenta.Enabled = false;
                combProducto.Enabled = true;
                btnAgregarAVenta.Enabled = true;
                dataGridDetalleVenta.Enabled = true;
                consCombProducto = "SELECT idCategoria, DescripcionCatProd FROM CategoriaProducto";
                CargaCombos(combProducto, consCombProducto, "idCategoria", "DescripcionCatProd");
                txtNumericBox.Enabled = true;

            }
            con.Desconectar();
        }




        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            btnNuevaVenta.Enabled = true;
            btnCancelarVenta.Enabled = false;
        }

        private void txtNumericBox_ValueChanged(object sender, EventArgs e)
        {
            txtSubtotalLinea.Enabled = true;
            ActualizaSubtotalLinea(getPrecioUnitario());
            
        }
    }
}
