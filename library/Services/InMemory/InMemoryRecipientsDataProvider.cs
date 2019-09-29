﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSpamer.library.Services.Interfaces;
using PostSpamer.library.Linq2SQL;

namespace PostSpamer.library.Services.InMemory
{
    public class InMemoryRecipientsDataProvider : IRecipientsDataProvider
    {
        private readonly List<Recipient> _Recipients = new List<Recipient>();
        public IEnumerable<Recipient> GetAll() => _Recipients;
        public int Create(Recipient recipient)
        {
            if (_Recipients.Contains(recipient)) return recipient.Id;
            recipient.Id = _Recipients.Count == 0 ? 1 : _Recipients.Max(r=>r.Id) + 1;
            _Recipients.Add(recipient);
            return recipient.Id;
        }
        public void SaveChanges() { }
    }
}