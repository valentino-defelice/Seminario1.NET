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
    public partial class CrearCategoria : Form
    {
        DatabaseQuerys _dq = new DatabaseQuerys();

        public CrearCategoria()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHome h = new AdminHome();

            this.Hide();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = _dq.crearCategoria(
                txtNombreCategoria.Text,
                txtDescripcion.Text
                );

            if (!result)
            {
                resultado.Text = "Hubo un problema al crear la categoria.";
                resultado.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                resultado.Text = "Categoría creada con éxito.";
                resultado.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void CrearCategoria_Load(object sender, EventArgs e)
        {
 
        }
    }
}
