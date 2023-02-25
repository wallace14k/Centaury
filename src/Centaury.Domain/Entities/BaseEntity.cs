using System.ComponentModel.DataAnnotations;

namespace Centaury.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key()]
        public int Id { get; set; }
        public DateTime CreateAt { get => DateTime.Now;}
        public DateTime? UpdateAt { get; set; }
        public int Active { get; set; }
    }
}
