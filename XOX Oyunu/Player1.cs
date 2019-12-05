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
    public partial class Player1 : Form
    {
        int donmesayisi = 0;
        bool dondur = true, kontrol;
        public Player1()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            dondur = !dondur;
            b.Text = "X";  
            b.Enabled = false;
            donmesayisi++;
            KazananKontrolu();
            if(!kontrol)
            {
                Bilgisayarhamle();
                dondur = !dondur;
                KazananKontrolu();
            }
        }
        private void KazananKontrolu()
        {
            string kazanan = "";
            bool kazananvarmi = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                kazananvarmi = true;
                kazanan = A1.Text;
            }        
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                kazananvarmi = true;
                kazanan = B1.Text;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                kazananvarmi = true;
                kazanan = C1.Text;
            }
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                kazananvarmi = true;
                kazanan = A1.Text;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                kazananvarmi = true;
                kazanan = A2.Text;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                kazananvarmi = true;
                kazanan = A3.Text;
            }
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                kazananvarmi = true;
                kazanan = A1.Text;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                kazananvarmi = true;
                kazanan = A3.Text;
            }
            if (kazananvarmi)
            {
                disableButtons();
                timer1.Enabled = false;
                MessageBox.Show(kazanan +"  Kazandı!");
                kontrol = true;
                YeniOyun();
            }
            else
            {
                if(donmesayisi ==9)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Berabere");
                    kontrol = true;
                    YeniOyun();
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
            kontrol = false;
            time.Value = 10;
            timer1.Enabled = true;
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
        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniOyun();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            YeniOyun();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dondur)
                time.Value--;
            else
            {
                time.Value++;
            }

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
        private void Bilgisayarhamle()
        {
            System.Threading.Thread.Sleep(200);
            if (A1.Text == "O" && A2.Text == "O" && A3.Enabled == true)
            {
                A3.Text = "O";
                A3.Enabled = false;
                donmesayisi++;
            }
            else if (A1.Text == "O" && A3.Text == "O" && A2.Enabled == true)
            {
                A2.Text = "O";
                A2.Enabled = false;
                donmesayisi++;
            }
            else if (A2.Text == "O" && A3.Text == "O" && A1.Enabled == true)
            {
                A1.Text = "O";
                A1.Enabled = false;
                donmesayisi++;
            }
            else if (B1.Text == "O" && B2.Text == "O" && B3.Enabled == true)
            {
                B3.Text = "O";
                B3.Enabled = false;
                donmesayisi++;
            }
            else if (B1.Text == "O" && B3.Text == "O" && B2.Enabled == true)
            {
                B2.Text = "O";
                B2.Enabled = false;
                donmesayisi++;
            }
            else if (B2.Text == "O" && B3.Text == "O" && B1.Enabled == true)
            {
                B1.Text = "O";
                B1.Enabled = false;
                donmesayisi++;
            }
            else if (C1.Text == "O" && C2.Text == "O" && C3.Enabled == true)
            {
                C3.Text = "O";
                C3.Enabled = false;
                donmesayisi++;
            }
            else if (C1.Text == "O" && C3.Text == "O" && C2.Enabled == true)
            {
                C2.Text = "O";
                C2.Enabled = false;
                donmesayisi++;
            }
            else if (C2.Text == "O" && C3.Text == "O" && C1.Enabled == true)
            {
                C1.Text = "O";
                C1.Enabled = false;
                donmesayisi++;
            }
            else if (A1.Text == "O" && B1.Text == "O" && C1.Enabled == true)
            {
                C1.Text = "O";
                C1.Enabled = false;
                donmesayisi++;
            }
            else if (A1.Text == "O" && C1.Text == "O" && B1.Enabled == true)
            {
                B1.Text = "O";
                B1.Enabled = false;
                donmesayisi++;
            }
            else if (B1.Text == "O" && C1.Text == "O" && A1.Enabled == true)
            {
                A1.Text = "O";
                A1.Enabled = false;
                donmesayisi++;
            }
            else if (A2.Text == "O" && B2.Text == "O" && C2.Enabled == true)
            {
                C2.Text = "O";
                C2.Enabled = false;
                donmesayisi++;
            }
            else if (A2.Text == "O" && C2.Text == "O" && B2.Enabled == true)
            {
                B2.Text = "O";
                B2.Enabled = false;
                donmesayisi++;
            }
            else if (B2.Text == "O" && C2.Text == "O" && A2.Enabled == true)
            {
                A2.Text = "O";
                A2.Enabled = false;
                donmesayisi++;
            }
            else if (A3.Text == "O" && B3.Text == "O" && C3.Enabled == true)
            {
                C3.Text = "O";
                C3.Enabled = false;
                donmesayisi++;
            }
            else if (A3.Text == "O" && C3.Text == "O" && B3.Enabled == true)
            {
                B3.Text = "O";
                B3.Enabled = false;
                donmesayisi++;
            }
            else if (B3.Text == "O" && C3.Text == "O" && A3.Enabled == true)
            {
                A3.Text = "O";
                A3.Enabled = false;
                donmesayisi++;
            }
            else if (A1.Text == "O" && B2.Text == "O" && C3.Enabled == true)
            {
                C3.Text = "O";
                C3.Enabled = false;
                donmesayisi++;
            }
            else if (A1.Text == "O" && C3.Text == "O" && B2.Enabled == true)
            {
                B2.Text = "O";
                B2.Enabled = false;
                donmesayisi++;
            }
            else if (B2.Text == "O" && C3.Text == "O" && A1.Enabled == true)
            {
                A1.Text = "O";
                A1.Enabled = false;
                donmesayisi++;
            }
            else if (A3.Text == "O" && B2.Text == "O" && C1.Enabled == true)
            {
                C1.Text = "O";
                C1.Enabled = false;
                donmesayisi++;
            }
            else if (A3.Text == "O" && C1.Text == "O" && B2.Enabled == true)
            {
                B2.Text = "O";
                B2.Enabled = false;
                donmesayisi++;
            }
            else if (B2.Text == "O" && C1.Text == "O" && A3.Enabled == true)
            {
                A3.Text = "O";
                A3.Enabled = false;
                donmesayisi++;
            } 
            else if (A1.Text == "X" && A2.Text == "X" && A3.Enabled == true)
            {
                A3.Text= "O";
                A3.Enabled = false;
                donmesayisi++;
            }
            else if (A1.Text == "X" && A3.Text == "X" && A2.Enabled == true)
            {
                A2.Text = "O";
                A2.Enabled = false;
                donmesayisi++;
            }
            else if (A2.Text == "X" && A3.Text == "X" && A1.Enabled == true)
            {
                A1.Text = "O";
                A1.Enabled = false;
                donmesayisi++;
            }
            else if (B1.Text == "X" && B2.Text == "X" && B3.Enabled == true)
            {
                B3.Text = "O";
                B3.Enabled = false;
                donmesayisi++;
            }
            else if (B1.Text == "X" && B3.Text == "X" && B2.Enabled == true)
            {
                B2.Text = "O";
                B2.Enabled = false;
                donmesayisi++;
            }
            else if (B2.Text == "X" && B3.Text == "X" && B1.Enabled == true)
            {
                B1.Text = "O";
                B1.Enabled = false;
                donmesayisi++;
            }
            else if (C1.Text == "X" && C2.Text == "X" && C3.Enabled == true)
            {
                C3.Text = "O";
                C3.Enabled = false;
                donmesayisi++;
            }
            else if (C1.Text == "X" && C3.Text == "X" && C2.Enabled == true)
            {
                C2.Text = "O";
                C2.Enabled = false;
                donmesayisi++;
            }
            else if (C2.Text == "X" && C3.Text == "X" && C1.Enabled == true)
            {
                C1.Text = "O";
                C1.Enabled = false;
                donmesayisi++;
            }
            else if (A1.Text == "X" && B1.Text == "X" && C1.Enabled == true)
            {
                C1.Text = "O";
                C1.Enabled = false;
                donmesayisi++;
            }
            else if (A1.Text == "X" && C1.Text == "X" && B1.Enabled == true)
            {
                B1.Text = "O";
                B1.Enabled = false;
                donmesayisi++;
            }
            else if (B1.Text == "X" && C1.Text == "X" && A1.Enabled == true)
            {
                A1.Text = "O";
                A1.Enabled = false;
                donmesayisi++;
            }
            else if (A2.Text == "X" && B2.Text == "X" && C2.Enabled == true)
            {
                C2.Text = "O";
                C2.Enabled = false;
                donmesayisi++;
            }
            else if (A2.Text == "X" && C2.Text == "X" && B2.Enabled == true)
            {
                B2.Text = "O";
                B2.Enabled = false;
                donmesayisi++;
            }
            else if (B2.Text == "X" && C2.Text == "X" && A2.Enabled == true)
            {
                A2.Text = "O";
                A2.Enabled = false;
                donmesayisi++;
            }
            else if (A3.Text == "X" && B3.Text == "X" && C3.Enabled == true)
            {
                C3.Text = "O";
                C3.Enabled = false;
                donmesayisi++;
            }
            else if (A3.Text == "X" && C3.Text == "X" && B3.Enabled == true)
            {
                B3.Text = "O";
                B3.Enabled = false;
                donmesayisi++;
            }
            else if (B3.Text == "X" && C3.Text == "X" && A3.Enabled == true)
            {
                A3.Text = "O";
                A3.Enabled = false;
                donmesayisi++;
            }
            else if (A1.Text == "X" && B2.Text == "X" && C3.Enabled == true)
            {
                C3.Text = "O";
                C3.Enabled = false;
                donmesayisi++;
            }
            else if (A1.Text == "X" && C3.Text == "X" && B2.Enabled == true)
            {
                B2.Text = "O";
                B2.Enabled = false;
                donmesayisi++;
            }
            else if (B2.Text == "X" && C3.Text == "X" && A1.Enabled == true)
            {
                A1.Text = "O";
                A1.Enabled = false;
                donmesayisi++;
            }
            else if (A3.Text == "X" && B2.Text == "X" && C1.Enabled == true)
            {
                C1.Text = "O";
                C1.Enabled = false;
                donmesayisi++;
            }
            else if (A3.Text == "X" && C1.Text == "X" && B2.Enabled == true)
            {
                B2.Text = "O";
                B2.Enabled = false;
                donmesayisi++;
            }
            else if (B2.Text == "X" && C1.Text == "X" && A3.Enabled == true)
            {
                A3.Text = "O";
                A3.Enabled = false;
                donmesayisi++;
            }
            else
            {
                Random sayi = new Random();
                int pozisyon = sayi.Next(1, 10);
                switch (pozisyon)
                {
                    case 1:
                        if (A1.Text != "" && A1.Enabled == false)
                        {
                            Bilgisayarhamle();
                        }
                        else
                        {
                            A1.Text = "O";
                            A1.Enabled = false;
                            donmesayisi++;
                        }
                        break;
                    case 2:
                        if (A2.Text != "" && A2.Enabled == false)
                        {
                            Bilgisayarhamle();
                        }
                        else
                        {
                            A2.Text = "O";
                            A2.Enabled = false;
                            donmesayisi++;
                        }
                        break;
                    case 3:
                        if (A3.Text != "" && A3.Enabled == false)
                        {
                            Bilgisayarhamle();
                        }
                        else
                        {
                            A3.Text = "O";
                            A3.Enabled = false;
                            donmesayisi++;
                        }
                        break;
                    case 4:
                        if (B1.Text != "" && B1.Enabled == false)
                        {
                            Bilgisayarhamle();
                        }
                        else
                        {
                            B1.Text = "O";
                            B1.Enabled = false;
                            donmesayisi++;
                        }
                        break;
                    case 5:
                        if (B2.Text != "" && B2.Enabled == false)
                        {
                            Bilgisayarhamle();
                        }
                        else
                        {
                            B2.Text = "O";
                            B2.Enabled = false;
                            donmesayisi++;
                        }
                        break;
                    case 6:
                        if (B3.Text != "" && B3.Enabled == false)
                        {
                            Bilgisayarhamle();
                        }
                        else
                        {
                            B3.Text = "O";
                            B3.Enabled = false;
                            donmesayisi++;
                        }
                        break;
                    case 7:
                        if (C1.Text != "" && C1.Enabled == false)
                        {
                            Bilgisayarhamle();
                        }
                        else
                        {
                            C1.Text = "O";
                            C1.Enabled = false;
                            donmesayisi++;
                        }
                        break;
                    case 8:
                        if (C2.Text != "" && C2.Enabled == false)
                        {
                            Bilgisayarhamle();
                        }
                        else
                        {
                            C2.Text = "O";
                            C2.Enabled = false;
                            donmesayisi++;
                        }
                        break;
                    case 9:
                        if (C3.Text != "" && C3.Enabled == false)
                        {
                            Bilgisayarhamle();
                        }
                        else
                        {
                            C3.Text = "O";
                            C3.Enabled = false;
                            donmesayisi++;
                        }
                        break;
                }
            }
        }
    }
}
