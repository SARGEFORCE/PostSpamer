using System.ComponentModel.DataAnnotations;

namespace PostSpamer.library.Entities
{
    public class Server : NamedEntity
    {
        [Required]
        public string Host { get; set; }
        public int Port { get; set; } = 25;
        public string Login { get; set; }
        public string Password { get; set; }
        public bool UseSSL { get; set; }
        public string Description { get; set; }
    }
}