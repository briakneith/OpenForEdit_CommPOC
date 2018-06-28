using System;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;

namespace WebApplication1
{
    public class Notifier
    {
        public static void GroupNotify(string group, string message)
        {
            var context = GlobalHost.ConnectionManager.GetConnectionContext<MyEndPoint>();
            context.Groups.Send(group, message);
        }
    }
}

