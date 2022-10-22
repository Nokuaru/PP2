using Login.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public void llenarGrid()
        {
            DataTable datos = CRUD.cargar();
            if (datos == null)
            {
                MessageBox.Show("No se puede consultar la tabla");

            }
            else
            {
                dgProductos.DataSource = datos.DefaultView;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }
    }
}
