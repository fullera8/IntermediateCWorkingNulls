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
            Dictionary<string, PlayerCharacter>? players = new Dictionary<string, PlayerCharacter>() 
                { 
                    { "Sarah", new PlayerCharacter("Sarah") },
                    { "Gentry", new PlayerCharacter("Gentry") },
                    { "NoName", new PlayerCharacter() },
                    { "NoPlayer", null! }
                }; //{ new PlayerCharacter("Sarah"), new PlayerCharacter("Gentry"), new PlayerCharacter() };

            PlayerDisplayer.Write(players["Sarah"]);
            PlayerDisplayer.Write(players["Gentry"]);
            PlayerDisplayer.Write(players["NoName"]);
            PlayerDisplayer.Write(players["NoPlayer"]);

            //Does the same thing as ctrl+f5
            Console.ReadLine();
        }
    }
}
