using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHero : Hero, ISuperHero
    {
        private string name;

        public int Id { get; set; } = 1;
        public override string Name 
        { 
            get { return name; } 
            set { name = value.Trim(); } 
        }
        public string NameSecretIdentity 
        {
            get { return $"{Name} ({SecretIdentity})"; } 
        }
        public string SecretIdentity { get; set; }
        public string city;
        public List<Superpower> superPower;
        public bool canFly;

        public SuperHero()
        {
            Id = 1;
            superPower = new List<Superpower>();
            canFly = false;
        }

        public string UseSuperpowers()
        {
            //permite concatenar string
            StringBuilder sb = new StringBuilder();

            foreach (var item in superPower)
            {
                //concatena toda la info y te devuelve un objeto.
                sb.AppendLine($"{NameSecretIdentity} esta usando el super poder {item.name}!!");
            }

            return sb.ToString();
        }

        //metodo heredado..
        public override string SaveWorld()
        {
            return $"{NameSecretIdentity} ha salvado el mundo";
        }

        //polimorfismo..
        public override string SaveLand()
        {
            //si dejas el base.
            //primero, realiza el metodo en el padres
            //y luego implementa lo que haya abajo.
            //return base.SaveLand(); 
            return $"{NameSecretIdentity} ha salvado la tierra";
        }
    }
}
