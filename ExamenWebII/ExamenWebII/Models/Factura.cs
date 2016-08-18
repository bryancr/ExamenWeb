using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamenWebII.Models
{
    [Table("Facturas")]
    public class Factura
    {
        [Key]
        public int Id { get; set; }
        public double MontoTotal { get; set; }
        public double SubTotal { get; set; }
        public double Impuestos { get; set; }
        public string Detalle{ get; set; }

        public Cliente Cliente { get; set; }
        public Producto Producto { get; set; }
    }
}