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
    public partial class ReportePedidos : Form
    {
        DatabaseQuerys _dq = new DatabaseQuerys();

        public ReportePedidos()
        {
            InitializeComponent();

            gridPedidos.DataSource = _dq.getOrdenes().Select(o =>
            new {
                Usuario = o.Usuario.Email,
                NumeroPedido = o.OrdenId,
                Fecha = o.FechaCreacion,
                Total = _dq.GetTotal(o.PedidoId),
                }
            ).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();

            this.Hide();
            ah.Show();
        }
    }
}
