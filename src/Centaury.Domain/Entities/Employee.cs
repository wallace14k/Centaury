namespace Centaury.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public int Name { get; set; }
        public int Age { get; set; }
        public int OfficeId { get; set; }
        public Office Office { get; set; }
        public int SectorId { get; set; }
        public Sector Sector { get; set; }
    }
}
