using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Net;

namespace DevisSolGUI
{
    class Connect : Page
    {

        public Connect()
        {
            Id = 1;
        }

        //Ping l'adresse "ip"
        public static bool pingServer(string ip)
        {
            Ping ping = new Ping();
            if (ping.Send(IPAddress.Parse(ip)).Status == IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}