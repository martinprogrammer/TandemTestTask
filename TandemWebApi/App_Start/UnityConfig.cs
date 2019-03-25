using System.Web.Http;
using Unity;
using Unity.WebApi;
using TandemBusinessLayer;
using TandemBusinessLayer.Logic;
using TandemDAL;

namespace TandemWebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterSingleton<IMessageService, MessageService<SimpleMemoryStore, MessageFormatterDefault>>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}