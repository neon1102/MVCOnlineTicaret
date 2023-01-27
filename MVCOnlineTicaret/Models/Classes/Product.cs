using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCOnlineTicaret.Models.Classes
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Brend { get; set; }
        public short Stock { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public bool Status { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(255)]
        public string ProductImage { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<SalesMovement> SalesMovements { get; set; }
    }
}