namespace Centaury.Api.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Document { get; set; }
        public OfficeViewModel Office { get; set; }
        public SectorViewModel Sector { get; set; }


        public class OfficeViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public SectorViewModel Sector { get; set; }
        }
        public class SectorViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
