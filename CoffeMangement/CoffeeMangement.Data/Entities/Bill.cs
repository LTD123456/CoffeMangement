using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoffeeMangement.Data.Entities
{
    [Table("Bill")]
    public class Bill
    {
        public Bill()
        {
            this.id = Guid.NewGuid();
        }
        [Key]
        public Guid id { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime DateCheckOut { get; set; }
        public int status { get; set; }
        public int discount { get; set; }
        public double totalPrice { get; set; }

        [ForeignKey("TableFood")]
        public int idTable { get; set; }
        public TableFood TableFood { get; set; }
        public ICollection<BillInfo> BillInfos { get; set; }
    }
}
