using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public abstract class DefenseSpecial
    {
        public static DefenseSpecial Null { get; } = new DefenseNull();

        public abstract int CalculateDamageReduction(int totalDamage);

        private class DefenseNull : DefenseSpecial
        {
            public override int CalculateDamageReduction(int totalDamage)
            {
                //Do nothing
                return 0;
            }
        }
    }
}
