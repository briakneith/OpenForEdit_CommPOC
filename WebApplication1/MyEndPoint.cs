using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebApplication1
{
    public class MyEndPoint : PersistentConnection
    {

        protected override Task OnConnected(IRequest request, string connectionId)
        {
            return Connection.Broadcast("Connection " + connectionId + " connected");
        }

        protected override Task OnReconnected(IRequest request, string connectionId)
        {
            return Connection.Broadcast("Client " + connectionId + " re-connected");
        }

        protected override IList<string> OnRejoiningGroups(IRequest request, IList<string> groups, string connectionId)
        {
            return groups;
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            //return Connection.Broadcast("Connection " + connectionId + " sent " + data);

            // sending to a specific connection
            return Connection.Send(connectionId, "Connection " + connectionId + " sent " + data);
        }

        protected override Task OnDisconnected(IRequest request, string connectionId, bool stopCalled)
        {
            return base.OnDisconnected(request, connectionId, stopCalled);
        }

    }
}