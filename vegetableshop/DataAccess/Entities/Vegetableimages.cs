using System;

namespace vegetableshop.DataAccess.Entities
{
    public partial class Vegetableimages
    {
        public long Id { get; set; }
        public long? RealvegetableId { get; set; }
        public long? VegetableId { get; set; }
        public string Path { get; set; }
        public int? Type { get; set; }
        public DateTime? Updatedate { get; set; }
        public DateTime? Insertdate { get; set; }

        public virtual Realvegetables Realvegetable { get; set; }
        public virtual Vegetables Vegetable { get; set; }
    }
}