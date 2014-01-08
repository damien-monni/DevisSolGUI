﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DevisSolGUI
{
    class Menu : IPage, INotifyPropertyChanged
    {
        private string _width;
        public string Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Width"));
                }
            }
        }

        public int Id { get; set; }

        //Constructeur
        public Menu()
        {
            Id = 0;
            Width = "700";
        }

        //INotifyPropertyChanged implémentation
        public event PropertyChangedEventHandler PropertyChanged;
    }
}