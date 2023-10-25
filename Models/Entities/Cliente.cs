using System.ComponentModel.DataAnnotations;
using Proyecto_Final.Models.Entities;

namespace Proyecto_Final.Models.Entities
{
    public class Cliente
    {

        [Key]
        public int clienteId { get; set; }

        [Required]
        [StringLength(20)]
        public String? Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public String? Apellido { get; set; }

        [Required]
        public int Dni { get; set; }

        [Required]
        public bool Membresia { get; set; }

        [Required]
        public List<Entrada>? Entradas { get; set; }

    }
}
