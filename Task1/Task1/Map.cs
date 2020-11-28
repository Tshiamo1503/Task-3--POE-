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

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight,int numEnemies,int goldamount,int numWeapons)
        {
            this.width = randomize.Next(minWidth, maxWidth + 1);
            this.height = randomize.Next(minHeight, maxHeight + 1);
            this.Maptiles = new char[height,width];
            this.enemies = new Enemy[numEnemies];
            this.Items = new Item[goldamount+numWeapons];

            Create(Tile.TileType.Hero);//hero

            for (int i = 0; i < goldamount; i++)
            {
              Items[i] =  Create(Tile.TileType.Gold);/////////=================for gold
            }

            for (int i = 0; i < enemies.Length; i++)
            {
              enemies[i] = Create(Tile.TileType.Enemy);//enemy
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

        private Tile Create(Tile.TileType type)
         {
            switch (type)
            {
                case Tile.TileType.Hero://====================================================Hero
                    Hero hero = new Hero(10,0,0);
                    while (Maptiles[hero.Y,hero.X] != '.')
                    {
                        Random ran = new Random();
                        hero.X = ran.Next(0, width);
                        hero.Y = ran.Next(0, Height);
                    }
                    return hero;

                case Tile.TileType.Enemy://====================================================Hero
                    Random enemytype = new Random();
                    switch (enemytype.Next(0,3))
                    {
                        case 0:
                            Enemy enemy = new Goblin(0, 0);
                            while (Maptiles[enemy.Y, enemy.X] != '.')
                            {
                                Random ran = new Random();
                                enemy.X = ran.Next(0, width);
                                enemy.Y = ran.Next(0, Height);
                            }
                            return enemy;
                        case 1:
                            Enemy enemy1 = new Mage(0, 0);
                            while (Maptiles[enemy1.Y, enemy1.X] != '.')
                            {
                                Random ran = new Random();
                                enemy1.X = ran.Next(0, width);
                                enemy1.Y = ran.Next(0, Height);
                            }
                            return enemy1;
                        case 2:
                            Enemy enemy2 = new Leader(0, 0);
                            while (Maptiles[enemy2.Y, enemy2.X] != '.')
                            {
                                Random ran = new Random();
                                enemy2.X = ran.Next(0, width);
                                enemy2.Y = ran.Next(0, Height);
                            }
                            return enemy2;

                        default:
                            Enemy enemyG = new Goblin(0, 0);
                            while (Maptiles[enemyG.Y, enemyG.X] != '.')
                            {
                                Random ran = new Random();
                                enemyG.X = ran.Next(0, width);
                                enemyG.Y = ran.Next(0, Height);
                            }
                            return enemyG;
                    }

                case Tile.TileType.Gold://====================================================Gold
                    Gold gold = new Gold(0, 0);
                    while (Maptiles[gold.Y, gold.X] == '.')
                    {
                        Random ran = new Random();
                        gold.X = ran.Next(0, width);
                        gold.Y = ran.Next(0, Height);
                    }
                    return gold;

                case Tile.TileType.Weapon://====================================================Weapon
                    Random random = new Random();
                    int weaponT = random.Next(0, 4);
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
                        ranged = new RangedWeapon(RangedWeapon.Types.Longbow, 0, 0);
                        return ranged;
                    }
                    else if (weaponT == 3)
                    {
                        ranged = new RangedWeapon(RangedWeapon.Types.Rifle, 0, 0);
                        return ranged;
                    }
                    else
                    {
                        melee = new MeleeWeapon(MeleeWeapon.Types.Dagger, 0, 0);//========== if all else failes the default is a dagger 
                        return melee;
                    }

                default:
                    Hero hero1 = new Hero(10, 0, 0);
                    while (Maptiles[hero1.Y, hero1.X] != '.')
                    {
                        Random ran = new Random();
                        hero1.X = ran.Next(0, width);
                        hero1.Y = ran.Next(0, Height);
                    }
                    return hero1;
            }
         }

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
