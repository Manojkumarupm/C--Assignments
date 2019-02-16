using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment24
{
    public
        class Tennis
    {
        public string Country { get; set; }
        public string Player { get; set; }
        public Tennis(string country, string player)
        {
            Country = country;
            Player = player;
        }
    }
}
