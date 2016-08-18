using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamenWebII.Models
{
    [Table("Inventarios")]
    public class Inventario
    {
        [Key]
        public int Id { get; set; }
        public double Cantidad { get; set; }
        public double CantidadMinima { get; set; }
        public double CantidadMaxima { get; set; }
        public Boolean GravadoExcepto { get; set; }

        public Producto Productos { get; set; }
    }
}