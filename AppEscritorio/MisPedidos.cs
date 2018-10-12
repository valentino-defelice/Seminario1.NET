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
using Models;

namespace AppEscritorio
{
    public partial class MisPedidos : Form
    {
        DatabaseQuerys _dq = new DatabaseQuerys();
        Program.ShoppingCartUpdates Valores = new Program.ShoppingCartUpdates();

        public MisPedidos(Usuario Usuario)
        {
            InitializeComponent();

            Valores.Usuario = Usuario;

            var misPedidos = _dq.getOrdenesConfirmadas(Valores.Usuario.Id);
            var data = misPedidos.Select(o =>
                new
                {
                    Orden = o.OrdenId,
                    Fecha = o.FechaCreacion,
                }
            );

            gridMisPedidos.DataSource = misPedidos.Select(o =>
                new
                {
                    Orden = o.OrdenId,
                    Fecha = o.FechaCreacion,
                }
            ).ToList();
        }

        private void gridMisPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var e1 = (DataGridViewCellEventArgs)e;
            var OrdenId = Int16.Parse(gridMisPedidos[0, e1.RowIndex].Value.ToString());

            DetallePedido dp = new DetallePedido(OrdenId, Valores.Usuario);

            this.Hide();
            dp.Show();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home h = new Home(Valores.Usuario);

            this.Hide();
            h.Show();
        }
    }
}
