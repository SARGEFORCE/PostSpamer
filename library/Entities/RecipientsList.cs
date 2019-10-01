using System.Collections.Generic;

namespace PostSpamer.library.Entities
{
    public class RecipientsList : NamedEntity
    {
        public ICollection<Recipient> Recipients { get; set; }
    }
}