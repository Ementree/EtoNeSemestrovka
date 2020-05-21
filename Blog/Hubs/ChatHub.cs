using Blog.Data;
using Blog.Interfaces;
using Blog.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(MessageModel message) =>
           await Clients.All.SendAsync("receiveMessage", message);
        
    }
}
