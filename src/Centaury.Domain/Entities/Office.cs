using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centaury.Domain.Entities
{
    public class Office : BaseEntity
    {
        public string  Name { get; set; }
        public int SectorId { get; set; } 
        public Sector Sector { get; set; }
    }
}
