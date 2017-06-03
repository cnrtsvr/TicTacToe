using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int click1 = 0;
        int click2 = 0;
        int click3 = 0;
        int click4 = 0;
        int click5 = 0;
        int click6 = 0;
        int click7 = 0;
        int click8 = 0;
        int click9 = 0;
        int click10 = 0;
        int click11 = 0;
        int click12 = 0;
        int click13 = 0;
        int click14 = 0;
        int click15 = 0;
        int click16 = 0;
        int turn = 1;
        int player1 = 0;
        int player2 = 0;
        bool gameover;

        private void reset()
        {
            click1 = 0;
            click2 = 0;
            click3 = 0;
            click4 = 0;
            click5 = 0;
            click6 = 0;
            click7 = 0;
            click8 = 0;
            click9 = 0;
            click10 = 0;
            click11 = 0;
            click12 = 0;
            click13 = 0;
            click14 = 0;
            click15 = 0;
            click16 = 0;
            turn = 1;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            sira.Text = "1. Oyuncu";
            label4.Text = "0";
            label5.Text = "0";
            gameover = false;
        }

        private void newgame()
        {
            click1 = 0;
            click2 = 0;
            click3 = 0;
            click4 = 0;
            click5 = 0;
            click6 = 0;
            click7 = 0;
            click8 = 0;
            click9 = 0;
            click10 = 0;
            click11 = 0;
            click12 = 0;
            click13 = 0;
            click14 = 0;
            click15 = 0;
            click16 = 0;
            turn = 1;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            sira.Text = "1. Oyuncu";
            gameover = false;
        }

        private void checkgame()
        {

            if (button1.Text == "X")
            {
                if (button2.Text == "X")
                {
                    if (button2.Text == "X")
                    {
                        if (button4.Text == "X")
                        {
                            MessageBox.Show("1. Oyuncu Kazandı !");
                            player1++;
                            label4.Text = player1.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button5.Text == "X")
            {
                if (button6.Text == "X")
                {
                    if (button7.Text == "X")
                    {
                        if (button8.Text == "X")
                        {
                            MessageBox.Show("1. Oyuncu Kazandı !");
                            player1++;
                            label4.Text = player1.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button9.Text == "X")
            {
                if (button10.Text == "X")
                {
                    if (button11.Text == "X")
                    {
                        if (button12.Text == "X")
                        {
                            MessageBox.Show("1. Oyuncu Kazandı !");
                            player1++;
                            label4.Text = player1.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button13.Text == "X")
            {
                if (button14.Text == "X")
                {
                    if (button15.Text == "X")
                    {
                        if (button16.Text == "X")
                        {
                            MessageBox.Show("1. Oyuncu Kazandı !");
                            player1++;
                            label4.Text = player1.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button1.Text == "X")
            {
                if (button5.Text == "X")
                {
                    if (button9.Text == "X")
                    {
                        if (button13.Text == "X")
                        {
                            MessageBox.Show("1. Oyuncu Kazandı !");
                            player1++;
                            label4.Text = player1.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button2.Text == "X")
            {
                if (button6.Text == "X")
                {
                    if (button10.Text == "X")
                    {
                        if (button14.Text == "X")
                        {
                            MessageBox.Show("1. Oyuncu Kazandı !");
                            player1++;
                            label4.Text = player1.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button3.Text == "X")
            {
                if (button7.Text == "X")
                {
                    if (button11.Text == "X")
                    {
                        if (button15.Text == "X")
                        {
                            MessageBox.Show("1. Oyuncu Kazandı !");
                            player1++;
                            label4.Text = player1.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button4.Text == "X")
            {
                if (button8.Text == "X")
                {
                    if (button12.Text == "X")
                    {
                        if (button16.Text == "X")
                        {
                            MessageBox.Show("1. Oyuncu Kazandı !");
                            player1++;
                            label4.Text = player1.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button1.Text == "X")
            {
                if (button6.Text == "X")
                {
                    if (button11.Text == "X")
                    {
                        if (button16.Text == "X")
                        {
                            MessageBox.Show("1. Oyuncu Kazandı !");
                            player1++;
                            label4.Text = player1.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button4.Text == "X")
            {
                if (button7.Text == "X")
                {
                    if (button10.Text == "X")
                    {
                        if (button13.Text == "X")
                        {
                            MessageBox.Show("1. Oyuncu Kazandı !");
                            player1++;
                            label4.Text = player1.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button1.Text == "O")
            {
                if (button2.Text == "O")
                {
                    if (button3.Text == "O")
                    {
                        if (button4.Text == "O")
                        {
                            MessageBox.Show("2. Oyuncu Kazandı !");
                            player2++;
                            label5.Text = player2.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button5.Text == "O")
            {
                if (button6.Text == "O")
                {
                    if (button7.Text == "O")
                    {
                        if (button8.Text == "O")
                        {
                            MessageBox.Show("2. Oyuncu Kazandı !");
                            player2++;
                            label5.Text = player2.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button9.Text == "O")
            {
                if (button10.Text == "O")
                {
                    if (button11.Text == "O")
                    {
                        if (button12.Text == "O")
                        {
                            MessageBox.Show("2. Oyuncu Kazandı !");
                            player2++;
                            label5.Text = player2.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button13.Text == "O")
            {
                if (button14.Text == "O")
                {
                    if (button15.Text == "O")
                    {
                        if (button16.Text == "O")
                        {
                            MessageBox.Show("2. Oyuncu Kazandı !");
                            player2++;
                            label5.Text = player2.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button1.Text == "O")
            {
                if (button5.Text == "O")
                {
                    if (button9.Text == "O")
                    {
                        if (button13.Text == "O")
                        {
                            MessageBox.Show("2. Oyuncu Kazandı !");
                            player2++;
                            label5.Text = player2.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button2.Text == "O")
            {
                if (button6.Text == "O")
                {
                    if (button10.Text == "O")
                    {
                        if (button14.Text == "O")
                        {
                            MessageBox.Show("2. Oyuncu Kazandı !");
                            player2++;
                            label5.Text = player2.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button3.Text == "O")
            {
                if (button7.Text == "O")
                {
                    if (button11.Text == "O")
                    {
                        if (button15.Text == "O")
                        {
                            MessageBox.Show("2. Oyuncu Kazandı !");
                            player2++;
                            label5.Text = player2.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button4.Text == "O")
            {
                if (button8.Text == "O")
                {
                    if (button12.Text == "O")
                    {
                        if (button16.Text == "O")
                        {
                            MessageBox.Show("2. Oyuncu Kazandı !");
                            player2++;
                            label5.Text = player2.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button1.Text == "O")
            {
                if (button6.Text == "O")
                {
                    if (button11.Text == "O")
                    {
                        if (button16.Text == "O")
                        {
                            MessageBox.Show("2. Oyuncu Kazandı !");
                            player2++;
                            label5.Text = player2.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (button4.Text == "O")
            {
                if (button7.Text == "O")
                {
                    if (button10.Text == "O")
                    {
                        if (button13.Text == "O")
                        {
                            MessageBox.Show("2. Oyuncu Kazandı !");
                            player2++;
                            label5.Text = player2.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(button1.Text) && !string.IsNullOrEmpty(button2.Text) && !string.IsNullOrEmpty(button3.Text) && !string.IsNullOrEmpty(button4.Text) && !string.IsNullOrEmpty(button5.Text) && !string.IsNullOrEmpty(button6.Text) && !string.IsNullOrEmpty(button7.Text) && !string.IsNullOrEmpty(button8.Text) && !string.IsNullOrEmpty(button9.Text) && !string.IsNullOrEmpty(button10.Text) && !string.IsNullOrEmpty(button11.Text) && !string.IsNullOrEmpty(button12.Text) && !string.IsNullOrEmpty(button13.Text) && !string.IsNullOrEmpty(button14.Text) && !string.IsNullOrEmpty(button15.Text) && !string.IsNullOrEmpty(button16.Text))
            {
                MessageBox.Show("Oyun Berabere !");
                player1++;
                label4.Text = player1.ToString();
                player2++;
                label5.Text = player2.ToString();
                gameover = true;
                return;
            }
        }

        public void display()
        {
            if (turn % 2 != 0)
            {
                sira.Text = "1. Oyuncu";
            }
            else
            {
                sira.Text = "2. Oyuncu";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (click1 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button1.Text = "X";
                }
                else
                {
                    button1.Text = "O";
                }
                turn++;
                click1++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (click2 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button2.Text = "X";
                }
                else
                {
                    button2.Text = "O";
                }
                turn++;
                click2++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (click3 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button3.Text = "X";
                }
                else
                {
                    button3.Text = "O";
                }
                turn++;
                click3++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (click4 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button4.Text = "X";
                }
                else
                {
                    button4.Text = "O";
                }
                turn++;
                click4++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (click5 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button5.Text = "X";
                }
                else
                {
                    button5.Text = "O";
                }
                turn++;
                click5++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click6 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button6.Text = "X";
                }
                else
                {
                    button6.Text = "O";
                }
                turn++;
                click6++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click7 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button7.Text = "X";
                }
                else
                {
                    button7.Text = "O";
                }
                turn++;
                click7++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (click8 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button8.Text = "X";
                }
                else
                {
                    button8.Text = "O";
                }
                turn++;
                click8++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (click9 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button9.Text = "X";
                }
                else
                {
                    button9.Text = "O";
                }
                turn++;
                click9++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (click10 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button10.Text = "X";
                }
                else
                {
                    button10.Text = "O";
                }
                turn++;
                click10++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (click11 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button11.Text = "X";
                }
                else
                {
                    button11.Text = "O";
                }
                turn++;
                click11++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (click12 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button12.Text = "X";
                }
                else
                {
                    button12.Text = "O";
                }
                turn++;
                click12++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (click13 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button13.Text = "X";
                }
                else
                {
                    button13.Text = "O";
                }
                turn++;
                click13++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (click14 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button14.Text = "X";
                }
                else
                {
                    button14.Text = "O";
                }
                turn++;
                click14++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (click15 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button15.Text = "X";
                }
                else
                {
                    button15.Text = "O";
                }
                turn++;
                click15++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (click16 == 0 && gameover == false)
            {
                if (turn % 2 != 0)
                {
                    button16.Text = "X";
                }
                else
                {
                    button16.Text = "O";
                }
                turn++;
                click16++;
                display();
                checkgame();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitmiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            newgame();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
