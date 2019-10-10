using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PostSpamer.library.Entities
{
    public class SpamList : BaseEntity
    {
        [Required]
        public List<Spam> Spams { get; set; }
    }
}
