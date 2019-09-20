using System;
using System.Net;
using System.Windows;
using System.Net.Mail;
using System.Security;

namespace MailSender.WPFTest
{
    /// <summary>
    /// Класс переменных 
    /// </summary>
    public static class Variables
    {
        /// <summary>
        /// Порт
        /// </summary>
        public static int port = 25;
        /// <summary>
        /// Хост
        /// </summary>
        public static string host = "smtp.yandex.ru";
        /// <summary>
        /// Адрес отправителя
        /// </summary>
        public static string from_address= "several989@mail.ru";
        /// <summary>
        /// Имя отправителя
        /// </summary>
        public static string from_name = "Сергей";
        /// <summary>
        /// Адрес получателя
        /// </summary>
        public static string to_address = "several898@gmail.com";
        /// <summary>
        /// Имя получателя
        /// </summary>
        public static string to_name = "Serg";
        /// <summary>
        /// Заголовок письма
        /// </summary>
        public static string subject = "Тестовое письмо от " + DateTime.Now;

        //public static string user_name = UserNameEditor.Text;
        //public static securestring password = PasswordEditor.SecurePassword;
        
        /// <summary>
        /// Текст письма
        /// </summary>
        public static string msg = "Привет, это тестовое письмо, отвечать на него вовсе не обязательно! (типа @noreply, все дела...) ";
        /// <summary>
        /// Сообщение успешно отправленного письма
        /// </summary>
        public static string okMessage = "Почта успешно отправлена";
        /// <summary>
        /// Заголовок окна ошибки
        /// </summary>
        public static string errorSubject= "Бдинь!";

    }
}