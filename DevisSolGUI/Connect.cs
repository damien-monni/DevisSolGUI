﻿using System;
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

        public bool IsConnected { get; set; }

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
                IsConnected = true;
                Console.WriteLine("test");
            }
            else
            {
            }
        }
    }
}