using DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TandemDAL
{
    public interface IMessageRepository
    {
        void PostMessage(MessageResource message);
        IList<MessageResource> GetMessages();
        int GetCount();
    }
}
