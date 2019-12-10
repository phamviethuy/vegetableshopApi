using System;

namespace vegetableshop.DataAccess.Entities
{
    public partial class Links
    {
        public long Id { get; set; }
        public long? VegetableId { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public DateTime? Insertdate { get; set; }
        public DateTime? Updatedate { get; set; }

        public virtual Vegetables Vegetable { get; set; }
    }
}