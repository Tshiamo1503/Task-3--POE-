using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
       static GameEngine Game = new GameEngine();
        Shop shop = new Shop(Game.Map.hero);
        int weapon = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblMap.Text = Game.ToString();
            Statbox.Text = Game.Map.hero.ToString();

            button2.Text = shop.DisplayWeapon(weapon);
    
            if (shop.CanBuy(0) == false|| shop.CanBuy(1) == false|| shop.CanBuy(2) == false)
            {
                button2.Enabled = false;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
            Game.MovePlayer(Character.Movement.up);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

            Game.MovePlayer(Character.Movement.left);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {

            Game.MovePlayer(Character.Movement.down);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Game.MovePlayer(Character.Movement.right);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GameEngine Savegame = new GameEngine();

            Savegame.Save();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            GameEngine Savegame = new GameEngine();

            Savegame.Load();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int choice = Convert.ToInt32(txtshopchoice.Text);

            shop.Buy(choice);

            Random ran = new Random();

            if (weapon<3)
            {
                weapon++;
            }
            button2.Text = shop.DisplayWeapon(weapon);
        }
    }
}
