using static Centaury.Api.Models.EmployeeViewModel;

namespace Centaury.Api.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public SectorViewModel Sector { get; set; }
        public string ProductType { get; set; }
       
    }
}
