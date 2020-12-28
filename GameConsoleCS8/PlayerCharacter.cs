using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    {

        public PlayerCharacter()
        {
            Name = "";
            DaysSinceLastLogin = 0;
            DateOfBirth = DateTime.MinValue;
            IsNoob = false;
            Health = 100;
        }
        public PlayerCharacter(string Name) : this()
        {
            this.Name = Name;
        }
        public PlayerCharacter(string Name, int DaysSinceLastLogin) : this(Name)
        {
            this.DaysSinceLastLogin = DaysSinceLastLogin;
        }
        public PlayerCharacter(string Name, int DaysSinceLastLogin, DateTime DateOfBirth) : this(Name, DaysSinceLastLogin)
        {
            this.DateOfBirth = DateOfBirth;
        }
        public PlayerCharacter(string Name, int DaysSinceLastLogin, DateTime DateOfBirth, bool IsNoob) : this(Name, DaysSinceLastLogin, DateOfBirth)
        {
            this.IsNoob = IsNoob;
        }
        public PlayerCharacter(string Name, int DaysSinceLastLogin, DateTime DateOfBirth, bool IsNoob, int Health) : this(Name, DaysSinceLastLogin, DateOfBirth, IsNoob)
        {
            this.Health = Health;
        }

        public string Name { get; set; }
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }
        public int Health { get; set; }
    }
}
