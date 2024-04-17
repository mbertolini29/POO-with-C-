using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class AntiHero : SuperHero
    {
        //take = realizar
        public string TakeSuperheroActions(string action)
        {
            return $"El antiheroe {NameSecretIdentity} {action}";
        }
    }
}
