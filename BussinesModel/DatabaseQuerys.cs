using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Models;
using System.Web.ModelBinding;

namespace BussinesModel
{
    public class DatabaseQuerys
    {
        ApplicationDbContext _db = new ApplicationDbContext();

        public bool comprobarUsuario(string email, string password)
        {
            var result = _db.Usuarios.Any(o => o.Email == email && o.Password == password);
            return result;
        }

        public bool createUser(string email, string password)
        {
            Usuario u = new Usuario();
            u.Email = email;
            u.Password = password;
            _db.Usuarios.Add(u);
            _db.SaveChanges();

            return true;
        }
        public Usuario getUsuarioByEmail(string email)
        {
            return _db.Usuarios.SingleOrDefault(x => x.Email == email);
        }

        // Obtenemos Categorias y las devolvemos como un IQueryable
        public IQueryable<Categoria> GetCategorias()
        {
            IQueryable<Categoria> query = _db.Categorias;
            return query;
        }

        public IQueryable<Producto> GetProducts(int? categoryId)
        {
            IQueryable<Producto> query = _db.Productos;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoriaId == categoryId);
            }
            return query;
        }

        public IQueryable<Producto> GetProduct(int? productId)
        {
            IQueryable<Producto> query = _db.Productos;
            if (productId.HasValue && productId > 0)
            {
                query = query.Where(p => p.Id == productId);
            }
            else
            {
                query = null;
            }
            return query;
        }

        public bool crearCategoria(string nombre, string descripcion)
        {
            Categoria nueva = new Categoria();
            nueva.NombreCategoria = nombre;
            nueva.Descripcion = descripcion;

            try
            {
                _db.Categorias.Add(nueva);
                _db.SaveChanges();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
                return false;
            }


            return true;
        }

        public bool crearProducto(string nombre, string descripcion, string ruta, int precio, int categoriaid)
        {
            Producto nuevo = new Producto();

            nuevo.Nombre = nombre;
            nuevo.Descripcion = descripcion;
            nuevo.RutaImagen = ruta;
            nuevo.Precio = precio;
            nuevo.CategoriaId = categoriaid;

            try
            {
                _db.Productos.Add(nuevo);
                _db.SaveChanges();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
                return false;
            }


            return true;
        }

        public Producto getProductoById(int id)
        {
            return _db.Productos.SingleOrDefault(p => p.Id == id);
        }

        public void crearLineaProducto(LineaProducto item)
        {
            _db.LineasdelPedido.Add(item);
            _db.SaveChanges();
        }

        public LineaProducto buscarItem(string PedidoId, int Id)
        {
            return _db.LineasdelPedido.SingleOrDefault(c => c.PedidoId == PedidoId && c.ProductoId == Id);
        }

        public void actualizarItem(string PedidoId, int Id)
        {
            var cartItem = buscarItem(PedidoId, Id);
            cartItem.Cantidad++;
            _db.SaveChanges();
        }

        public void actualizarProducto(string PedidoId, int ProductoId, int cantidad)
        {
            var cartItem = buscarItem(PedidoId, ProductoId);
            cartItem.Cantidad = cantidad;
            _db.SaveChanges();
        }

        public void eliminarItem(string PedidoId, int ProductoId)
        {
            var cartItem = buscarItem(PedidoId, ProductoId);
            _db.LineasdelPedido.Remove(cartItem);
            _db.SaveChanges();
        }

        public int getCantidad(string PedidoId)
        {
            // Get the count of each item in the cart and sum them up          
            int? count = (from lineasDePedido in _db.LineasdelPedido
                          where lineasDePedido.PedidoId == PedidoId
                          select (int?)lineasDePedido.Cantidad).Sum();
            // Return 0 if all entries are null         
            return count ?? 0;
        }

        public List<LineaProducto> productosDelPedido(string PedidoId)
        {
            return _db.LineasdelPedido.Where(x => x.PedidoId == PedidoId).ToList();
        }

        public List<LineaProducto> getProductosByOrden(int? OrdenId)
        {
            var orden = _db.Ordenes.SingleOrDefault(x => x.OrdenId == OrdenId).PedidoId;

            return productosDelPedido(orden);
        }

        public decimal GetTotal(string PedidoId)
        {
            decimal? total = decimal.Zero;
            total = (decimal?)(from LineaProducto in _db.LineasdelPedido
                               where LineaProducto.PedidoId == PedidoId
                               select (int?)LineaProducto.Cantidad *
                               LineaProducto.Producto.Precio).Sum();
            return total ?? decimal.Zero;
        }

        public void crearOrden(string PedidoId, int UsuarioId)
        {
            Orden nueva = new Orden();
            nueva.PedidoId = PedidoId;
            nueva.UsuarioId = UsuarioId;
            nueva.FechaCreacion = DateTime.Now;
            nueva.Confirmado = true;

            _db.Ordenes.Add(nueva);
            _db.SaveChanges();
        }

        public IQueryable<Orden> getOrdenesConfirmadas(int UsuarioId)
        {
            return _db.Ordenes.Where(x => x.UsuarioId == UsuarioId && x.Confirmado == true);
        }

    }
}
