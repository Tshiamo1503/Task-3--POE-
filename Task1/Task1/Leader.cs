using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Leader: Enemy
    {
        private Tile target;
        public Tile TARGET { get { return target; } set { target = value; } }

        public Leader(int x,int y) :base(x,y,2,20,'L')
        {
            this.Weapon = new MeleeWeapon(MeleeWeapon.Types.longsword, x, y);
        }

        public override Movement ReturnMove(Movement move)
        {
            int Direction;
            Random ran = new Random();
            Direction = ran.Next(0, 5);
            switch (Direction)
            {
                case 0:
                    move = Movement.down;
                    break;
                case 1:
                    move = Movement.left;
                    break;
                case 2:
                    move = Movement.Nothing;
                    break;
                case 3:
                    move = Movement.right;
                    break;
                case 4:
                    move = Movement.up;
                    break;
                default:
                    move = Movement.Nothing;
                    break;
            }
            return base.ReturnMove(move);
        }
    }
}
