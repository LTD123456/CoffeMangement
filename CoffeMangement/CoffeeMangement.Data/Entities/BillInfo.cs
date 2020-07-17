using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoffeeMangement.Data.Entities
{
    [Table("BillInfo")]
    public class BillInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id{ get; set; }
        public int count { get; set; }
        [ForeignKey("Bill")]
        public Guid idBill { get; set; }
        public Bill Bill { get; set; }
        [ForeignKey("Food")]
        public int idFood { get; set; }
        public Food Food { get; set; }
    }
}
