using System;

namespace vegetableshop.DataAccess.Entities
{
    public partial class Orders
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? VegetableId { get; set; }
        public string Address { get; set; }
        public int? Quantity { get; set; }
        public string Total { get; set; }
        public DateTime? Updatedate { get; set; }
        public DateTime? Insertdate { get; set; }

        public virtual Users User { get; set; }
        public virtual Vegetables Vegetable { get; set; }
    }
}