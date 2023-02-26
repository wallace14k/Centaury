﻿namespace Centaury.Api.Models
{
    public class EmployeeGetRequest
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Age { get; set; }
        public OfficeGetRequest Office { get; set; }
        public SectorGetRequest Sector { get; set; }


        public class OfficeGetRequest
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public  SectorGetRequest SectorGetRequest { get; set; }
        }
        public class SectorGetRequest
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
