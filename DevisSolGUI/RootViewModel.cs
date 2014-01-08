using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace DevisSolGUI
{
    class RootViewModel
    {
        public ObservableCollection<Object> ViewCollection { get; set; }

        //Constructeur
        public RootViewModel()
        {
            ViewCollection = new ObservableCollection<object>();
            ViewCollection.Add(new Menu());

        }
    }
}