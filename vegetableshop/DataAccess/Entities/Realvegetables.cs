using System;
using System.Collections.Generic;

namespace vegetableshop.DataAccess.Entities
{
    public partial class Realvegetables
    {
        public Realvegetables()
        {
            Vegetableimages = new HashSet<Vegetableimages>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Promotionprice { get; set; }
        public string Descriptions { get; set; }
        public DateTime? Updatedate { get; set; }
        public DateTime? Insertdate { get; set; }

        public virtual ICollection<Vegetableimages> Vegetableimages { get; set; }
    }
}