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
        Program.ShoppingCartUpdates Valores = new Program.ShoppingCartUpdates();

        public Home(Usuario User)
        {
            InitializeComponent();
            Valores.Usuario = User;
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
            CrearPedido objCrearPedido = new CrearPedido(Valores.Usuario);

            this.Hide();
            objCrearPedido.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MisPedidos objMisPedidos = new MisPedidos(Valores.Usuario);
            this.Hide();
            objMisPedidos.Show();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
