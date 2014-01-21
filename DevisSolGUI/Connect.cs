using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading;

namespace DevisSolGUI
{
    class Connect : Page
    {
        private Boolean _connectingAnim;
        public Boolean ConnectingAnim
        {
            get
            {
                return _connectingAnim;
            }
            set
            {
                _connectingAnim = value;
                OnPropertyChanged("ConnectingAnim");
            }
        }

        private Boolean _connectSuccessAnim;
        public Boolean ConnectSuccessAnim
        {
            get
            {
                return _connectSuccessAnim;
            }
            set
            {
                _connectSuccessAnim = value;
                OnPropertyChanged("ConnectSuccessAnim");
            }
        }
        
        public Connect()
        {
            Id = 1;
        }

        //INotifyPropertyChanged implémentation

        //Ping l'adresse "ip"
        public bool PingServer(string ip)
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

        public override void AtStart()
        {
            ConnectingAnim = true;
            bool ping = this.PingServer("10.199.137.90");
            if (ping == true)
            {
                ConnectSuccessAnim = true;
            }
            else
            {
            }
        }
    }
}