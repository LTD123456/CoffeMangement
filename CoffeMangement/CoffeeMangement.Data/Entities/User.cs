using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoffeeMangement.Data.Entities
{
    [Table("User")]
    public class User : BaseEntity
    {
        public User()
        {
            this.ID = Guid.NewGuid();
            this.CreatedDate = new DateTime();
            this.ModifiedDate = new DateTime();
        }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string PassWord { get; set; }

    }
}
