using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostSpamer.library.Entities;
using PostSpamer.library.Services.InMemory;

namespace PostSpamer.library.Tests.Services.InMemory
{
    [TestClass]
    public class InMemoryRecipientsDataProviderTests
    {
        [TestMethod]
        public void CreateNewRecipientInEmptyProvider()
        {
            var data_provider = new InMemoryRecipientsDataProvider();

            var expected_recipient_name = "Получатель 1";
            var expected_recipient_address = "recipient@server.com";
            var expected_Id = 1;

            var new_recipient = new Recipient
            {
                Name = expected_recipient_name,
                Address = expected_recipient_address
            };

            data_provider.Create(new_recipient);
            var actual_id = new_recipient.Id;
            var actual_recipient = data_provider.GetById(expected_Id);

            Assert.AreEqual(expected_Id, actual_id);
            Assert.AreEqual(expected_recipient_name, actual_recipient.Name);
            Assert.AreEqual(expected_recipient_address, actual_recipient.Address);
        }
    }
}
