using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCOnlineTicaret.Models.Classes
{
    public class InvoiceItems
    {
        [Key]
        public int ItemsId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string Description { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Value { get; set; }
        public Invoice Invoice { get; set; }
    }
}