using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamenWebII.Models
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Familia { get; set; }
        public string CasaFabricacion { get; set; }
        public string TipoUnidad { get; set; }
        public string Departamento { get; set; }
        public Boolean Activo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public double Unidad { get; set; }
        public double Impuesto { get; set; }
    }
}