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

            switch (move)
            {
                case Movement.Nothing:
                    break;
                case Movement.left:
                    if (Vision[y,x-1]=='.')
                    {
                        move = Movement.left;
                    }
                    break;
                case Movement.right:
                    if (Vision[y, x + 1] == '.')
                    {
                        move = Movement.right;
                    }
                    break;
                case Movement.up:
                    if (Vision[y-1, x] == '.')
                    {
                        move = Movement.up;
                    }
                    break;
                case Movement.down:
                    if (Vision[y+1, x] == '.')
                    {
                        move = Movement.down;
                    }
                    break;
            }
            return base.ReturnMove(move);
        }

        public override string ToString()
        {
            string output = "Player Stats" + "\n" + "HP: "+this.HP+"/"+this.MAxHP+" HP"+"\n"+"Gold: "+this.gold+"\n"+"["+this.y+","+this.x+"]";
            return output;
        }
    }
}
