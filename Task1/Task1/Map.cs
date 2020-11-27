using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Map
    {
        private char[,] Maptiles;
        Hero hero;
        private Enemy[] enemies;
        private Item[] Items;
        private int width, height;
        private Random randomize = new Random();

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight,int numEnemies,int goldamount)
        {
            this.width = randomize.Next(minWidth, maxWidth + 1);
            this.height = randomize.Next(minHeight, maxHeight + 1);
            this.Maptiles = new char[height,width];
            this.enemies = new Enemy[numEnemies];
            this.Items = new Item[goldamount];

            Create();//hero

            for (int i = 0; i < goldamount; i++)
            {
                Create();/////////=================for gold
            }

            for (int i = 0; i < enemies.Length; i++)
            {
                char symbl;
                int enemytype = randomize.Next(0,2);
                switch (enemytype)
                {
                    case 0: symbl = 'G';
                        break;

                    case 1: symbl = 'M';
                        break;
                }
                Create();//enemy
            }

            UpdateVision();
        }

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public Random Randomize { get => randomize; set => randomize = value; }
        internal Enemy[] Enemies { get => enemies; set => enemies = value; }
        internal Item[] Items1 { get => Items; set => Items = value; }

        public void Create()
        {

        }

        public void UpdateVision()
        {

        }

        /* private Tile Create(Tile.TileType type)
         {
             return;
         }*/

       /* public Item GetItemAtPosition(int x, int y)//================ getitem method
        {
            for (int i = 0; i < Items.Length; i++)
            {

            }

            Item ITEM= new Item(x,y);
            return ITEM;
        }*/
    }
}
