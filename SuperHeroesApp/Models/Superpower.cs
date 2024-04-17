using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class Superpower
    {
        public string name;
        public string description;
        public PowerLevel level;

        public Superpower()
        {
            level = PowerLevel.firstLevel;
        }
    }

}
