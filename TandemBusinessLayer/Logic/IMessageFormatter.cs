using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainEntities;

namespace TandemBusinessLayer.Logic
{
    public interface IMessageFormatter
    {
        MessageResource FormatMessage(MessageResource message);
    }
}
