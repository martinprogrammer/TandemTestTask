using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DomainEntities;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using TandemBusinessLayer;

namespace TandemWebApi.Controllers
{
    public class MessageBoardController : ApiController
    {

        private IMessageService messageService;

        public MessageBoardController(IMessageService service)
        {
            messageService = service;
        }

      

        // GET api/messageboard/5
        public IReadOnlyCollection<MessageResource> Get(string userId)
        {
            return messageService.GetMessagesByUserId(userId);
        }

        // POST api/messageboard
        public MessageResource Post([FromBody]JObject request)
        {
            var theRequest = JsonConvert.DeserializeObject<Request>(request.ToString());
            if (String.IsNullOrEmpty(theRequest.UserId))
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            if (String.IsNullOrEmpty(theRequest.Message))
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var result = messageService.PostMessage(theRequest);
            return result;

             
        }

      
    }
}
