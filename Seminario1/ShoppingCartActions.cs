using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using BussinesModel;

namespace Seminario1
{
    public class ShoppingCartActions : IDisposable
    {
        DatabaseQuerys _dq = new DatabaseQuerys();

        public string PedidoId { get; set; }

        public const string CartSessionKey = "CartId";

        public void AddToCart(int id)
        {
            // Retrieve the product from the database.           
            PedidoId = GetCartId();

            var cartItem = _dq.buscarItem(PedidoId, id);
            if (cartItem == null)
            {
                // Si el item no fue seleccionado, lo creamos, sino le aumentamos la cantidad.
                cartItem = new LineaProducto
                {
                    LineaProductoId = Guid.NewGuid().ToString(),
                    ProductoId = id,
                    PedidoId = PedidoId,
                    Producto = _dq.getProductoById(id),
                    Cantidad = 1,
                    FechaCreacion = DateTime.Now
                };

                _dq.crearLineaProducto(cartItem);
            }
            else
            {
                // La funcion actualizar, si ya existe la linea de producto, le aumenta 1.
                _dq.actualizarItem(PedidoId, id);
            }
        }

        public string GetCartId()
        {
            if (HttpContext.Current.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[CartSessionKey] = HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.     
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return HttpContext.Current.Session[CartSessionKey].ToString();
        }

        public List<LineaProducto> GetListaProductos()
        {
            PedidoId = GetCartId();

            return _dq.productosDelPedido(PedidoId);
        }

        public void Dispose()
        {
            ApplicationDbContext _db = new ApplicationDbContext();
            if(_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }

        public decimal GetTotal()
        {
            PedidoId = GetCartId();

            return _dq.GetTotal(PedidoId);
        }

        public ShoppingCartActions GetCart(HttpContext context)
        {
            using (var cart = new ShoppingCartActions())
            {
                cart.PedidoId = cart.GetCartId();
                return cart;
            }
        }

        public void UpdateShoppingCartDatabase(String cartId, ShoppingCartUpdates[] CartItemUpdates)
        {
            {
                try
                {
                    int CartItemCount = CartItemUpdates.Count();
                    List<LineaProducto> miCarrito = GetListaProductos();
                    foreach (var lineaDeProducto in miCarrito)
                    {
                        // Iterate through all rows within shopping cart list
                        for (int i = 0; i < CartItemCount; i++)
                        {
                            if (lineaDeProducto.Producto.Id == CartItemUpdates[i].ProductoId)
                            {
                                if (CartItemUpdates[i].CantidadComprada < 1 || CartItemUpdates[i].EliminarItem == true)
                                {
                                    RemoveItem(cartId, lineaDeProducto.ProductoId);
                                }
                                else
                                {
                                    UpdateItem(cartId, lineaDeProducto.ProductoId, CartItemUpdates[i].CantidadComprada);
                                }
                            }
                        }
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Update Cart Database - " + exp.Message.ToString(), exp);
                }
            }
        }

        public void RemoveItem(string eliminarPedidoID, int eliminarProductoId)
        {
            _dq.eliminarItem(eliminarPedidoID, eliminarProductoId);
        }

        public void UpdateItem(string updatePedidoId, int updateProductoID, int cantidad)
        {

            _dq.actualizarProducto(updatePedidoId, updateProductoID, cantidad);
        }

        public void EmptyCart()
        {
            PedidoId = GetCartId();

            var productosDelPedido = _dq.productosDelPedido(PedidoId);

            foreach (var lineaProducto in productosDelPedido)
            {
                _dq.eliminarItem(PedidoId, lineaProducto.ProductoId);
            }
        }

        public int GetCount()
        {
            PedidoId = GetCartId();

            return _dq.getCantidad(PedidoId);
        }

        public struct ShoppingCartUpdates
        {
            public int ProductoId;
            public int CantidadComprada;
            public bool EliminarItem;
        }

    }
}