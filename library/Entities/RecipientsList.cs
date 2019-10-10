using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PostSpamer.library.Entities
{
    public class RecipientsList : NamedEntity
    {
        [Required]
        public ICollection<Recipient> Recipients { get; set; }
    }
}