using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX_Oyunu
{
    public partial class AnaMenu : Form
    {
        Player1 player1 = new Player1();
        Player2 players2 = new Player2(); 
        public AnaMenu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(rdo1Player.Checked == true)
            {
                player1.ShowDialog();
            }
            else if(rdo2Players.Checked == true)
            {
                players2.ShowDialog();
            }
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
