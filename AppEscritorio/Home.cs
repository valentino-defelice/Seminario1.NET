using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace AppEscritorio
{
    public partial class Home : Form
    {
        Usuario u = new Usuario();

        public Home(Usuario user)
        {
            InitializeComponent();
            u = user;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Models_DbContextDataSet.Productoes' table. You can move, or remove it, as needed.
            this.productoesTableAdapter.Fill(this._Models_DbContextDataSet.Productoes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearPedido objCrearPedido = new CrearPedido(u);

            this.Hide();
            objCrearPedido.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MisPedidos objMisPedidos = new MisPedidos();
            this.Hide();
            objMisPedidos.Show();

        }
    }
}
