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
    public partial class Player2 : Form
    {
        bool dondur = true;
        int donmesayisi = 0;
        public Player2()
        {
            InitializeComponent();
        }
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (dondur)
                b.Text = "X";        
            else
                b.Text = "O";
            dondur = !(dondur);
            b.Enabled = false;
            donmesayisi++;
            KazananKontrolu();
        }
        private void KazananKontrolu()
        {
            bool kazananvarmi = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                kazananvarmi = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                kazananvarmi = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                kazananvarmi = true;
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                kazananvarmi = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                kazananvarmi = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                kazananvarmi = true;
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                kazananvarmi = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                kazananvarmi = true;
            if (kazananvarmi)
            {
                disableButtons();
                String kazanan = "";
                if (dondur)
                    kazanan = "O";
                else
                    kazanan = "X";
                MessageBox.Show(kazanan + "  Kazandı!");
                timer1.Enabled = false;
            }
            else
            {
                if (donmesayisi == 9)
                {
                    MessageBox.Show("Berabere");
                    timer1.Enabled = false;
                }
            }
        }
        private void disableButtons()
        {
            A1.Enabled = false;
            A2.Enabled = false;
            A3.Enabled = false;
            B1.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;
            C1.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;
        }
        private void YeniOyun()
        {
            time.Value = 10;
            timer1.Enabled = true;
            dondur = true;
            donmesayisi = 0;
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniOyun();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dondur)
                time.Value--;
            else
                time.Value++;
            if (time.Value == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("O Kazandı!");
                disableButtons();
            }
            if (time.Value == 20)
            {
                timer1.Enabled = false;
                MessageBox.Show("X Kazandı!");
                disableButtons();
            }
        }
        private void Player2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            YeniOyun();
        }
    }
}
