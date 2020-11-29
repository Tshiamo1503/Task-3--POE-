using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class RangedWeapon: Weapon
    {
        public enum Types
        {
            Rifle, Longbow
        }

        public override int range { get => base.range; set => base.range = Range; }

        public RangedWeapon(Types Range, int x, int y)
        : base('R', x, y)
        {
            switch (Range)
            {
                case Types.Rifle:
                    weapontype = "Rifle";
                    durability = 3;
                    range = 3;
                    damage = 5;
                    cost = 7;
                    break;

                case Types.Longbow:
                    weapontype = "Longbow";
                    durability = 4;
                    range = 2;
                    damage = 4;
                    cost = 6;
                    break;
            }
        }

        public RangedWeapon(Types Range, int DURABILITY,int x,int y)
            : base('R', x, y)
        {
            switch (Range)
            {
                case Types.Rifle:
                    weapontype = "Rifle";
                    durability = DURABILITY;
                    range = 3;
                    damage = 5;
                    cost = 7;
                    break;

                case Types.Longbow:
                    weapontype = "Longbow";
                    durability = DURABILITY;
                    range = 2;
                    damage = 4;
                    cost = 6;
                    break;
            }

        }

    }
}
