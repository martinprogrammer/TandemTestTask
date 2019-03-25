using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainEntities;
using System.Collections.Concurrent;

namespace TandemDAL
{
    public class SimpleMemoryStore: IMessageRepository
    {
        //private  static SimpleMemoryStore singleton= null;
        private ConcurrentBag<MessageResource> messages;

        //public static SimpleMemoryStore GetInstanceOfSimpleMemoryStore()
        //{
        //    if (singleton==null)
        //    {
        //        singleton = new SimpleMemoryStore();
        //    }

        //    return singleton;
        //}

        //private SimpleMemoryStore()
        //{
        //    messages = new ConcurrentBag<MessageResource>();
        //}

        public SimpleMemoryStore()
        {
            messages = new ConcurrentBag<MessageResource>();
        }

        public void PostMessage(MessageResource message)
        {
            messages.Add(message);
        }

        public IList<MessageResource> GetMessages()
        {
            return messages.ToList();
        }

        public int GetCount()
        {
        
            return messages.Count();
        }
    }
}
