using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace Login

{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        string cc = @"Data Source = PREMIERE; Initial Catalog = pp2_test; Integrated Security = True";

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
                lblUsuario.Text = "Ingrese la contraseña";
            }

            else {
                try
                {
                    SqlConnection con2 = new SqlConnection(cc);
                    SqlCommand cmd = new SqlCommand("Select * from Usuarios WHERE Usuario =@usuario and Pass = @password", con2);
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    con2.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    con2.Close();
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