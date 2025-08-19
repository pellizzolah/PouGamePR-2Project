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
    public partial class PouRtxEasterEgg : Form
    {
        SoundPlayer player = new SoundPlayer(@"C:\Users\cj3027694\source\repos\PouBDSMultiplayer\PouBDSMultiplayer\Resources\among-us-estourado.wav");
        public PouRtxEasterEgg()
        {
            InitializeComponent();
            player.Play();
            MessageBox.Show("Tchola");
        }
    }
}
