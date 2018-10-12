using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesModel;

namespace AppEscritorio
{
    public partial class CrearProducto : Form
    {
        DatabaseQuerys _dq = new DatabaseQuerys();

        public CrearProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = _dq.crearProducto(
                txtNombre.Text,
                txtDescripcion.Text,
                txtRuta.Text,
                Int16.Parse(txtPrecio.Text),
                Int16.Parse(txtCategoria.Text)
                );
            if (!result)
            {
                resultado.Text = "Ocurrio un problema al crear el producto.";
                resultado.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                resultado.Text = "Producto creado con éxito.";
                resultado.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHome h = new AdminHome();

            this.Hide();
            h.Show();
        }
    }
}
