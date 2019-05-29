using SIS.HTTP.Enums;
using SIS.WebServer;
using SIS.WebServer.Routing;
using SIS.WebServer.Routing.Contracts;
using System;
using TEST.Demo.Controllers;

namespace TEST.Demo
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            IServerRoutingTable serverRoutingTable = new ServerRoutingTable();

            serverRoutingTable.Add(HttpRequestMethod.Get, "/", request => new HomeController().Home(request));//dobavqme v serverRoutingTable method path i func koqto shte se izpalni pri povikvane

            Server server = new Server(8000, serverRoutingTable);

            server.Run();
        }
    }
}
