using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Login.Data;

namespace Login

{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
          
        }

        string cc = @"Data Source = PREMIERE; Initial Catalog = Grupo42; Integrated Security = True";

        public void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUsuario.Text=="" & txtPassword.Text == "")
            {
                lblUsuario.Text="Ingrese un usuario";
                lblPassword.Text = "Ingrese la contraseña";
            } 
            
            else if(txtPassword.Text == "")
            {
                lblPassword.Text = "Ingrese la contraseña";
             }

            else if (txtUsuario.Text == "")
            {
                lblUsuario.Text = "Ingrese un usuario";
            }

            else {
                try
                {
                    Conexion con = new Conexion();
                    string sql = "Select * from Usuario WHERE Usuario =@usuario and Pass = @password";
                    SqlCommand cmd = new SqlCommand(sql, con.Conectar());
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    con.Desconectar();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    con.Desconectar();
                    int contar = ds.Tables[0].Rows.Count;
                    if (contar == 1)
                    {
                        this.Hide();
                        foreach (DataRow drow in ds.Tables[0].Rows)
                        {
                            ActivaUsuario(drow["idUsuario"].ToString());
                        }
                        Home home = new Home ();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecto");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void ActivaUsuario(string idUsuario)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE Usuario SET Activo = 0 WHERE Activo = 1; \n" +
                    "UPDATE Usuario SET Activo = 1 WHERE idUsuario= " + idUsuario;
                SqlCommand cmd = new SqlCommand(sql, con.Conectar());
                cmd.ExecuteNonQuery();
                con.Desconectar();

            }
            catch (SqlException exsql)
            {
                MessageBox.Show("Error en la activación del usuario en cuestión" + exsql.Message);
                throw;
            }
        }
        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            lblUsuario.Text = "";

        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            lblPassword.Text = "";
        }

        public string getUsuarioActivo()
        {
            string usuarioActivo= String.Empty;

            Conexion con = new Conexion();
            string sql = "SELECT idUsuario FROM Usuario WHERE Activo=1";
            SqlCommand cmd = new SqlCommand(sql, con.Conectar());
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Desconectar();

            foreach (DataRow drow in ds.Tables[0].Rows)
            {
                usuarioActivo = drow["idUsuario"].ToString();
            }
            return usuarioActivo;
        }
    }
}