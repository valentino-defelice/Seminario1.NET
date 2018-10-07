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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Models_DbContextDataSet.Productoes' table. You can move, or remove it, as needed.
            this.productoesTableAdapter.Fill(this._Models_DbContextDataSet.Productoes);

        }
    }
}
