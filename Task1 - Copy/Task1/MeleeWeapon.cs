using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MeleeWeapon : Weapon
    {
        public enum Types
        {
            Dagger, longsword
        }

        public override int range { get => base.range; set => base.range = 1; }

        public MeleeWeapon(Types melee,int x,int y)
            :base('M',x,y)
        {
            switch (melee)
            {
                case Types.Dagger:
                    weapontype = "Dagger";
                    durability = 10;
                    damage = 3;
                    cost = 3;
                    break;

                case Types.longsword:
                    weapontype = "longsword";
                    durability = 6;
                    damage = 4;
                    cost = 5;
                    break;
            }
        }
    }
}
