using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DevisSolGUI
{
    class RootViewModel
    {
        public ObservableCollection<IPage> ViewCollection { get; set; }
        public int _pageActive;
        public int PageActive
        {
            get
            {
                return _pageActive;
            }
            set
            {
                ViewCollection.ElementAt(_pageActive).Width = "0";
                _pageActive = value;
                ViewCollection.ElementAt(value).Width = "700";
            }
        }

        //Constructeur
        public RootViewModel()
        {
            ViewCollection = new ObservableCollection<IPage>();
            ViewCollection.Add(new Menu());
            ViewCollection.Add(new Connect());

            foreach (IPage page in ViewCollection)
            {
                page.Width = "0";
            }

            PageActive = findPageIndex(0);
        }

        public int findPageIndex(int id)
        {
            int index = 0;
            foreach (IPage page in ViewCollection)
            {
                if (page.Id == id)
                {
                    return index;
                }
                else
                {
                    index++;
                }
            }
            return -1;
        }
    }
}