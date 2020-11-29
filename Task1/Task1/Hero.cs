using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Hero: Character
    {
        public Hero(int hp, int xval, int yval)
            :base(xval,yval,'H')
        {
            this.HP = hp;
            this.MAxHP = hp;
            this.Damage = 2;
        }
        public int Hhealth { get { return HP; } set { HP = value; } }

        public override Movement ReturnMove(Movement move)
        {
            move = Movement.Nothing;
            return base.ReturnMove(move);
        }

        public override string ToString()
        {
            string output = ""; //= "Player Stats" + "\n" + "HP: "+this.HP+"/"+this.MAxHP+" HP"+"\n"+"current weapon: "+ this.Weapons.weapontype+"\n"+"Range: "+this.Weapons.range+"\n"+"Damage: "+this.Damage+"\n"+"Durability: "+this.Weapons.durability+"\n"+"Gold: "+this.gold+"\n"+"["+this.x+","+this.y+"]";
            return output;
        }
    }
}
