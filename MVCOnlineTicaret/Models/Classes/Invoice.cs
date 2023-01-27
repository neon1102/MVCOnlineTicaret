using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCOnlineTicaret.Models.Classes
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string InvoiceSerialNo { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string InvoiceOrderNo { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string TaxAdministration { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(35)]
        public string Submitter { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(35)]
        public string Receiver { get; set; }
        public ICollection<InvoiceItems> InvoiceItems { get; set; }
    }
}