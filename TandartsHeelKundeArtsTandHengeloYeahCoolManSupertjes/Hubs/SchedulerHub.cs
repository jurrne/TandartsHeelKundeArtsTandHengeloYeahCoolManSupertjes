using Microsoft.AspNetCore.SignalR;

namespace TandartsSuperCool.Hubs
{
    public class SchedulerHub : Hub
    {
       public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
