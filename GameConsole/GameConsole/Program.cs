using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating characters to demo null reference exception in gentry
            var sarah = new PlayerCharacter(new DefenseDiamondSkin())
            {
                Name = "Sarah"
                , DaysSinceLastLogin = 42
                , IsNoob = false
                , DateOfBirth = DateTime.Parse("02/12/2000")
            };
            var amrit = new PlayerCharacter(new DefenseIronBones())
            {
                Name = "Amrit"
                , DaysSinceLastLogin = 42
                , IsNoob = false
                , DateOfBirth = DateTime.Parse("02/12/1990")
            };
            var gentry = new PlayerCharacter(DefenseSpecial.Null)
            {
                Name = "Gentry"
                , DaysSinceLastLogin = 2
                , IsNoob = true
                , DateOfBirth = DateTime.Parse("02/12/2010")
            };

            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);

            //Does the same thing as ctrl+f5
            Console.ReadLine();
        }
    }
}
