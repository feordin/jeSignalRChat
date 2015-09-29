using Owin;
using Microsoft.Owin;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(jeSignalRChat.Startup))]
namespace jeSignalRChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            string connectionString = "Endpoint=sb://jesignalr.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=I8UUxgBVJhmByn9vO3XZQCz4TW0KeUBJ6p4uNwfJ2h0=";
            GlobalHost.DependencyResolver.UseServiceBus(connectionString, "Chat");

            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}