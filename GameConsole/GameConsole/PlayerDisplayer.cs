using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            //Name validation
            if (string.IsNullOrWhiteSpace(player.Name))
                Console.WriteLine("No name given");
            else
                Console.WriteLine(player.Name);

            ////Magic number approach to see how long since the player logged in.
            ////If no login, default is -1 (magic number) representing failed validation
            ////This has been changed to Nullable<T> with a null check, forget the magic number route.
            //if (!player.DaysSinceLastLogin.HasValue)
            //    Console.WriteLine("No value for days since last login");
            //else
            //    Console.WriteLine(player.DaysSinceLastLogin.Value);

            //demonstrates passing a default 
            //Console.WriteLine($"{player.DaysSinceLastLogin.GetValueOrDefault(-1)} days since last login");

            //default with a conditional operator
            //int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;
            //Console.WriteLine($"{days} days since last login");

            //default with a null-coalescing operator operator
            int days = player.DaysSinceLastLogin ?? -1;
            Console.WriteLine($"{days} days since last login");

            //Magic number approach to seeing if player gave date of birth
            //If no DoB given, default is DAteTime.MinValue (magic number) representing failed validation
            //This has been changed to Nullable<T> with a null check, forget the magic number route.
            if (!player.DateOfBirth.HasValue)
                Console.WriteLine("No DoB given");
            else
                Console.WriteLine(player.DateOfBirth.Value);

            //Nullable<T>, is the player a noob validation
            if (!player.IsNoob.HasValue)
                Console.WriteLine("Player is a noob status unknown.");
            else if(player.IsNoob.Equals(true))
                Console.WriteLine("Player is a noob.");
            else
                Console.WriteLine("Player is experienced.");
        }
    }
}
