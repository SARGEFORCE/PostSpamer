using System;
using System.ComponentModel.DataAnnotations;

namespace PostSpamer.library.Entities
{
    public class SchedulerTask : BaseEntity
    {
        public DateTime Time { get; set; }
        [Required]
        public Server Server { get; set; }
        [Required]
        public Sender Sender { get; set; }
        [Required]
        public RecipientsList Recipients { get; set; }
        [Required]
        public Spam Spam { get; set; }
    }
}