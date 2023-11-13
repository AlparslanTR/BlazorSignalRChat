using Microsoft.AspNetCore.SignalR;

namespace BlazorSignalRChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string message,string user)
        {
            await Clients.All.SendAsync("ReceiveMessage",message, user);
        }
    }
}
