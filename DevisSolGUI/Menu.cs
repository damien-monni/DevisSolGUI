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
            OnChanged(EventArgs.Empty);
        }

        //INotifyPropertyChanged implémentation
        public event PropertyChangedEventHandler PropertyChanged;

        //Evenement
        public event EventHandler Changed;

        // Invoke the Changed event
        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }
    }
}