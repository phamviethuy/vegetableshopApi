using System;
using System.Collections.Generic;

namespace vegetableshop.DataAccess.Entities
{
    public partial class Users
    {
        public Users()
        {
            Orders = new HashSet<Orders>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? Role { get; set; }
        public string Avatar { get; set; }
        public string Password { get; set; }
        public DateTime? Insertdate { get; set; }
        public DateTime? Updatedate { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}