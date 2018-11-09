using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Orden
    {
        [Key]
        public int OrdenId { get; set; }

        [Required]
        public string PedidoId { get; set; } 

        [Required]
        public int UsuarioId { get; set; }
        
        public string UsuarioEmail { get; set; }

        public decimal total { get; set; }

        public virtual Usuario Usuario { get; set; }

        public DateTime FechaCreacion { get; set; }

        public bool Confirmado { get; set; }
    }
}
