using System;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace TechStackCheck.Web.Hubs
{
    public class NotificationHub : Hub
    {
        /// <summary>
        /// Pings the server time.
        /// </summary>
        /// <returns>The server time.</returns>
        /// <param name="request">Hubs can receive any number of string parameters</param>
        public async Task PingServerTime(string request)
        {
            if (request.Equals("serverTime", StringComparison.InvariantCultureIgnoreCase))
            {
                await Clients.All.SendAsync("serverTime", DateTime.Now.ToShortTimeString());
            }
        }
    }
}
