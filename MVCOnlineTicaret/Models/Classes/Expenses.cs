using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCOnlineTicaret.Models.Classes
{
    public class Expenses
    {
        [Key]
        public int ExpensesId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Amout { get; set; }
    }
}