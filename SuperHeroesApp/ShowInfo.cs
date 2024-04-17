using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp
{
    internal class ShowInfo
    {
        public void ShowSuperHero(ISuperHero superHero)
        {
            //Console.WriteLine($"Id: {superHero.Id}");
            //Console.WriteLine($"Nombre: {superHero.Name}");
            //Console.WriteLine($"Identidad secreta: {superHero.SecretIdentity}");

            Console.WriteLine(superHero.GetSuperHeroe());
        }
    }
}