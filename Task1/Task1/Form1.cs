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
        GameEngine Game = new GameEngine();
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
