using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSpamer.library.Entities;

namespace PostSpamer.library
{
    public static class TestClass
    {
        public static List<Server> Servers { get; } = new List<Server>
        {
            new Server { Id = 0, Name = "Yandex", Host = "smtp.yandex.ru", Login = "UserName", Password = "Pass" },
            new Server { Id = 1, Name = "Google", Host = "smtp.google.com", Login = "UserName", Password = "Pass" },
            new Server { Id = 2, Name = "Mail.ru", Host = "smtp.mail.ru", Login = "UserName", Password = "Pass" },
            new Server { Id = 3, Name = "Sobaka.com", Host = "smtp.sobaka.com", Login = "UserName", Password = "Pass" }
        };

        public static List<Sender> Senders { get; } = new List<Sender>
        {
            new Sender { Id = 0, Name = "Карпатов Тролл", Address = "zabugor@gulp.su" },
            new Sender { Id = 1, Name = "Кроликов Иван", Address = "ivan.krolikov@meil.tru" },
            new Sender { Id = 2, Name = "Вездеколов Фарид", Address = "kudayberdy@coil.co"}
        };
    }
}
