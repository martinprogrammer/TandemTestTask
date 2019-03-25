using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainEntities
{
    public class MessageResource
    {
        public string UserId { get; set; }
        public string Message { get; set; }
        public string MessageId { get; set; }
        public string CreatedDate { get; set; }
    }
}
