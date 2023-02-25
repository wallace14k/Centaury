namespace Centaury.Api.Models
{
    public class EmployeeGetRequest
    {
        public int Name { get; set; }
        public int Age { get; set; }
        public OfficeGetRequest Office { get; set; }
        public SectorGetRequest Sector { get; set; }


        public class OfficeGetRequest
        {
            public string Name { get; set; }

        }
        public class SectorGetRequest
        {
            public string Name { get; set; }
        }
    }
}
