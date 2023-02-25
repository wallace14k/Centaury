namespace Centaury.Domain.Entities
{
    public class Sector :BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Office> Offices { get; set; }
    }
}
