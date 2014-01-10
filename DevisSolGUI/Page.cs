using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DevisSolGUI
{
    class Page : INotifyPropertyChanged
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

        //INotifyPropertyChanged implémentation
        public event PropertyChangedEventHandler PropertyChanged;

        //Evenement
        public delegate void FireEventHandler(object sender, FireEventArgs fe);
        public event FireEventHandler FireEvent;

        // Invoke the Changed event
        protected virtual void ChangePage(int id)
        {
            FireEventArgs e = new FireEventArgs(id);
            if (FireEvent != null)
                FireEvent(this, e);
        }
    }

    public class FireEventArgs : EventArgs
    {
        public FireEventArgs(int id)
        {
            this.id = id;
        }

        public int id;
    }
}