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

        }

        public override Movement ReturnMove(Movement move = Movement.Nothing)//////////////////============ complete
        {
            int Direction;
            Random ran = new Random();



            return base.ReturnMove(move);
        }
    }
}
