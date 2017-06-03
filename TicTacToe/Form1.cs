using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Threading;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 biroyuncu = new Form2();
        Form3 ikioyuncu = new Form3();
        Hakkinda about = new Hakkinda();
	
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            biroyuncu.ShowDialog();
            this.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ikioyuncu.ShowDialog();
            this.Show();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void ticTacToeHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   TicTaToe oyununda bir oyuncu 'X' ile, diğeri 'O' ile oynar. \n   Amaç mümkün olduğunca rakibin yanlara doğru, aşağı doğru veya çapraz olarak 3 kareye de kendi işaretini koymayı engellemek, ve aynı şekilde 3 kareye kendi işaretinizi koymaktır.\n   3 kareye kendi işaretini koyan oyuncu oyunu kazanır.", "TicTacToe Hakkında");
        }

        private void programHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            about.ShowDialog();
            this.Show();
        }
    }
}
