using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoffeeMangement.Data.Entities
{
    [Table("User")]
    public class User
    {
        public User()
        {
            this.UserID = Guid.NewGuid();
        }
        [Key]
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string PassWord { get; set; }

    }
}
