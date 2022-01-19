using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using engine1;

namespace igrica
{
    public partial class Form1 : Form
    {
        private Player player;
        public Form1()
        {
            InitializeComponent();
            player = new Player(10,10,0,0,1);
            Location location = new Location(1, "Home");

            labelHP.Text = player.currentHP.ToString();
            labelCoin.Text = player.coin.ToString();
            labelExp.Text = player.xp.ToString();
            labelLvl.Text = player.level.ToString();
            labelLocation.Text = location.name;
        }

    }
}
