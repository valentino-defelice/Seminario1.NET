using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public string RutaImagen { get; set; }

        [Required]
        public decimal Precio { get; set; }

        [Required]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
