using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCOnlineTicaret.Models.Classes
{
    public class Admin
    {
        [Key]
        public int AdmnId { get; set; }
        [Column(TypeName ="Varchar")]
        [StringLength(50)]
        public string UserName { get; set; }
        [Column(TypeName ="Varchar")]
        [StringLength(50)]
        public string Password { get; set; }
        [Column(TypeName ="Char")]
        [StringLength(1)]
        public string Authority { get; set; }
    }
}