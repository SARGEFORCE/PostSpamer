using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSpamer.library
{
    public static class TestClass
    {
        public static List<Server> Servers { get; } = new List<Server>
        {
            new Server { Id = 0, Name = "Yandex", Adress = "smtp.yandex.ru", UserName = "UserName", Password = "Pass" },
            new Server { Id = 1, Name = "Google", Adress = "smtp.google.com", UserName = "UserName", Password = "Pass" },
            new Server { Id = 2, Name = "Mail.ru", Adress = "smtp.mail.ru", UserName = "UserName", Password = "Pass" },
            new Server { Id = 3, Name = "Sobaka.com", Adress = "smtp.sobaka.com", UserName = "UserName", Password = "Pass" }
        };

        public static List<Sender> Senders { get; } = new List<Sender>
        {
            new Sender { Id = 0, Name = "Карпатов Тролл", Address = "zabugor@gulp.su" },
            new Sender { Id = 1, Name = "Кроликов Иван", Address = "ivan.krolikov@meil.tru" },
            new Sender { Id = 2, Name = "Вездеколов Фарид", Address = "kudayberdy@coil.co"}
        };
    }
}
