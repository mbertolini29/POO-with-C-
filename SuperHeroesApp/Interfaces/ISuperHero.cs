using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SuperHeroesApp.Interfaces
{
    internal interface ISuperHero
    {
        int Id { get; set; }
        string Name { get; set; }
        string SecretIdentity { get; set; }

        string GetSuperHeroe()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id: {Id}");
            sb.AppendLine($"Nombre: {Name}");
            sb.AppendLine($"Identidad secreta: {SecretIdentity}");
            return sb.ToString();
        }
    }
}
