namespace Centaury.Api.Models
{
    public class EmployeePostViewModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Document { get; set; }
        public int OfficeId { get; set; }
        public int SectorId { get; set; }

        public class OfficePostViewModel
        {
            public string Name { get; set; }    
            public int SectorId { get; set; }
        }
        public class SectorPostViewModel
        {
            public string Name { get; set; }
        }
    }
}
