using System;

namespace vegetableshop.DataAccess.Entities
{
    public partial class Skills
    {
        public long Id { get; set; }
        public long? VegetableId { get; set; }
        public string Skill { get; set; }
        public string Descriptions { get; set; }
        public DateTime? Updatedate { get; set; }
        public DateTime? Insertdate { get; set; }

        public virtual Vegetables Vegetable { get; set; }
    }
}