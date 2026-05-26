using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
        public class GameState
        {
            public double cookiesCount { get; set; }
            public double cookiesPerClick { get; set; }
            public double cookiesPerSecond { get; set; }
            public int totalClicks { get; set; }
            public int upgradeCount { get; set; }
        }
    }

