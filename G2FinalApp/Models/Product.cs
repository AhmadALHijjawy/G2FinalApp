using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace G2FinalApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string ProdName { get; set; }
        [Required]
        public decimal ProdPrice { get; set; }
        public int Qty { get; set; }
        public bool Stock { get; set; }
        public string ProdDesc { get; set; }
        public string ProdImage { get; set; }
        public string Catagory { get; set; }
    }
}
