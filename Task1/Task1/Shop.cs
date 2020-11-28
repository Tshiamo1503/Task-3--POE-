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
            switch (weaponT)
            {
                case 0:
                    break;
            }
            return ;
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

            //PickUp();
            RandomWeapon();
        }

        public string DisplayWeapon(int num)
        {
            string output = "Buy "+ weapons[num].weapontype+" ("+weapons[num].cost+")";

            return (output);
        }
    }
}
