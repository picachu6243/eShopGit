namespace eShop.Databases.Entities.Base
{
    public class BaseEntity
    {
        public int id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? CreatedUserId { get; set; }
        public int? UpdateUserId { get; set; }
    }
}
