using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainEntities;

namespace TandemBusinessLayer.Logic
{
    public class MessageFormatterDefault : IMessageFormatter
    {
        public MessageResource FormatMessage(DomainEntities.MessageResource message)
        {
            message.CreatedDate = DateTime.UtcNow.ToString("s",
                System.Globalization.CultureInfo.InvariantCulture);
            message.MessageId = Guid.NewGuid().ToString();

            return message;
        }
    }
}
