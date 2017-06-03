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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int[] click = new int[16];
        int turn = 1;
        int player = 0;
        int computer = 0;
        int[] board = new int[16];
        int[] boardpoint = new int[10];
        bool gameover = false;
        int biggest;
        int temp;

        Random rastgele = new Random();
        private void reset()
        {
            click[0] = 0;
            click[1] = 0;
            click[2] = 0;
            click[3] = 0;
            click[4] = 0;
            click[5] = 0;
            click[6] = 0;
            click[7] = 0;
            click[8] = 0;
            click[9] = 0;
            click[10] = 0;
            click[11] = 0;
            click[12] = 0;
            click[13] = 0;
            click[14] = 0;
            click[15] = 0;
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
            sira.Text = "Oyuncu";
            oyuncu.Text = "0";
            bilgisayar.Text = "0";
            gameover = false;
        }

        private void newgame()
        {
            click[0] = 0;
            click[1] = 0;
            click[2] = 0;
            click[3] = 0;
            click[4] = 0;
            click[5] = 0;
            click[6] = 0;
            click[7] = 0;
            click[8] = 0;
            click[9] = 0;
            click[10] = 0;
            click[11] = 0;
            click[12] = 0;
            click[13] = 0;
            click[14] = 0;
            click[15] = 0;
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
            sira.Text = "Oyuncu";
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
                            MessageBox.Show("Oyuncu Kazandı !");
                            player++;
                            oyuncu.Text = player.ToString();
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
                            MessageBox.Show("Oyuncu Kazandı !");
                            player++;
                            oyuncu.Text = player.ToString();
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
                            MessageBox.Show("Oyuncu Kazandı !");
                            player++;
                            oyuncu.Text = player.ToString();
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
                            MessageBox.Show("Oyuncu Kazandı !");
                            player++;
                            oyuncu.Text = player.ToString();
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
                            MessageBox.Show("Oyuncu Kazandı !");
                            player++;
                            oyuncu.Text = player.ToString();
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
                            MessageBox.Show("Oyuncu Kazandı !");
                            player++;
                            oyuncu.Text = player.ToString();
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
                            MessageBox.Show("Oyuncu Kazandı !");
                            player++;
                            oyuncu.Text = player.ToString();
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
                            MessageBox.Show("Oyuncu Kazandı !");
                            player++;
                            oyuncu.Text = player.ToString();
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
                            MessageBox.Show("Oyuncu Kazandı !");
                            player++;
                            oyuncu.Text = player.ToString();
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
                            MessageBox.Show("Oyuncu Kazandı !");
                            player++;
                            oyuncu.Text = player.ToString();
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
                            MessageBox.Show("Bilgisayar Kazandı !");
                            computer++;
                            bilgisayar.Text = computer.ToString();
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
                            MessageBox.Show("Bilgisayar Kazandı !");
                            computer++;
                            bilgisayar.Text = computer.ToString();
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
                            MessageBox.Show("Bilgisayar Kazandı !");
                            computer++;
                            bilgisayar.Text = computer.ToString();
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
                            MessageBox.Show("Bilgisayar Kazandı !");
                            computer++;
                            bilgisayar.Text = computer.ToString();
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
                            MessageBox.Show("Bilgisayar Kazandı !");
                            computer++;
                            bilgisayar.Text = computer.ToString();
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
                            MessageBox.Show("Bilgisayar Kazandı !");
                            computer++;
                            bilgisayar.Text = computer.ToString();
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
                            MessageBox.Show("Bilgisayar Kazandı !");
                            computer++;
                            bilgisayar.Text = computer.ToString();
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
                            MessageBox.Show("Bilgisayar Kazandı !");
                            computer++;
                            bilgisayar.Text = computer.ToString();
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
                            MessageBox.Show("Bilgisayar Kazandı !");
                            computer++;
                            bilgisayar.Text = computer.ToString();
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
                            MessageBox.Show("Bilgisayar Kazandı !");
                            computer++;
                            bilgisayar.Text = computer.ToString();
                            gameover = true;
                            return;
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(button1.Text) && !string.IsNullOrEmpty(button2.Text) && !string.IsNullOrEmpty(button3.Text) && !string.IsNullOrEmpty(button4.Text) && !string.IsNullOrEmpty(button5.Text) && !string.IsNullOrEmpty(button6.Text) && !string.IsNullOrEmpty(button7.Text) && !string.IsNullOrEmpty(button8.Text) && !string.IsNullOrEmpty(button9.Text) && !string.IsNullOrEmpty(button10.Text) && !string.IsNullOrEmpty(button11.Text) && !string.IsNullOrEmpty(button12.Text) && !string.IsNullOrEmpty(button13.Text) && !string.IsNullOrEmpty(button14.Text) && !string.IsNullOrEmpty(button15.Text) && !string.IsNullOrEmpty(button16.Text))
            {
                MessageBox.Show("Oyun Berabere !");
                player++;
                oyuncu.Text = player.ToString();
                computer++;
                bilgisayar.Text = computer.ToString();
                gameover = true;
                return;
            }
        }

        public void display()
        {
            if (turn % 2 != 0)
            {
                sira.Text = "Oyuncu";
            }
            else
            {
                sira.Text = "Bilgisayar";
            }
        }

        public void cmpplay()
        {
            if (gameover == false)
            {
                minmax();
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
                if (biggest == 0)
                {
                    if (click[0] == 1 && click[1] == 1 && click[2] == 1 && click[3] == 0)
                    {
                        button4.Text = "O";
                        click[3]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[0] == 1 && click[2] == 1 && click[3] == 1 && click[1] == 0)
                    {
                        button2.Text = "O";
                        click[1]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[0] == 1 && click[1] == 1 && click[3] == 1 && click[2] == 0)
                    {
                        button3.Text = "O";
                        click[2]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[1] == 1 && click[2] == 1 && click[3] == 1 && click[0] == 0)
                    {
                        button1.Text = "O";
                        click[0]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else
                    {
                        temp = rastgele.Next(1, 17);
                        cmprandom(temp);
                    }
                }
                else if (biggest == 1)
                {
                    if (click[4] == 1 && click[5] == 1 && click[6] == 1 && click[7] == 0)
                    {
                        button8.Text = "O";
                        click[7]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[4] == 1 && click[5] == 1 && click[7] == 1 && click[6] == 0)
                    {
                        button7.Text = "O";
                        click[6]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[4] == 1 && click[6] == 1 && click[7] == 1 && click[5] == 0)
                    {
                        button6.Text = "O";
                        click[5]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[5] == 1 && click[6] == 1 && click[7] == 1 && click[4] == 0)
                    {
                        button5.Text = "O";
                        click[4]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else
                    {
                        temp = rastgele.Next(1, 17);
                        cmprandom(temp);
                    }
                }
                else if (biggest == 2)
                {
                    if (click[8] == 1 && click[9] == 1 && click[10] == 1 && click[11] == 0)
                    {
                        button12.Text = "O";
                        click[11]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[8] == 1 && click[10] == 1 && click[11] == 1 && click[9] == 0)
                    {
                        button10.Text = "O";
                        click[9]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[8] == 1 && click[9] == 1 && click[11] == 1 && click[10] == 0)
                    {
                        button11.Text = "O";
                        click[10]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[9] == 1 && click[10] == 1 && click[11] == 1 && click[8] == 0)
                    {
                        button9.Text = "O";
                        click[8]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else
                    {
                        temp = rastgele.Next(1, 17);
                        cmprandom(temp);
                    }
                }

                else if (biggest == 3)
                {
                    if (click[12] == 1 && click[13] == 1 && click[14] == 1 && click[15] == 0)
                    {
                        button16.Text = "O";
                        click[15]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[12] == 1 && click[14] == 1 && click[15] == 1 && click[13] == 0)
                    {
                        button14.Text = "O";
                        click[13]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[12] == 1 && click[13] == 1 && click[15] == 1 && click[14] == 0)
                    {
                        button15.Text = "O";
                        click[14]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[13] == 1 && click[14] == 1 && click[15] == 1 && click[12] == 0)
                    {
                        button13.Text = "O";
                        click[12]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else
                    {
                        temp = rastgele.Next(1, 17);
                        cmprandom(temp);
                    }
                }
                else if (biggest == 4)
                {
                    if (click[0] == 1 && click[4] == 1 && click[8] == 1 && click[12] == 0)
                    {
                        button13.Text = "O";
                        click[12]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[4] == 1 && click[8] == 1 && click[12] == 1 && click[0] == 0)
                    {
                        button1.Text = "O";
                        click[0]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[0] == 1 && click[4] == 1 && click[12] == 1 && click[8] == 0)
                    {
                        button9.Text = "O";
                        click[8]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[0] == 1 && click[8] == 1 && click[12] == 1 && click[4] == 0)
                    {
                        button5.Text = "O";
                        click[4]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else
                    {
                        temp = rastgele.Next(1, 17);
                        cmprandom(temp);
                    }
                }
                else if (biggest == 5)
                {
                    if (click[1] == 1 && click[5] == 1 && click[9] == 1 && click[13] == 0)
                    {
                        button14.Text = "O";
                        click[13]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[5] == 1 && click[9] == 1 && click[13] == 1 && click[1] == 0)
                    {
                        button2.Text = "O";
                        click[1]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[1] == 1 && click[5] == 1 && click[13] == 1 && click[9] == 0)
                    {
                        button10.Text = "O";
                        click[9]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[1] == 1 && click[9] == 1 && click[13] == 1 && click[5] == 0)
                    {
                        button6.Text = "O";
                        click[5]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else
                    {
                        temp = rastgele.Next(1, 17);
                        cmprandom(temp);
                    }
                }
                else if (biggest == 6)
                {
                    if (click[2] == 1 && click[6] == 1 && click[10] == 1 && click[14] == 0)
                    {
                        button15.Text = "O";
                        click[14]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[2] == 1 && click[10] == 1 && click[14] == 1 && click[6] == 0)
                    {
                        button7.Text = "O";
                        click[6]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[6] == 1 && click[10] == 1 && click[14] == 1 && click[2] == 0)
                    {
                        button3.Text = "O";
                        click[2]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[2] == 1 && click[6] == 1 && click[14] == 1 && click[10] == 0)
                    {
                        button11.Text = "O";
                        click[10]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else
                    {
                        temp = rastgele.Next(1, 17);
                        cmprandom(temp);
                    }
                }
                else if (biggest == 7)
                {
                    if (click[3] == 1 && click[7] == 1 && click[11] == 1 && click[15] == 0)
                    {
                        button16.Text = "O";
                        click[15]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[3] == 1 && click[11] == 1 && click[15] == 1 && click[7] == 0)
                    {
                        button8.Text = "O";
                        click[7]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[7] == 1 && click[11] == 1 && click[15] == 1 && click[3] == 0)
                    {
                        button4.Text = "O";
                        click[3]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[3] == 1 && click[7] == 1 && click[15] == 1 && click[11] == 0)
                    {
                        button12.Text = "O";
                        click[11]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else
                    {
                        temp = rastgele.Next(1, 17);
                        cmprandom(temp);
                    }
                }
                else if (biggest == 8)
                {
                    if (click[0] == 1 && click[5] == 1 && click[10] == 1 && click[15] == 0)
                    {
                        button16.Text = "O";
                        click[15]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[0] == 1 && click[10] == 1 && click[15] == 1 && click[5] == 0)
                    {
                        button6.Text = "O";
                        click[5]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[5] == 1 && click[10] == 1 && click[15] == 1 && click[0] == 0)
                    {
                        button1.Text = "O";
                        click[0]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[0] == 1 && click[5] == 1 && click[15] == 1 && click[10] == 0)
                    {
                        button11.Text = "O";
                        click[10]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else
                    {
                        temp = rastgele.Next(1, 17);
                        cmprandom(temp);
                    }
                }
                else if (biggest == 9)
                {
                    if (click[3] == 1 && click[6] == 1 && click[9] == 1 && click[12] == 0)
                    {
                        button13.Text = "O";
                        click[12]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[3] == 1 && click[6] == 1 && click[12] == 1 && click[9] == 0)
                    {
                        button10.Text = "O";
                        click[9]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[3] == 1 && click[9] == 1 && click[12] == 1 && click[6] == 0)
                    {
                        button7.Text = "O";
                        click[6]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else if (click[6] == 1 && click[9] == 1 && click[12] == 1 && click[3] == 0)
                    {
                        button4.Text = "O";
                        click[3]++;
                        turn++;
                        display();
                        checkgame();
                    }
                    else
                    {
                        temp = rastgele.Next(1, 17);
                        cmprandom(temp);
                    }
                }
            }
        }
        private void foo(int b)
        {
            if (b == 1)
            {
                button1.Text = "O";
            }
            else if (b == 2)
            {
                button2.Text = "O";
            }
            else if (b == 3)
            {
                button3.Text = "O";
            }
            else if (b == 4)
            {
                button4.Text = "O";
            }
            else if (b == 5)
            {
                button5.Text = "O";
            }
            else if (b == 6)
            {
                button6.Text = "O";
            }
            else if (b == 7)
            {
                button7.Text = "O";
            }
            else if (b == 8)
            {
                button8.Text = "O";
            }
            else if (b == 9)
            {
                button9.Text = "O";
            }
            else if (b == 10)
            {
                button10.Text = "O";
            }
            else if (b == 11)
            {
                button11.Text = "O";
            }
            else if (b == 12)
            {
                button12.Text = "O";
            }
            else if (b == 13)
            {
                button13.Text = "O";
            }
            else if (b == 14)
            {
                button14.Text = "O";
            }
            else if (b == 15)
            {
                button15.Text = "O";
            }
            else if (b == 16)
            {
                button16.Text = "O";
            }
        }
        private void cmprandom(int a)
        {
            int j;
            for (j = 1; j < 17; j++)
            {
                if (a == j)
                {
                    if (click[j-1] == 0)
                    {
                        foo(j);
                        click[j-1]++;
                        turn++;
                        display();
                        checkgame();
                        break;
                    }
                    else
                    {
                        a = rastgele.Next(1, 17);
                        j = 0;
                    }
                }
            }
        }
        private void checkboard()
        {
            if (button1.Text == "X")
            {
                board[0] = 10;
            }
            else if (button1.Text == "O")
            {
                board[0] = -10;
            }
            else
            {
                board[0] = 0;
            }


            if (button2.Text == "X")
            {
                board[1] = 10;
            }
            else if (button2.Text == "O")
            {
                board[1] = -10;
            }
            else
            {
                board[1] = 0;
            }


            if (button3.Text == "X")
            {
                board[2] = 10;
            }
            else if (button3.Text == "O")
            {
                board[2] = -10;
            }
            else
            {
                board[2] = 0;
            }


            if (button4.Text == "X")
            {
                board[3] = 10;
            }
            else if (button4.Text == "O")
            {
                board[3] = -10;
            }
            else
            {
                board[3] = 0;
            }


            if (button5.Text == "X")
            {
                board[4] = 10;
            }
            else if (button5.Text == "O")
            {
                board[4] = -10;
            }
            else
            {
                board[4] = 0;
            }


            if (button6.Text == "X")
            {
                board[5] = 10;
            }
            else if (button6.Text == "O")
            {
                board[5] = -10;
            }
            else
            {
                board[5] = 0;
            }


            if (button7.Text == "X")
            {
                board[6] = 10;
            }
            else if (button7.Text == "O")
            {
                board[6] = -10;
            }
            else
            {
                board[6] = 0;
            }


            if (button8.Text == "X")
            {
                board[7] = 10;
            }
            else if (button8.Text == "O")
            {
                board[7] = -10;
            }
            else
            {
                board[7] = 0;
            }


            if (button9.Text == "X")
            {
                board[8] = 10;
            }
            else if (button9.Text == "O")
            {
                board[8] = -10;
            }
            else
            {
                board[8] = 0;
            }


            if (button10.Text == "X")
            {
                board[9] = 10;
            }
            else if (button10.Text == "O")
            {
                board[9] = -10;
            }
            else
            {
                board[9] = 0;
            }


            if (button11.Text == "X")
            {
                board[10] = 10;
            }
            else if (button11.Text == "O")
            {
                board[10] = -10;
            }
            else
            {
                board[10] = 0;
            }


            if (button12.Text == "X")
            {
                board[11] = 10;
            }
            else if (button12.Text == "O")
            {
                board[11] = -10;
            }
            else
            {
                board[11] = 0;
            }


            if (button13.Text == "X")
            {
                board[12] = 10;
            }
            else if (button13.Text == "O")
            {
                board[12] = -10;
            }
            else
            {
                board[12] = 0;
            }


            if (button14.Text == "X")
            {
                board[13] = 10;
            }
            else if (button14.Text == "O")
            {
                board[13] = -10;
            }
            else
            {
                board[13] = 0;
            }


            if (button15.Text == "X")
            {
                board[14] = 10;
            }
            else if (button15.Text == "O")
            {
                board[14] = -10;
            }
            else
            {
                board[14] = 0;
            }


            if (button16.Text == "X")
            {
                board[15] = 10;
            }
            else if (button16.Text == "O")
            {
                board[15] = -10;
            }
            else
            {
                board[15] = 0;
            }
        }

        private void pointit()
        {
            boardpoint[0] = board[0] + board[1] + board[2] + board[3];
            boardpoint[1] = board[4] + board[5] + board[6] + board[7];
            boardpoint[2] = board[8] + board[9] + board[10] + board[11];
            boardpoint[3] = board[12] + board[13] + board[14] + board[15];
            boardpoint[4] = board[0] + board[4] + board[8] + board[12];
            boardpoint[5] = board[1] + board[5] + board[9] + board[13];
            boardpoint[6] = board[2] + board[6] + board[10] + board[14];
            boardpoint[7] = board[3] + board[7] + board[11] + board[15];
            boardpoint[8] = board[0] + board[5] + board[10] + board[15];
            boardpoint[9] = board[3] + board[6] + board[9] + board[12];
        }

        private void minmax()
        {
            checkboard();
            pointit();
            int highest = 0;
            biggest = 0;
            for (int i = 0; i < boardpoint.Length; i++)
            {
                if (boardpoint[i] == -30)
                {
                    biggest = i;
                    break;
                }
                else if (boardpoint[i] == 30)
                {
                    biggest = i;
                    break;
                }
                else if (boardpoint[i] > highest)
                {
                    biggest = i;
                }
                else
                {
                    biggest = rastgele.Next(0,10);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (click[0] == 0 && gameover==false)
            {
                button1.Text = "X";
                turn++;
                click[0]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (click[1] == 0 && gameover == false)
            {
                button2.Text = "X";
                turn++;
                click[1]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (click[2] == 0 && gameover == false)
            {
                button3.Text = "X";
                turn++;
                click[2]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (click[3] == 0 && gameover == false)
            {
                button4.Text = "X";
                turn++;
                click[3]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (click[4] == 0 && gameover == false)
            {
                button5.Text = "X";
                turn++;
                click[4]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click[5] == 0 && gameover == false)
            {
                button6.Text = "X";
                turn++;
                click[5]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click[6] == 0 && gameover == false)
            {
                button7.Text = "X";
                turn++;
                click[6]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (click[7] == 0 && gameover == false)
            {
                button8.Text = "X";
                turn++;
                click[7]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (click[8] == 0 && gameover == false)
            {
                button9.Text = "X";
                turn++;
                click[8]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (click[9] == 0 && gameover == false)
            {
                button10.Text = "X";
                turn++;
                click[9]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (click[10] == 0 && gameover == false)
            {
                button11.Text = "X";
                turn++;
                click[10]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (click[11] == 0 && gameover == false)
            {
                button12.Text = "X";
                turn++;
                click[11]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (click[12] == 0 && gameover == false)
            {
                button13.Text = "X";
                turn++;
                click[12]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (click[13] == 0 && gameover == false)
            {
                button14.Text = "X";
                turn++;
                click[13]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (click[14] == 0 && gameover == false)
            {
                button15.Text = "X";
                turn++;
                click[14]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (click[15] == 0 && gameover == false)
            {
                button16.Text = "X";
                turn++;
                click[15]++;
                display();
                checkgame();
                cmpplay();
            }
            else
            {
                MessageBox.Show("Bu kare dolu olduğundan oynayamazsınız veya Oyun zaten bitti!", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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