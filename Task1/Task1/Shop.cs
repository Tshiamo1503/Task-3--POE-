using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Shop
    {
        private Weapon[] weapons;
        private Random ran;
        private Character Buyer;

        public Shop(Character buyer)
        {
            Buyer = buyer;
            this.weapons = new Weapon[3];
            ran = new Random();

            for (int i = 0; i < 2; i++)
            {
                weapons[i] = RandomWeapon();
            }
        }

        private Weapon RandomWeapon()
        {
            int weaponT = ran.Next(0, 4);
            MeleeWeapon melee;
            RangedWeapon ranged;

            if (weaponT == 0)
            {
                melee = new MeleeWeapon(MeleeWeapon.Types.Dagger, 0, 0);
                return melee;
            }
            else if (weaponT == 1)
            {
                melee = new MeleeWeapon(MeleeWeapon.Types.longsword, 0, 0);
                return melee;
            }
            else if (weaponT == 2)
            {
                 ranged = new RangedWeapon(RangedWeapon.Types.Longbow,0,0);
                return ranged;
            }
            else if (weaponT == 3)
            {
                 ranged = new RangedWeapon(RangedWeapon.Types.Rifle, 0, 0);
                return ranged;
            }
            else
            {
                melee = new MeleeWeapon(MeleeWeapon.Types.Dagger, 0, 0);//======= if all else fails the default is a dagger 
                return melee;
            }
        }

        public bool CanBuy(int num)
        {
            bool buy = false;

            if (Buyer.gold>= weapons[num].cost)
            {
                buy = true;
            }
            return buy;
        }

        public void Buy(int num)
        {
            Buyer.gold -= weapons[num].cost;

            Buyer.Pickup(weapons[num]);
            RandomWeapon();
        }

        public string DisplayWeapon(int num)
        {
            string output = "Buy "+ weapons[num].weapontype+" (cost: "+weapons[num].cost+" gold)";
            return (output);
        }
    }
}
