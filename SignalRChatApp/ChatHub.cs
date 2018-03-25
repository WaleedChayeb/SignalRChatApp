
using Microsoft.AspNet.SignalR;
using System.Linq; 

namespace SignalRChatApp
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}