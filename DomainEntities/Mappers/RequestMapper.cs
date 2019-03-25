using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities.Mappers
{
    public static class RequestMapper
    {
        public static MessageResource MapToMessageResource(this Request request)
        {
            if(request!=null)
            {
                return new MessageResource()
                {
                    UserId = request.UserId,
                    Message = request.Message,
                    MessageId = "",
                    CreatedDate = ""
                };
            }

            return null;
        }
    }
}
