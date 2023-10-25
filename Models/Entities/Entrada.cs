using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models.Entities
{
    public class Entrada
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public String? Funcion { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public int Precio { get; set; }
    }
}
