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
using static Login.Data.prodFunctions;

namespace Login
{
    public partial class Home : Form


    {
       
        public Home()
        {
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            nav(dashboard, pnlContent);

            decimal ventaTotal = getVentaTotal();
            procVenta.Text = "$"+ventaTotal.ToString();


        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public void nav (Form form, Panel panel)
        {
            form.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();

        }

        private void navHome_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            nav(dashboard, pnlContent);
        }

        private void navProducto_Click_1(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            nav(productos, pnlContent);
        }

        private void navVenta_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            nav(ventas, pnlContent);
        }

    }
}
