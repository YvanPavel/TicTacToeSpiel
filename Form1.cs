using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeSpiel
{
    public partial class Form1 : Form
    {
        public int Spieler = 2;
        public int züge = 0;
        public int sp1 = 0;
        public int sp2= 0;
        public int Unt=0;

        public bool IstUnentschieden()
        {
            if((züge ==9 ) && (IstTictac() ==false))
            {
                return true;    
            }else
                return false;
        }
        public bool IstTictac()
        {
            if((button1.Text == button2.Text) && (button3.Text == button1.Text) && (button2.Text != ""))
                return true;
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (button9.Text != ""))
                return true;
           else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (button4.Text != ""))
                return true;
            else if ((button5.Text == button2.Text) && (button2.Text == button8.Text) && (button8.Text != ""))
                return true;
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (button6.Text != ""))
                return true;
           else if ((button9.Text == button8.Text) && (button8.Text == button7.Text) && (button7.Text != ""))
                return true;
            else if ((button9.Text == button6.Text) && (button6.Text == button3.Text) && (button3.Text != ""))
                return true;
           else if ((button3.Text == button5.Text) && (button3.Text == button7.Text) && (button5.Text != ""))
                return true;
            else return false;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = " Spieler 1: " + sp1;
            label2.Text = " Spieler 2: " + sp2;
            label3.Text = " Untentschieden: " + Unt;

        }

        private void Spielen_Click(object sender, EventArgs e)
        {
            NeueSpielen();
        }
        public void NeueSpielen()
        {
            Spieler = 2;
            züge = 0;
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";

            label1.Text = " Spieler 1: " + sp1;
            label2.Text = " Spieler 2: " + sp2;
            label3.Text = " Unentschieden: " + Unt;

        }

        private void Beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            
            sp1 = sp2 = Unt = 0;
            NeueSpielen();
        }
        private void buttonclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Text == "")
            {
                if (Spieler % 2 == 0)
                {
                    button.Text = "X";
                    Spieler++;
                    züge++;

                }
                else
                {
                    button.Text = "O";
                    Spieler++;
                    züge++;
                }
                if(IstUnentschieden() == true)
                {
                    MessageBox.Show("Unenschieden");
                    Unt++;
                    NeueSpielen();
                }
                if (IstTictac() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("Spieler 1 gewinn");
                        sp1++;
                        NeueSpielen();
                    }
                    else
                    {
                        MessageBox.Show("Spieler 2 gewinn");
                        sp2++;
                    }
                    NeueSpielen();
                }
                    
            }
        }
    }
}
