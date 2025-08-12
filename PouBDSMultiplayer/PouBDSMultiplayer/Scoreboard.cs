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
    public partial class Scoreboard : Form
    {

        SoundPlayer clickUIPlayer = new SoundPlayer(@"C:\Users\cj3027694\source\repos\PouBDSMultiplayer\PouBDSMultiplayer\Resources\clickUI.wav");
        public Scoreboard()
        {
            InitializeComponent();
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            clickUIPlayer.Play();
            this.Close();
        }
    }
}
