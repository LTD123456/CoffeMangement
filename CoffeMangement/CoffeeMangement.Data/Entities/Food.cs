using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoffeeMangement.Data.Entities
{
    [Table("Food")]
    public class Food
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id{ get; set; }
        public string  name { get; set; }
        public string image { get; set; }
        public string price { get; set; }
        public ICollection<BillInfo> BillInfos { get; set; }
        [ForeignKey("FoodCategory")]
        public int idCategory { get; set; }
        public FoodCategory FoodCategory { get; set; }
    }
}
