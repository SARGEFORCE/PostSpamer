using System;

namespace PostSpamer.library.Entities
{
    public class ShedulerTask : BaseEntity
    {
        public DateTime Time { get; set; }
        public Server Server { get; set; }
        public Sender Sender { get; set; }
        public RecipientsList Recipients { get; set; }
        public Spam Spam { get; set; }
    }
}