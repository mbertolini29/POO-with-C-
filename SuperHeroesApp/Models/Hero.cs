using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal abstract class Hero
    {
        //te permite no definir la logica aca.
        //sino que lo haces en sus herederos.. 

        public abstract string Name { get; set; }
        public abstract string SaveWorld();

        public virtual string SaveLand()
        {
            return $"{Name} ha salvado la tierra";
        }

    }
}
