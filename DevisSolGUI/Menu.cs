using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;

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

        private ICommand _installCommand;
        public ICommand InstallCommand
        {
            get
            {
                if (_installCommand == null)
                {
                    _installCommand = new Command(Install);
                    return _installCommand;
                }
                else
                {
                    return _installCommand;
                }
            }
        }

        //Constructeur
        public Menu()
        {
            Id = 0;
            Width = "700";
        }

        public void Install()
        {
            OnChanged(1);
        }

        //INotifyPropertyChanged implémentation
        public event PropertyChangedEventHandler PropertyChanged;

        //Evenement
        public delegate void FireEventHandler(object sender, FireEventArgs fe);
        public event FireEventHandler FireEvent; 

        // Invoke the Changed event
        protected virtual void OnChanged(int id)
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