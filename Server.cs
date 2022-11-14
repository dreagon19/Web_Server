using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Web_Server
{
    /// <summary>
    /// Since the webserver is stateless so most of the behavior can be implemented as static singelton.
    /// </summary>
    public static class Server
    {
        private static HttpListener _listener;

        //Returning the List of assigned IP to localHost network devices includes wireless or wired
        private static List<IPAddress> GetLocalHostIPs()
        {
            IPHostEntry hostEntry;
            hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            List<IPAddress> result = hostEntry.AddressList.Where(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToList();

            return result;
        }


    }
}
