using System;
using System.Collections.Generic;

namespace vegetableshop.DataAccess.Entities
{
    public partial class Vegetables
    {
        public Vegetables()
        {
            Links = new HashSet<Links>();
            Orders = new HashSet<Orders>();
            Skills = new HashSet<Skills>();
            Vegetableimages = new HashSet<Vegetableimages>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Slogan { get; set; }
        public string Nickname { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Price { get; set; }
        public string Promotionprice { get; set; }
        public int? Ratting { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public int? Skin { get; set; }
        public string V1 { get; set; }
        public string V2 { get; set; }
        public string V3 { get; set; }
        public string Startworkingtime { get; set; }
        public string Endworkingtime { get; set; }
        public string Wokingareas { get; set; }
        public DateTime? Insertdate { get; set; }
        public DateTime? Updatedate { get; set; }

        public virtual ICollection<Links> Links { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Skills> Skills { get; set; }
        public virtual ICollection<Vegetableimages> Vegetableimages { get; set; }
    }
}