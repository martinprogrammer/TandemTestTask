using System;
using NUnit.Framework;
using DomainEntities;
using TandemDAL;


namespace DALTests
{
    [TestFixture]
    public class SimpleMemoryStoreTests
    {
        private IMessageRepository repository;

        [SetUp]
        public void Setup()
        {
            repository = new SimpleMemoryStore();
        }


        [Test()]
        public void Given_A_MessageResource_PostMessage_Should_Post_A_Message()
        {

            //arrange
            var messageResource = new MessageResource()
            {
                UserId = "martin",
                Message = "Hello Dolly",
                MessageId = Guid.NewGuid().ToString(),
                CreatedDate = "new date"
            };

            //act
            repository.PostMessage(messageResource);

            //assert
            Assert.That(repository.GetCount()==1);
        }

        [Test()]
        public void Get_Messages_Should_Get_All_Messages()
        {
            //arrange
            var messageResource = new MessageResource()
            {
                UserId = "martin",
                Message = "Hello Dolly",
                MessageId = Guid.NewGuid().ToString(),
                CreatedDate = "new date"
            };

            var messageResource1 = new MessageResource()
            {
                UserId = "peter",
                Message = "Not bothered",
                MessageId = Guid.NewGuid().ToString(),
                CreatedDate = "next date"
            };

            var messageResource2 = new MessageResource()
            {
                UserId = "jimmy",
                Message = "Snap",
                MessageId = Guid.NewGuid().ToString(),
                CreatedDate = "last date"
            };

            //act
            repository.PostMessage(messageResource);
            repository.PostMessage(messageResource1);
            repository.PostMessage(messageResource2);

            //assert
            Assert.That(repository.GetCount() == 3);
            
        }
    }
}
