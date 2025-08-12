using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PouBDSMultiplayer
{
    public partial class MainMenu : Form
    {
        public MainMenu(string nick)
        {
            InitializeComponent();
            lbPlayerNickname.Text = nick;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnInformations_Click(object sender, EventArgs e)
        {
            Informations info = new Informations();
            info.ShowDialog();
        }

        private void btnScoreboard_Click(object sender, EventArgs e)
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.ShowDialog();
            
        }
    }
}
