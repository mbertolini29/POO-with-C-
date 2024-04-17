using System.Text;
using SuperHeroesApp;
using SuperHeroesApp.Models;

var showInfo = new ShowInfo();

//Super poderes.

var powerFlight = new Superpower();
powerFlight.name = "Volar";
powerFlight.description = "Capacidad para volar y planear";
powerFlight.level = PowerLevel.secondLevel;

var superStrenght = new Superpower();
superStrenght.name = "Super fuerza";
superStrenght.level = PowerLevel.thirdLevel;

var regeneration = new Superpower();
regeneration.name = "Regeneración";
regeneration.level = PowerLevel.thirdLevel;

//  creacion de super heroe

//--> superman
var superman = new SuperHero();
superman.Id = 1;
superman.Name = "  Superman  ";
superman.SecretIdentity = "Clark Kent";
superman.city = "Metropolis";
superman.canFly = true;

showInfo.ShowSuperHero(superman);

//--> super poderes 
List<Superpower> supermanPowers = new List<Superpower>();
supermanPowers.Add(powerFlight);
supermanPowers.Add(superStrenght);
superman.superPower = supermanPowers;
string resultSupermanPowers = superman.UseSuperpowers();
Console.WriteLine(resultSupermanPowers);
string resultSaveWorld = superman.SaveWorld();
Console.WriteLine(resultSaveWorld); 
string resultSaveLand = superman.SaveLand();
Console.WriteLine(resultSaveLand); 

//--> wolverine
var wolverine = new AntiHero();
wolverine.Id = 5;
wolverine.Name = "Wolverine";
wolverine.SecretIdentity = "Logan";
wolverine.canFly = false;

showInfo.ShowSuperHero(wolverine);

//--> super poderes 
List<Superpower> wolverinePowers = new List<Superpower>();
wolverinePowers.Add(regeneration);
wolverinePowers.Add(superStrenght);
wolverine.superPower = wolverinePowers;
string resultWolverinePowers = wolverine.UseSuperpowers();
Console.WriteLine(resultWolverinePowers);

string actionAntihero = wolverine.TakeSuperheroActions("a atacado a la policia");
Console.WriteLine(actionAntihero);  

enum PowerLevel
{
    firstLevel,
    secondLevel,
    thirdLevel
}