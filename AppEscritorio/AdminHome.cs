using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrearCategoria cg = new CrearCategoria();

            this.Hide();
            cg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearProducto cp = new CrearProducto();

            this.Hide();
            cp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportePedidos rp = new ReportePedidos();

            this.Hide();
            rp.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();

            this.Hide();
            p.Show();
        }
    }
}
