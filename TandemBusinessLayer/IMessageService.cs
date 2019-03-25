using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainEntities;

namespace TandemBusinessLayer
{
    public interface IMessageService
    {
        IReadOnlyCollection<MessageResource> GetMessagesByUserId(string userId);
        MessageResource PostMessage(Request request);
        MessageResource GetPostedMessage(string messageId);
    }
}
