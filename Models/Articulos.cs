using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P1AP2_JohanLuis.Models
{
    public class Articulos
    {

        [Key]
        public int ArticuloId { get; set; }
        [Required(ErrorMessage = "Rellenar Campo Obligatorio - Descripción")]
        public string Descripcion { get; set; }
        [Required, Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Debe existir algun Producto")]
        public int Existencia { get; set; } 
        [Required, Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Debe Aplicar un costo mayor que cero")]
        public float Costo { get; set; }
        
    }
}
