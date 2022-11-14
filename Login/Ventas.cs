using Login;
using Login.Data;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

            txtSubtotalLinea.Text = Math.Round( valorSubtotalLinea,2).ToString();

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

        private void actualizaEstadoFactura(int idEstadoFactura)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE VENTA SET idEstadoVenta = " + idEstadoFactura + " WHERE idVenta = " + getIdVenta();
                SqlCommand cmd = new SqlCommand(sql, con.Conectar());
                cmd.ExecuteNonQuery();
                con.Desconectar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al actualizar estado de factura \n" + ex);
                throw;
            }

        }
        private void actualizaEstadoFactura(int idEstadoFactura, int idFactura)
        {

            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE VENTA SET idEstadoVenta =" + idEstadoFactura + " WHERE idVenta" + idFactura;
                SqlCommand cmd = new SqlCommand(sql, con.Conectar());
                cmd.ExecuteNonQuery();
                con.Desconectar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al actualizar estado de factura \n" + ex);
                throw;
            }

        }

        private string getIdVenta()
        {
            string sql = "SELECT MAX(idVenta) FROM Venta";
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
                MessageBox.Show("Error al obtener el id de factura.\n" + ex);
                throw;
            }

        }

        private void ActualizaTotalDeFactura()
        {
            int filas = dataGridDetalleVenta.RowCount;
            double acuTotalFactura = 0.0;
            double tempDouble;
            for (int i = 0; i < filas; i++)
            {
                tempDouble = double.Parse(dataGridDetalleVenta[4, i].Value.ToString());
                acuTotalFactura = acuTotalFactura + double.Parse(dataGridDetalleVenta[4, i].Value.ToString());
            }
            txtTotalFactura.Text = Math.Round(acuTotalFactura, 2).ToString();
        }


        private void CargaDataGridDetalle()
        {
            string tipoProducto, nombreProducto, cantidad, idTipoProducto, subtotal;

            tipoProducto = combNombreProducto.Text;
            idTipoProducto = combNombreProducto.SelectedValue.ToString();
            nombreProducto = combProducto.Text.ToString();
            cantidad = txtNumericBox.Value.ToString();
            subtotal = txtSubtotalLinea.Text;

            string[] filaParaAgregar = { tipoProducto, nombreProducto,idTipoProducto, cantidad, subtotal.ToString(),subtotal };
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
            btnFinalizarVenta.Enabled = true;
            ActualizaTotalDeFactura();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            btnCancelarVenta.Enabled = true;
            btnNuevaVenta.Enabled = false;
            btnAgregarAVenta.Enabled = true;

            try
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
                    combProducto.SelectedIndex = -1;

                }
                con.Desconectar();

                combCliente.Enabled = false;
                combTipoComprobante.Enabled = false;
                combFormaPago.Enabled = false;
                txtNumeroComprobante.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            btnNuevaVenta.Enabled = true;
            btnCancelarVenta.Enabled = false;
            // resetea factura
            combCliente.SelectedIndex = -1;
            combTipoComprobante.SelectedIndex= -1;  
            combFormaPago.SelectedIndex = -1;
            txtNumeroComprobante.ResetText();
            // resetea detalle
            combProducto.SelectedIndex = -1;
            combNombreProducto.SelectedIndex = -1;
            txtNumericBox.ResetText();
            txtSubtotalLinea.ResetText();
            txtTotalFactura.ResetText();
            dataGridDetalleVenta.Rows.Clear();
            btnAgregarAVenta.Enabled = false;
            btnFinalizarVenta.Enabled = false;

            //bloquea detalle factura
            combProducto.Enabled = false;
            combNombreProducto.Enabled = false;
            txtNumericBox.Enabled = false;
            txtSubtotalLinea.Enabled = false;

            //habilita factura
            combCliente.Enabled = true;
            combTipoComprobante.Enabled = true;
            combFormaPago.Enabled = true;

        }

        private void txtNumericBox_ValueChanged(object sender, EventArgs e)
        {
            txtSubtotalLinea.Enabled = true;
            ActualizaSubtotalLinea(getPrecioUnitario());
            
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            string idVenta = getIdVenta();
            string acumulaQry = "";
            string totalFactura;
            var res = DialogResult;

            int filas = dataGridDetalleVenta.RowCount;
            if (filas >0) {
                string[] qry = new string[filas];   

                    if (filas==1)
                    {
                        qry[0] = "(" + idVenta + "," + dataGridDetalleVenta[2,0].Value.ToString()+"," + dataGridDetalleVenta[3, 0].Value.ToString()+")";
                    }
                    else
                    {
                        for (int i = 0; i < filas; i++)
                        {
                            qry[i] = "(" + idVenta + "," + dataGridDetalleVenta[2, i].Value.ToString() + "," + dataGridDetalleVenta[3, i].Value.ToString() + ")";
                            if (i<filas-1)
                            {
                                qry[i] += ",";
                            }
                        }
                    }

                acumulaQry = "INSERT INTO DetalleVenta (idVenta,idProducto,Cantidad) VALUES ";
                for (int i = 0; i < qry.Length; i++)
                {
                    acumulaQry+=qry[i];
                }

                try
                {

                    Conexion con = new Conexion();
                    SqlCommand cmd = new SqlCommand(acumulaQry, con.Conectar());
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    actualizaEstadoFactura(1);

                    totalFactura = txtTotalFactura.Text;

                    res = MessageBox.Show("Se generó la factura número "+ txtNumeroComprobante.Text.ToString() +" por un monto total de $"+ totalFactura, "Factura generada con éxito.", MessageBoxButtons.OK);
                    if (res == DialogResult.OK)
                    {
                       // Home home = new Home();
                       // home.navVenta_Click();
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al insertar detalles de factura \n" + ex);
                    throw;
                }

            }
            


        }
    }
}
