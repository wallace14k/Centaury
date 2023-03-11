using System.ComponentModel.DataAnnotations;

namespace Centaury.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        [MaxLength(11)]
        public string Document { get; set; }
        public int OfficeId { get; set; }
        public Office Office { get; set; }
        public int SectorId { get; set; }
        public Sector Sector { get; set; }
    }
}
