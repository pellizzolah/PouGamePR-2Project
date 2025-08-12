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
    public partial class FrmLogin : Form
    {
        SoundPlayer clickUIPlayer = new SoundPlayer(@"C:\Users\cj3027694\source\repos\PouBDSMultiplayer\PouBDSMultiplayer\Resources\clickUI.wav");
        


        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            clickUIPlayer.Play();

            if (string.IsNullOrEmpty(txbNome.Text) || (string.IsNullOrEmpty(txbPassword.Text)))
            {
                MessageBox.Show("Ambos os campos de nome e senha tem que ser preenchidos!");
            }
            else
            {
                MessageBox.Show("Nome: " + txbNome.Text + "\n" + "Senha: " + txbPassword.Text);
                MainMenu mainmenu = new MainMenu(txbNome.Text);
                mainmenu.ShowDialog();
                
                
                
            }
        }
    }
}
