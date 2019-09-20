using System;
using System.Net.Mail;
using System.Net;
using System.Windows;
using System.Security;

namespace MailSender.WPFTest
{
    /// <summary>
    /// Класс, отвечающий за отправку сообщений
    /// </summary>
    public class Spamer
    {
        /// <summary>
        /// Пустой конструктор
        /// </summary>
        Spamer()
        {

        }

        /// <summary>
        /// Отправить спам
        /// </summary>
        /// <param name="userName">Имя пользователя</param>
        /// <param name="password">Пароль</param>
        public static void sendSpam(string userName, SecureString password, string subject, string text)
        {
            using (var client = new SmtpClient(Variables.host, Variables.port))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(userName, password);

                using (var message = new MailMessage())
                {
                    message.From = new MailAddress(Variables.from_address, Variables.from_name);
                    message.To.Add(new MailAddress(Variables.to_address, Variables.to_name));
                    message.Subject = subject;
                    message.Body = text;
                    //message.Attachments.Add(new Attachment());

                    try
                    {
                        client.Send(message);
                        MessageBox.Show(Variables.okMessage, "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, Variables.errorSubject, MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
    }
}
