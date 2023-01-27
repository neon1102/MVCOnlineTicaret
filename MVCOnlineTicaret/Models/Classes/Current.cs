using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MVCOnlineTicaret.Models.Classes
{
    public class Current
    {
        [Key]
        public int CurrentId { get; set; }
        [Column(TypeName ="Varchar")]
        [StringLength(50)]
        public string CurrentName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CurrentSurname { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string CurrentCity { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CurrentEmil { get; set; }
        public ICollection<SalesMovement> SalesMovements { get; set; }
    }
}