using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOgame
{
    public partial class Form1 : Form
    {
        enum ValueXO { Empty, X, O }

        bool isPlayerXStep;
        bool isGameOver;

        ValueXO btn11, btn12, btn13, btn21, btn22, btn23, btn31, btn32, btn33;

        private void button23_Click(object sender, EventArgs e)
        {
            if (btn23 == ValueXO.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button23.ImageIndex = 1;
                    btn23 = ValueXO.X;
                }
                else
                {
                    button23.ImageIndex = 6;
                    btn23 = ValueXO.O;
                }

                Game();

                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (btn31 == ValueXO.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button31.ImageIndex = 1;
                    btn31 = ValueXO.X;
                }
                else
                {
                    button31.ImageIndex = 6;
                    btn31 = ValueXO.O;
                }

                Game();

                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (btn32 == ValueXO.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button32.ImageIndex = 1;
                    btn32 = ValueXO.X;
                }
                else
                {
                    button32.ImageIndex = 6;
                    btn32 = ValueXO.O;
                }

                Game();

                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (btn33 == ValueXO.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button33.ImageIndex = 1;
                    btn33 = ValueXO.X;
                }
                else
                {
                    button33.ImageIndex = 6;
                    btn33 = ValueXO.O;
                }

                Game();

                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (btn22 == ValueXO.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button22.ImageIndex = 1;
                    btn22 = ValueXO.X;
                }
                else
                {
                    button22.ImageIndex = 6;
                    btn22 = ValueXO.O;
                }

                Game();

                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (btn21 == ValueXO.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button21.ImageIndex = 1;
                    btn21 = ValueXO.X;
                }
                else
                {
                    button21.ImageIndex = 6;
                    btn21 = ValueXO.O;
                }

                Game();

                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (btn13 == ValueXO.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button13.ImageIndex = 1;
                    btn13 = ValueXO.X;
                }
                else
                {
                    button13.ImageIndex = 6;
                    btn13 = ValueXO.O;
                }

                Game();

                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (btn12 == ValueXO.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button12.ImageIndex = 1;
                    btn12 = ValueXO.X;
                }
                else
                {
                    button12.ImageIndex = 6;
                    btn12 = ValueXO.O;
                }

                Game();

                isPlayerXStep = !isPlayerXStep;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (btn11 == ValueXO.Empty && isGameOver == false)
            {
                if (isPlayerXStep == true)
                {
                    button11.ImageIndex = 1;
                    btn11 = ValueXO.X;
                }
                else
                {
                    button11.ImageIndex = 6;
                    btn11 = ValueXO.O;
                }
            }

            Game();

            isPlayerXStep = !isPlayerXStep;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isGameOver = false;
            isPlayerXStep = true;

            btn11 = btn12 = btn13 = btn21 = btn22 = btn23 = btn31 = btn32 = btn33 = ValueXO.Empty;

            button11.ImageIndex = 0;
            button12.ImageIndex = 0;
            button13.ImageIndex = 0;
            button21.ImageIndex = 0;
            button22.ImageIndex = 0;
            button23.ImageIndex = 0;
            button31.ImageIndex = 0;
            button32.ImageIndex = 0;
            button33.ImageIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isPlayerXStep = true;
            btn11 = btn12 = btn13 = btn21 = btn22 = btn23 = btn31 = btn32 = btn33 = ValueXO.Empty;
        }

        public void Game()
        {
            if (btn11 == ValueXO.X && btn21 == ValueXO.X && btn31 == ValueXO.X)
            {
                button11.ImageIndex = 4;
                button21.ImageIndex = 4;
                button31.ImageIndex = 4;

                isGameOver = true;

                MessageBox.Show("Победили X");
            }

            if (btn11 == ValueXO.O && btn21 == ValueXO.O && btn31 == ValueXO.O)
            {
                button11.ImageIndex = 9;
                button21.ImageIndex = 9;
                button31.ImageIndex = 9;

                isGameOver = true;

                MessageBox.Show("Победили O");
            }

            if (btn12 == ValueXO.X && btn22 == ValueXO.X && btn32 == ValueXO.X)
            {
                button12.ImageIndex = 4;
                button22.ImageIndex = 4;
                button32.ImageIndex = 4;

                isGameOver = true;

                MessageBox.Show("Победили X");
            }

            if (btn12 == ValueXO.O && btn22 == ValueXO.O && btn32 == ValueXO.O)
            {
                button12.ImageIndex = 9;
                button22.ImageIndex = 9;
                button32.ImageIndex = 9;

                isGameOver = true;

                MessageBox.Show("Победили O");
            }

            if (btn13 == ValueXO.X && btn23 == ValueXO.X && btn33 == ValueXO.X)
            {
                button13.ImageIndex = 4;
                button23.ImageIndex = 4;
                button33.ImageIndex = 4;

                isGameOver = true;

                MessageBox.Show("Победили X");
            }

            if (btn13 == ValueXO.O && btn23 == ValueXO.O && btn33 == ValueXO.O)
            {
                button13.ImageIndex = 9;
                button23.ImageIndex = 9;
                button33.ImageIndex = 9;

                isGameOver = true;

                MessageBox.Show("Победили O");
            }

            if (btn11 == ValueXO.X && btn12 == ValueXO.X && btn13 == ValueXO.X)
            {
                button11.ImageIndex = 5;
                button12.ImageIndex = 5;
                button13.ImageIndex = 5;

                isGameOver = true;

                MessageBox.Show("Победили X");
            }

            if (btn11 == ValueXO.O && btn12 == ValueXO.O && btn13 == ValueXO.O)
            {
                button11.ImageIndex = 10;
                button12.ImageIndex = 10;
                button13.ImageIndex = 10;

                isGameOver = true;

                MessageBox.Show("Победили O");
            }

            if (btn21 == ValueXO.X && btn22 == ValueXO.X && btn23 == ValueXO.X)
            {
                button21.ImageIndex = 5;
                button22.ImageIndex = 5;
                button23.ImageIndex = 5;

                isGameOver = true;

                MessageBox.Show("Победили X");
            }

            if (btn21 == ValueXO.O && btn22 == ValueXO.O && btn23 == ValueXO.O)
            {
                button21.ImageIndex = 10;
                button22.ImageIndex = 10;
                button23.ImageIndex = 10;

                isGameOver = true;

                MessageBox.Show("Победили O");
            }

            if (btn31 == ValueXO.X && btn32 == ValueXO.X && btn33 == ValueXO.X)
            {
                button31.ImageIndex = 5;
                button32.ImageIndex = 5;
                button33.ImageIndex = 5;

                isGameOver = true;

                MessageBox.Show("Победили X");
            }

            if (btn31 == ValueXO.O && btn32 == ValueXO.O && btn33 == ValueXO.O)
            {
                button31.ImageIndex = 10;
                button32.ImageIndex = 10;
                button33.ImageIndex = 10;

                isGameOver = true;

                MessageBox.Show("Победили O");
            }

            if (btn11 == ValueXO.X && btn22 == ValueXO.X && btn33 == ValueXO.X)
            {
                button11.ImageIndex = 2;
                button22.ImageIndex = 2;
                button33.ImageIndex = 2;

                isGameOver = true;

                MessageBox.Show("Победили X");
            }

            if (btn11 == ValueXO.O && btn22 == ValueXO.O && btn33 == ValueXO.O)
            {
                button11.ImageIndex = 7;
                button22.ImageIndex = 7;
                button33.ImageIndex = 7;

                isGameOver = true;

                MessageBox.Show("Победили O");
            }

            if (btn13 == ValueXO.X && btn22 == ValueXO.X && btn31 == ValueXO.X)
            {
                button13.ImageIndex = 3;
                button22.ImageIndex = 3;
                button31.ImageIndex = 3;

                isGameOver = true;

                MessageBox.Show("Победили X");
            }

            if (btn13 == ValueXO.O && btn22 == ValueXO.O && btn31 == ValueXO.O)
            {
                button13.ImageIndex = 8;
                button22.ImageIndex = 8;
                button31.ImageIndex = 8;

                isGameOver = true;

                MessageBox.Show("Победили O");
            }

            if (isGameOver == false)
            {
                if (btn11 != ValueXO.Empty && 
                    btn12 != ValueXO.Empty && 
                    btn13 != ValueXO.Empty && 
                    btn21 != ValueXO.Empty && 
                    btn22 != ValueXO.Empty && 
                    btn23 != ValueXO.Empty && 
                    btn31 != ValueXO.Empty && 
                    btn32 != ValueXO.Empty &&
                    btn33 != ValueXO.Empty)
                {
                    isGameOver = true;
                    MessageBox.Show("Ничья");
                }
            }
        }
    }
}