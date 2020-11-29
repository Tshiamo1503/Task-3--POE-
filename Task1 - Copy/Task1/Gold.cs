using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Gold: Item
    {
        private int amount;
        private Random ran = new Random();
        public Gold(int X,int Y): base(X,Y)
        {
            this.amount = ran.Next(1, 6);
        }
    }
}
