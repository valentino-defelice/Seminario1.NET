using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("Models.DbContext")
            // public ApplicationDbContext() : base("Seminario1")
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<LineaProducto> LineasdelPedido { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Orden> Ordenes { get; set; }

        // Creamos base de datos desde Package Manager Console con siguiente comando:
        // enable-migrations
        // Esto crea la carpeta 'Migrations'
        // Y con:
        // update-database ahora si generamos la base de datos.
    }
}
