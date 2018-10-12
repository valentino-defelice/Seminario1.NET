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
    public partial class DetallePedido : Form
    {
        DatabaseQuerys _dq = new DatabaseQuerys();
        Program.ShoppingCartUpdates Valores = new Program.ShoppingCartUpdates();

        public DetallePedido(int OrdenId, Usuario User)
        {
            InitializeComponent();

            Valores.Usuario = User;
            Valores.OrdenId = OrdenId;
            // lblResultado.Text = ("" + OrdenId);
            var PedidoId = _dq.getPedidoIdByOrdenId(Valores.OrdenId);
            var total = _dq.GetTotal(PedidoId);
            lblTotal.Text = total.ToString();

            var data = _dq.getProductosByOrden(OrdenId).ToList();
            gridDetalleDelPedido.DataSource = data.Select(o =>
                new
                {
                    Producto = o.Producto.Nombre,
                    Descripción = o.Producto.Descripcion,
                    Cantidad = o.Cantidad,
                }).ToList();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Home h = new Home(Valores.Usuario);
            this.Hide();
            h.Show();
        }

        private void btnMisPedidos_Click(object sender, EventArgs e)
        {
            MisPedidos mp = new MisPedidos(Valores.Usuario);

            this.Hide();
            mp.Show();
        }
    }
}
