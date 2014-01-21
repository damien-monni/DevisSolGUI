using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DevisSolGUI
{
    abstract class Page : INotifyPropertyChanged
    {
        //Execute when the page has just been displayed
        public abstract void AtStart();

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
                OnPropertyChanged("Width");
            }
        }

        public int Id { get; set; }


        //Use the PropertyChanged event
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

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