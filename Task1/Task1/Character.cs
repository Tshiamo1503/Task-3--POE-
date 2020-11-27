using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Character: Tile
    {
        private int hP;
        private int mAxHP;
        private int damage;
        private char[,] vision;

        public enum Movement { Nothing = 0, left, right, up, down }

        public Character(int x,int y,char symbol)
            :base(x,y)
        {
            this.x = x;
            this.y = y;
        }

        protected char[,] Vision { get => vision; set => vision = value; }
        protected int MAxHP { get => mAxHP; set => mAxHP = value; }
        protected int HP { get => hP; set => hP = value; }
        protected int Damage { get => damage; set => damage = value; }

        public virtual void Attack(char target)
        {
            HP -= this.HP;
        }

        public bool IsDead()
        {
            bool dead = false;
            if (HP >= 0)
            {
                dead = true;
            }

            return dead;
        }

        public virtual bool CheckRange(Character Chartarget)
        {
            bool barehanded = true;
            bool valid = false;
            int range = DistanceTo(Chartarget);

            while (barehanded == true)
            {
                if (range == 1)
                {
                valid = true;
                }
            }
            return valid;
        }

        private int DistanceTo(Character target)
        {
            int distance = 0;

            //calculations==========
            float distanceX = (target.x - this.x);//**************************************
            float distanceY = (target.y - this.y);//**************************************


            if (distanceX < 0)
            {
                distanceX = distanceX * -1;
            }

            if (distanceY < 0)
            {
                distanceY = distanceY * -1;
            }

            distance = Convert.ToInt32(distanceX + distanceY);

            return distance;
        }

        public void Move(Movement move)
        {
            switch (move)
            {
                case Movement.Nothing:
                    break;
                case Movement.left:
                    this.x -= 1;
                    break;
                case Movement.right:
                    this.x += 1;
                    break;
                case Movement.up:
                    this.y -= 1;
                    break;
                case Movement.down:
                    this.y += 1;
                    break;
            }
        }

        public virtual Movement ReturnMove(Movement move = 0)
        {
            return move;
        }

        public abstract override string ToString();

        public void Pickup(Item i)//================= still need to finish
        {
            switch (i)
            {
                //case :
                  //  break;
                default:
                    break;
            }
        }

    }
}
