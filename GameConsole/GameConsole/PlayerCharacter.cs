using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    {
        private readonly DefenseSpecial _defenseSpecial;
        public string Name { get; set; }
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }
        public int Health { get; set; }

        //ctor that takes into consideration defenses applied to the character
        public PlayerCharacter(DefenseSpecial defenseSpecial)
        {
            //Magic Numbers
            //DateOfBirth = DateTime.MinValue;
            //DaysSinceLastLogin = -1;

            //Nullable<T>, these default to null so there's no need to explicitly set them to null.
            //DaysSinceLastLogin = null;
            //DateOfBirth = null;
            Health = 100;
            _defenseSpecial = defenseSpecial;
        }

        //Reduces health hased on hit damage
        public void Hit(int damage)
        {
            int damageReduction = 0;

            //if(_defenseSpecial != null)
            damageReduction = _defenseSpecial.CalculateDamageReduction(damage);
            int damageTaken = damage - damageReduction;
            Health -= damageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {damageTaken} to {Health}");
        }
    }
}
