using PostSpamer.library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PostSpamer.library.Services.InMemory
{
    public class MemoryDataContext
    {
        public List<Recipient> Recipients { get; }
        public List<RecipientsList> RecipientsLists { get; }
        public List<Sender> Senders { get; }
        public List<Spam> Spams { get; }
        public List<Server> Servers { get; }
        public List<SchedulerTask> SchedulerTasks { get; }

        public MemoryDataContext()
        {
            Recipients = Enumerable.Range(1, 10).Select(i => new Recipient
            {
                Id = i,
                Name = $"Получатель {i}",
                Address = $"recipient{i}@server.com"
            }).ToList();

            Senders = Enumerable.Range(1, 10).Select(i => new Sender
            {
                Id = i,
                Name = $"Отправитель {i}",
                Address = $"sender{i}@server.com"
            }).ToList();

            Spams = Enumerable.Range(1, 10).Select(i => new Spam
            {
                Id = i,
                Subject = $"Мусор {i}",
                Body = $"Сообщение мусорной почты {i}"
            }).ToList();

            Servers = Enumerable.Range(1, 10).Select(i => new Server
            {
                Id = i,
                Host = $"smpt.server{i}.com",
                Login = $"user@server{i}.com",
                Password = $"user-{i}-password"
            }).ToList();

            Random rnd = new Random();
            T GetRandom<T>(IList<T> items) => items[rnd.Next(0, items.Count)];
            IEnumerable<T> GetRandomItems<T>(IList<T> items, int count) =>
                Enumerable
                .Range(0, count)
                .Select(i => GetRandom(items));

            RecipientsLists = Enumerable.Range(1, 10).Select(i => new RecipientsList
            {
                Id = i,
                Name = $"Mail list {i}",
                Recipients = GetRandomItems(Recipients, rnd.Next(1, Recipients.Count)).ToList()
            }).ToList();

            SchedulerTasks = Enumerable.Range(1, 10).Select(i => new SchedulerTask
            {
                Id = i,
                Time = DateTime.Now.Add(TimeSpan.FromMinutes(rnd.Next(10, 120))),
                Server = GetRandom(Servers),
                Sender = GetRandom(Senders),
                Spam = GetRandom(Spams),
                Recipients = GetRandom(RecipientsLists)
            }).ToList();
        }
    }
}
