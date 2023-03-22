using Centaury.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Centaury.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public ProductType ProductType { get; set; }
        public string Type
        {
            get => Type.GetType().ToString();
        }
        public int SectorId { get; set; }
        public Sector Sector { get; set; }
    }
}
