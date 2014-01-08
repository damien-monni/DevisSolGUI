using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevisSolGUI
{
    class Connect : IPage
    {
        public string  Width { get; set; }
        public int Id { get; set; }

        public Connect()
        {
            Id = 1;
        }
    }
}