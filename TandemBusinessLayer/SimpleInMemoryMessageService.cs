using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TandemDAL;
using DomainEntities;
using DomainEntities.Mappers;
using System.Collections.ObjectModel;
using TandemBusinessLayer.Logic;

namespace TandemBusinessLayer
{
    public class MessageService<T, F> : IMessageService where T : IMessageRepository, new()
        where F: IMessageFormatter, new()
    {
        private IMessageRepository repository;
        private IMessageFormatter formatter;

        public MessageService()
        {
            repository = new T();
            formatter = new F();
        }

        //public IReadOnlyCollection<MessageResource> GetMessagesByUserIdAsync(string userId)
        //{
        //   return new ReadOnlyCollection<MessageResource>(repository.GetMessages().Where(p=>p.UserId==userId).ToArray());
        //}

        public IReadOnlyCollection<MessageResource> GetMessagesByUserId(string userId)
        {
            return new ReadOnlyCollection<MessageResource>(repository.GetMessages().Where(p => p.UserId == userId).ToArray());
        }

        public MessageResource PostMessage(Request request)
        {
            MessageResource rawMessage = request.MapToMessageResource();
            var formattedMessage = formatter.FormatMessage(rawMessage);
            repository.PostMessage(formattedMessage);

            return repository.GetMessages().Where(p => p.MessageId == formattedMessage.MessageId).SingleOrDefault();
            
        }

        public MessageResource GetPostedMessage(string messageId)
        {
            return repository.GetMessages().Where(p => p.MessageId == messageId).SingleOrDefault();
        }
    }
}
