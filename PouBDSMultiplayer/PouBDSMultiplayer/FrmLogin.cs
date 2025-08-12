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
    public partial class FrmLogin : Form
    {
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
            if (string.IsNullOrEmpty(txb.Text) || (string.IsNullOrEmpty(txbPassword.Text)))
            {
                MessageBox.Show("Ambos os campos de nome e senha tem que ser preenchidos!");
            }
            else
            {
                MainMenu mainmenu = new MainMenu(txb.Text);
                mainmenu.ShowDialog();
                
                
            }
        }
    }
}
