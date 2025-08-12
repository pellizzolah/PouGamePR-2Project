using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PouBDSMultiplayer
{
    public partial class MainMenu : Form
    {
        SoundPlayer clickUIPlayer = new SoundPlayer(@"C:\Users\cj3027694\source\repos\PouBDSMultiplayer\PouBDSMultiplayer\Resources\clickUI.wav");
        SoundPlayer sucessLoginPlayer = new SoundPlayer(@"C:\Users\cj3027694\source\repos\PouBDSMultiplayer\PouBDSMultiplayer\Resources\success.wav");
        SoundPlayer noSfxPlayer = new SoundPlayer(@"C:\Users\cj3027694\source\repos\PouBDSMultiplayer\PouBDSMultiplayer\Resources\no.wav");

        public MainMenu(string nick)
        {
            InitializeComponent();
            lbPlayerNickname.Text = nick;
            sucessLoginPlayer.Play();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnInformations_Click(object sender, EventArgs e)
        {
            clickUIPlayer.Play();
            Informations info = new Informations();
            info.ShowDialog();
        }

        private void btnScoreboard_Click(object sender, EventArgs e)
        {
            clickUIPlayer.Play();
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.ShowDialog();
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            clickUIPlayer.Play();
        }

        private void eastereggclickPou_Click(object sender, EventArgs e)
        {
            noSfxPlayer.Play();
        }
    }
}
