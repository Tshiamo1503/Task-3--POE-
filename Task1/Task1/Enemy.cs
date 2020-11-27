using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Enemy: Character
    {
        protected Random ran = new Random();
        
        public Enemy(int X,int Y,int damage,int hp,char smbl)
            :base(X,Y,smbl)
        {
            this.x = X;
            this.y = Y;
            this.Damage = damage;
            this.HP = hp;
            this.MAxHP = HP;
        }

        public override string ToString()
        {
            //EnemyClassName at[X, Y] (Amount DMG)-------------- message that must be displayed 
            string output = "G at["+this.x+","+this.y+"] ("+this.Damage+")";
            return output;
        }


    }
}
