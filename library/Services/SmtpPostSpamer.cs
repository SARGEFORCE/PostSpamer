using PostSpamer.library.Entities;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;

namespace PostSpamer.library.Services.InMemory
{
    class SmtpPostSpamer
    {
        private readonly string _Host;
        private readonly int _Port;
        private readonly bool _UseSSL;
        private readonly string _Login;
        private readonly string _Password;

        public SmtpPostSpamer(string Host, int Port, bool UseSSL, string Login, string Password)
        {
            _Host = Host;
            _Port = Port;
            _UseSSL = UseSSL;
            _Login = Login;
            _Password = Password;
        }
        public void Send(Spam Message, Sender From, Recipient To)
        {
            using(SmtpClient client = new SmtpClient(_Host, _Port) { EnableSsl = _UseSSL })
            {
                client.Credentials = new NetworkCredential
                {
                    UserName = _Login,
                    Password = _Password
                };

                using (var message = new MailMessage())
                {
                    message.From = new MailAddress(From.Address, From.Name);
                    message.To.Add(new MailAddress(To.Address, To.Name));
                    message.Subject = Message.Subject;
                    message.Body = Message.Body;

                    client.Send(message);
                }
            }
        }
        public void Send(Spam Message, Sender From, IEnumerable<Recipient> To)
        {
            foreach (var recipient in To)
                Send(Message, From, recipient);
        }
        public void SendParallel(Spam Message, Sender From, IEnumerable<Recipient> To)
        {
            foreach (var recipient in To)
                ThreadPool.QueueUserWorkItem(_ => Send(Message, From, recipient));
        }
        public async Task SendAsync(Spam Message, Sender From, Recipient To)
        {
            using (SmtpClient client = new SmtpClient(_Host, _Port) { EnableSsl = _UseSSL })
            {
                client.Credentials = new NetworkCredential
                {
                    UserName = _Login,
                    Password = _Password
                };

                using (var message = new MailMessage())
                {
                    message.From = new MailAddress(From.Address, From.Name);
                    message.To.Add(new MailAddress(To.Address, To.Name));
                    message.Subject = Message.Subject;
                    message.Body = Message.Body;

                    await client.SendMailAsync(message).ConfigureAwait(false);
                }
            }
        }
        public async Task SendAsync(Spam Message, Sender From, IEnumerable<Recipient> To)
        {
            foreach (var recipient in To)
                await SendAsync(Message, From, recipient).ConfigureAwait(false);
        }
        public async Task SendParallelAsync(Spam Message, Sender From, IEnumerable<Recipient> To)
        {
            var send_tasks = new List<Task>();
            foreach (var recipient in To)
                send_tasks.Add(SendAsync(Message, From, recipient));
            await Task.WhenAll(send_tasks).ConfigureAwait(false);
        }
    }
}
