using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LineaProducto
    {
        [Key]
        public string LineaProductoId { get; set; }

        [Required]
        public string PedidoId { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        public int Cantidad { get; set; }

        public DateTime FechaCreacion { get; set; }

        [Required]
        public int ProductoId { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
