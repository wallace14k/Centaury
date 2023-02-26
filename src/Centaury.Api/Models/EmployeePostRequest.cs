namespace Centaury.Api.Models
{
    public class EmployeePostRequest
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Age { get; set; }
        public OfficePostRequest Office { get; set; }
        public SectorPostRequest Sector { get; set; }


        public class OfficePostRequest
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int SectorId { get; set; }

        }
        public class SectorPostRequest
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
