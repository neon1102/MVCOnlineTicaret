using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCOnlineTicaret.Models.Classes
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string StaffName{ get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string StaffSurname{ get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(255)]
        public string StaffImage{ get; set; }
        public ICollection<SalesMovement> SalesMovements { get; set; }
        public Department Department { get; set; }
    }
}