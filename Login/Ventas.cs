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
            //CargaComboProductos();
            String consultaCombProducto = "SELECT idCategoria,DescripcionCatProd FROM [CategoriaProducto] ORDER BY DescripcionCatProd DESC";
            CargaCombos(combProducto, consultaCombProducto, "idCategoria", "DescripcionCatProd");
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

            nombreCombobox.Items.Clear();
            nombreCombobox.DataSource = null;

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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga del combo " + nombreCombobox.Name + " " + ex);
                throw;
            }


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

        private void combProducto_SelectedValueChanged(object sender, EventArgs e)
        {

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
