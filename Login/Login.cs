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

        private void btnLogin_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Ingreso Satisfactorio");
                        this.Hide();
                        Dashboard frm = new Dashboard();
                        frm.Show();
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





        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblUsuario.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPassword.Text = "";
        }
    }
}