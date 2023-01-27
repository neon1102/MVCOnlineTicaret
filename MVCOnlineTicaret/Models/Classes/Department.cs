using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVCOnlineTicaret.Models.Classes
{
    public class Department
    {
        [Key]
        public int DepartmanId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string DepartmanName { get; set; }
        public ICollection<Staff> Staffs { get; set; }

    }
}