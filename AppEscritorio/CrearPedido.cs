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
    public partial class CrearPedido : Form
    {
        DatabaseQuerys _dq = new DatabaseQuerys();
        ApplicationDbContext _db = new ApplicationDbContext();

        public int OrdenId { get; set; }
        public string PedidoId { get; set; }
        public Usuario Usuario { get; set; }
        Program.ShoppingCartUpdates Valores = new Program.ShoppingCartUpdates();

        public CrearPedido(Usuario user)
        {
            InitializeComponent();
            Valores.UsuarioId = user.Id;
        }

        private void CrearPedido_Load(object sender, EventArgs e)
        {
                // TODO: This line of code loads data into the '_Models_DbContextDataSet2.Ordens' table. You can move, or remove it, as needed.
                this.ordensTableAdapter.Fill(this._Models_DbContextDataSet2.Ordens);
            // TODO: This line of code loads data into the '_Models_DbContextDataSet.Productoes' table. You can move, or remove it, as needed.
            this.productoesTableAdapter.Fill(this._Models_DbContextDataSet.Productoes);

            Valores.PedidoId = _dq.getPedidoId();
            Valores.OrdenId = _dq.crearSoloOrden();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // label2.Text = dataGridView1[0, e1.RowIndex].Value.ToString();
            var e1 = (DataGridViewCellEventArgs)e;
            var productId = Int16.Parse(dataGridView1[0, e1.RowIndex].Value.ToString());

            LineaProducto cartItem = _dq.buscarItem(Valores.PedidoId, productId);
            
            if(cartItem == null) {
                cartItem = new LineaProducto
                {
                    LineaProductoId = Guid.NewGuid().ToString(),
                    PedidoId = Valores.PedidoId,
                    UsuarioId = Valores.UsuarioId,
                    Cantidad = 1,
                    Producto = _dq.getProductoById(productId),
                    ProductoId = productId,
                    FechaCreacion = DateTime.Now,
                };
                _dq.crearLineaProducto(cartItem);
            }
            else
            {
                _dq.actualizarItem(Valores.PedidoId, productId);
            }

            // gridOrderLines.DataSource = _dq.productosDelPedido(Valores.PedidoId).ToList();
            gridOrderLines.DataSource = _db.LineasdelPedido.Select(o => new { Column1 = o.Producto.Nombre, Column2 = o.Cantidad });

        }

        private void gridOrderLines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
