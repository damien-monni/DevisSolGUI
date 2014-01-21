using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;

namespace DevisSolGUI
{
    class Menu : Page
    {
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
        }

        public void Install()
        {
            ChangePage(1);
        }

        public override void AtStart()
        {
        }
    }
}