using System.ComponentModel.DataAnnotations;

namespace PostSpamer.library.Entities
{
    public abstract class NamedEntity : BaseEntity
    {
        [Required]
        public virtual string Name { get; set; }
    }
}
