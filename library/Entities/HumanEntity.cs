using System.ComponentModel.DataAnnotations;

namespace PostSpamer.library.Entities
{
    public abstract class HumanEntity : NamedEntity
    {
        [Required]
        public virtual string Address { get; set; }
    }
}
