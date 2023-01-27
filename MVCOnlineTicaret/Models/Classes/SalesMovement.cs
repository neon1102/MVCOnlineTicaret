using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCOnlineTicaret.Models.Classes
{
    public class SalesMovement
    {
        [Key]
        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public Product Product { get; set; }
        public Current Current { get; set; }
        public Staff Staff { get; set; }


    }
}