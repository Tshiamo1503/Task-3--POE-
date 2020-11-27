using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Weapon : Item
    {
        protected int Damage;
        public int damage { get { return Damage; } set { Damage = value; } }

        protected int Range;
        public virtual int range { get { return Range; } set { Range = value; } }

        protected int Durability;
        public int durability { get { return Durability; } set { Durability = value; } }

        protected int Cost;
        public int cost { get { return Cost; } set { Cost = value; } }

        protected string WeaponType;
        public string weapontype { get { return WeaponType; } set { WeaponType = value; } }

        public Weapon(char Symbl, int x, int y)
            :base(x,y)
        {

        }
    }
}
