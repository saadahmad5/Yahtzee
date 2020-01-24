using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class Form1 : Form
    {
        YahtzeeScorecard ysc;
        Gameplay game;
        public Form1()
        {
            InitializeComponent();
            game = new Gameplay();
            ysc = new YahtzeeScorecard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (game.numRolls < 3)
            {
                button1.Text = "Roll Dices (" + Convert.ToString(3 - game.numRolls - 1) + ")";
                game.numRolls++;
                game.initializeDices();
                int tempDice = game.getDiceValue(0);
                if (tempDice == 1)
                {
                    pictureBox1.Image = Yahtzee.Properties.Resources._1;
                    pictureBox1.Tag = 1;
                }
                else if (tempDice == 2)
                {
                    pictureBox1.Image = Yahtzee.Properties.Resources._2;
                    pictureBox1.Tag = 2;
                }
                else if (tempDice == 3)
                {
                    pictureBox1.Image = Yahtzee.Properties.Resources._3;
                    pictureBox1.Tag = 3;
                }
                else if (tempDice == 4)
                {
                    pictureBox1.Image = Yahtzee.Properties.Resources._4;
                    pictureBox1.Tag = 4;
                }
                else if (tempDice == 5)
                {
                    pictureBox1.Image = Yahtzee.Properties.Resources._5;
                    pictureBox1.Tag = 5;
                }
                else if (tempDice == 6)
                {
                    pictureBox1.Image = Yahtzee.Properties.Resources._6;
                    pictureBox1.Tag = 6;
                }
                tempDice = game.getDiceValue(1);
                if (tempDice == 1)
                {
                    pictureBox2.Image = Yahtzee.Properties.Resources._1;
                    pictureBox2.Tag = 1;
                }
                else if (tempDice == 2)
                {
                    pictureBox2.Image = Yahtzee.Properties.Resources._2;
                    pictureBox2.Tag = 2;
                }
                else if (tempDice == 3)
                {
                    pictureBox2.Image = Yahtzee.Properties.Resources._3;
                    pictureBox2.Tag = 3;
                }
                else if (tempDice == 4)
                {
                    pictureBox2.Image = Yahtzee.Properties.Resources._4;
                    pictureBox2.Tag = 4;
                }
                else if (tempDice == 5)
                {
                    pictureBox2.Image = Yahtzee.Properties.Resources._5;
                    pictureBox2.Tag = 5;

                }
                else if (tempDice == 6)
                {
                    pictureBox2.Image = Yahtzee.Properties.Resources._6;
                    pictureBox2.Tag = 6;
                }
                tempDice = game.getDiceValue(2);
                if (tempDice == 1)
                {
                    pictureBox3.Image = Yahtzee.Properties.Resources._1;
                    pictureBox3.Tag = 1;
                }
                else if (tempDice == 2)
                {
                    pictureBox3.Image = Yahtzee.Properties.Resources._2;
                    pictureBox3.Tag = 2;
                }
                else if (tempDice == 3)
                {
                    pictureBox3.Image = Yahtzee.Properties.Resources._3;
                    pictureBox3.Tag = 3;
                }
                else if (tempDice == 4)
                {
                    pictureBox3.Image = Yahtzee.Properties.Resources._4;
                    pictureBox3.Tag = 4;
                }
                else if (tempDice == 5)
                {
                    pictureBox3.Image = Yahtzee.Properties.Resources._5;
                    pictureBox3.Tag = 5;
                }
                else if (tempDice == 6)
                {
                    pictureBox3.Image = Yahtzee.Properties.Resources._6;
                    pictureBox3.Tag = 6;
                }
                tempDice = game.getDiceValue(3);
                if (tempDice == 1)
                {
                    pictureBox4.Image = Yahtzee.Properties.Resources._1;
                    pictureBox4.Tag = 1;
                }
                else if (tempDice == 2)
                {
                    pictureBox4.Image = Yahtzee.Properties.Resources._2;
                    pictureBox4.Tag = 2;
                }
                else if (tempDice == 3)
                {
                    pictureBox4.Image = Yahtzee.Properties.Resources._3;
                    pictureBox4.Tag = 3;
                }
                else if (tempDice == 4)
                {
                    pictureBox4.Image = Yahtzee.Properties.Resources._4;
                    pictureBox4.Tag = 4;
                }
                else if (tempDice == 5)
                {
                    pictureBox4.Image = Yahtzee.Properties.Resources._5;
                    pictureBox4.Tag = 5;
                }
                else if (tempDice == 6)
                {
                    pictureBox4.Image = Yahtzee.Properties.Resources._6;
                    pictureBox4.Tag = 6;
                }
                tempDice = game.getDiceValue(4);
                if (tempDice == 1)
                {
                    pictureBox5.Image = Yahtzee.Properties.Resources._1;
                    pictureBox5.Tag = 1;
                }
                else if (tempDice == 2)
                {
                    pictureBox5.Image = Yahtzee.Properties.Resources._2;
                    pictureBox5.Tag = 2;
                }
                else if (tempDice == 3)
                {
                    pictureBox5.Image = Yahtzee.Properties.Resources._3;
                    pictureBox5.Tag = 3;
                }
                else if (tempDice == 4)
                {
                    pictureBox5.Image = Yahtzee.Properties.Resources._4;
                    pictureBox5.Tag = 4;
                }
                else if (tempDice == 5)
                {
                    pictureBox5.Image = Yahtzee.Properties.Resources._5;
                    pictureBox5.Tag = 5;
                }
                else if (tempDice == 6)
                {
                    pictureBox5.Image = Yahtzee.Properties.Resources._6;
                    pictureBox5.Tag = 6;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            if (pictureBox1.Tag.Equals(1))
            {
                game.setDiceValue(0, 1);
                pictureBox6.Image = Yahtzee.Properties.Resources._1;
            }
            else if (pictureBox1.Tag.Equals(2))
            {
                game.setDiceValue(0, 2);
                pictureBox6.Image = Yahtzee.Properties.Resources._2;
            }
            else if (pictureBox1.Tag.Equals(3))
            {
                game.setDiceValue(0, 3);
                pictureBox6.Image = Yahtzee.Properties.Resources._3;
            }
            else if (pictureBox1.Tag.Equals(4))
            {
                game.setDiceValue(0, 4);
                pictureBox6.Image = Yahtzee.Properties.Resources._4;
            }
            else if (pictureBox1.Tag.Equals(5))
            {
                game.setDiceValue(0, 5);
                pictureBox6.Image = Yahtzee.Properties.Resources._5;
            }
            else if (pictureBox1.Tag.Equals(6))
            {
                game.setDiceValue(0, 6);
                pictureBox6.Image = Yahtzee.Properties.Resources._6;
            }
            pictureBox1.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            if (pictureBox2.Tag.Equals(1))
            {
                game.setDiceValue(1, 1);
                pictureBox7.Image = Yahtzee.Properties.Resources._1;
            }
            else if (pictureBox2.Tag.Equals(2))
            {
                game.setDiceValue(1, 2);
                pictureBox7.Image = Yahtzee.Properties.Resources._2;
            }
            else if (pictureBox2.Tag.Equals(3))
            {
                game.setDiceValue(1, 3);
                pictureBox7.Image = Yahtzee.Properties.Resources._3;
            }
            else if (pictureBox2.Tag.Equals(4))
            {
                game.setDiceValue(1, 4);
                pictureBox7.Image = Yahtzee.Properties.Resources._4;
            }
            else if (pictureBox2.Tag.Equals(5))
            {
                game.setDiceValue(1, 5);
                pictureBox7.Image = Yahtzee.Properties.Resources._5;
            }
            else if (pictureBox2.Tag.Equals(6))
            {
                game.setDiceValue(1, 6);
                pictureBox7.Image = Yahtzee.Properties.Resources._6;
            }
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            if (pictureBox3.Tag.Equals(1))
            {
                game.setDiceValue(2, 1);
                pictureBox8.Image = Yahtzee.Properties.Resources._1;
            }
            else if (pictureBox3.Tag.Equals(2))
            {
                game.setDiceValue(2, 2);
                pictureBox8.Image = Yahtzee.Properties.Resources._2;
            }
            else if (pictureBox3.Tag.Equals(3))
            {
                game.setDiceValue(2, 3);
                pictureBox8.Image = Yahtzee.Properties.Resources._3;
            }
            else if (pictureBox3.Tag.Equals(4))
            {
                game.setDiceValue(2, 4);
                pictureBox8.Image = Yahtzee.Properties.Resources._4;
            }
            else if (pictureBox3.Tag.Equals(5))
            {
                game.setDiceValue(2, 5);
                pictureBox8.Image = Yahtzee.Properties.Resources._5;
            }
            else if (pictureBox3.Tag.Equals(6))
            {
                game.setDiceValue(2, 6);
                pictureBox8.Image = Yahtzee.Properties.Resources._6;
            }
            pictureBox3.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            if (pictureBox4.Tag.Equals(1))
            {
                game.setDiceValue(3, 1);
                pictureBox9.Image = Yahtzee.Properties.Resources._1;
            }
            else if (pictureBox4.Tag.Equals(2))
            {
                game.setDiceValue(3, 2);
                pictureBox9.Image = Yahtzee.Properties.Resources._2;
            }
            else if (pictureBox4.Tag.Equals(3))
            {
                game.setDiceValue(3, 3);
                pictureBox9.Image = Yahtzee.Properties.Resources._3;
            }
            else if (pictureBox4.Tag.Equals(4))
            {
                game.setDiceValue(3, 4);
                pictureBox9.Image = Yahtzee.Properties.Resources._4;
            }
            else if (pictureBox4.Tag.Equals(5))
            {
                game.setDiceValue(3, 5);
                pictureBox9.Image = Yahtzee.Properties.Resources._5;
            }
            else if (pictureBox4.Tag.Equals(6))
            {
                game.setDiceValue(3, 6);
                pictureBox9.Image = Yahtzee.Properties.Resources._6;
            }
            pictureBox4.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = true;
            if (pictureBox5.Tag.Equals(1))
            {
                game.setDiceValue(4, 1);
                pictureBox10.Image = Yahtzee.Properties.Resources._1;
            }
            else if (pictureBox5.Tag.Equals(2))
            {
                game.setDiceValue(4, 2);
                pictureBox10.Image = Yahtzee.Properties.Resources._2;
            }
            else if (pictureBox5.Tag.Equals(3))
            {
                game.setDiceValue(4, 3);
                pictureBox10.Image = Yahtzee.Properties.Resources._3;
            }
            else if (pictureBox5.Tag.Equals(4))
            {
                game.setDiceValue(4, 4);
                pictureBox10.Image = Yahtzee.Properties.Resources._4;
            }
            else if (pictureBox5.Tag.Equals(5))
            {
                game.setDiceValue(4, 5);
                pictureBox10.Image = Yahtzee.Properties.Resources._5;
            }
            else if (pictureBox5.Tag.Equals(6))
            {
                game.setDiceValue(4, 6);
                pictureBox10.Image = Yahtzee.Properties.Resources._6;
            }
            pictureBox5.Visible = false;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "Roll Dices (3)";
            button2.Enabled = false;
            game.scoreGenerator();
            for (int i = 0; i < 5; ++i)
            {
                label1.Text += game.selectRolls[i] + ",";
            }
            label1.Text += " ";
            radioButton1.Text = Convert.ToString(game.currentScore[0]);
            radioButton2.Text = Convert.ToString(game.currentScore[1]);
            radioButton3.Text = Convert.ToString(game.currentScore[2]);
            radioButton4.Text = Convert.ToString(game.currentScore[3]);
            radioButton5.Text = Convert.ToString(game.currentScore[4]);
            radioButton6.Text = Convert.ToString(game.currentScore[5]);
            radioButton7.Text = Convert.ToString(game.currentScore[6]);
            radioButton8.Text = Convert.ToString(game.currentScore[7]);
            radioButton9.Text = Convert.ToString(game.currentScore[8]);
            radioButton10.Text = Convert.ToString(game.currentScore[9]);
            radioButton11.Text = Convert.ToString(game.currentScore[10]);
            radioButton12.Text = Convert.ToString(game.currentScore[11]);
            radioButton13.Text = Convert.ToString(game.currentScore[12]);

            if(ysc.Bonus)
            {
                label3.Text = "35";
            }
        }

        private void updateSelectedScores()
        {
            label6.Text = Convert.ToString(ysc.Ones);
            label7.Text = Convert.ToString(ysc.Twos);
            label8.Text = Convert.ToString(ysc.Threes);
            label9.Text = Convert.ToString(ysc.Fours);
            label10.Text = Convert.ToString(ysc.Fives);
            label11.Text = Convert.ToString(ysc.Sixes);

            label18.Text = Convert.ToString(ysc.FullHouse);
            label12.Text = Convert.ToString(ysc.ThreeOfKind);
            label13.Text = Convert.ToString(ysc.FourOfKind);
            label14.Text = Convert.ToString(ysc.SmallStraight);
            label15.Text = Convert.ToString(ysc.LargeStraight);
            label16.Text = Convert.ToString(ysc.Chance);
            label17.Text = Convert.ToString(ysc.YAHtzee);

        }

        private void reset()
        {

            button2.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;

        }



        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            reset();
            ysc.Ones = game.currentScore[0];
            ysc.refresh();
            textBox1.Text = Convert.ToString(ysc.Total);
            game = new Gameplay();
            updateSelectedScores();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton2.Enabled = false;
            reset();
            ysc.Twos = game.currentScore[1];
            ysc.refresh();
            textBox1.Text = Convert.ToString(ysc.Total);
            game = new Gameplay();
            updateSelectedScores();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            radioButton3.Enabled = false;
            reset();
            ysc.Threes = game.currentScore[2];
            ysc.refresh();
            textBox1.Text = Convert.ToString(ysc.Total);
            game = new Gameplay();
            updateSelectedScores();
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            radioButton4.Enabled = false;
            reset();
            ysc.Fours = game.currentScore[3];
            ysc.refresh();
            textBox1.Text = Convert.ToString(ysc.Total);
            game = new Gameplay();
            updateSelectedScores();
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            radioButton5.Enabled = false;
            reset();
            ysc.Fives = game.currentScore[4];
            ysc.refresh();
            textBox1.Text = Convert.ToString(ysc.Total);
            game = new Gameplay();
            updateSelectedScores();
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            radioButton6.Enabled = false;
            reset();
            ysc.Sixes = game.currentScore[5];
            ysc.refresh();
            textBox1.Text = Convert.ToString(ysc.Total);
            game = new Gameplay();
            updateSelectedScores();
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            radioButton8.Enabled = false;
            reset();
            ysc.ThreeOfKind = game.currentScore[7];
            ysc.refresh();
            textBox1.Text = Convert.ToString(ysc.Total);
            game = new Gameplay();
            updateSelectedScores();
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            radioButton9.Enabled = false;
            reset();
            ysc.FourOfKind = game.currentScore[8];
            ysc.refresh();
            textBox1.Text = Convert.ToString(ysc.Total);
            game = new Gameplay();
            updateSelectedScores();
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            radioButton10.Enabled = false;
            reset();
            ysc.SmallStraight = game.currentScore[9];
            ysc.refresh();
            textBox1.Text = Convert.ToString(ysc.Total);
            game = new Gameplay();
            updateSelectedScores();
        }

        private void radioButton11_Click(object sender, EventArgs e)
        {
            radioButton11.Enabled = false;
            reset();
            ysc.LargeStraight = game.currentScore[10];
            ysc.refresh();
            textBox1.Text = Convert.ToString(ysc.Total);
            game = new Gameplay();
            updateSelectedScores();
        }

        private void radioButton12_Click(object sender, EventArgs e)
        {
            radioButton12.Enabled = false;
            reset();
            ysc.Chance = game.currentScore[11];
            ysc.refresh();
            textBox1.Text = Convert.ToString(ysc.Total);
            game = new Gameplay();
        }

        private void radioButton13_Click(object sender, EventArgs e)
        {
            radioButton13.Enabled = false;
            reset();
            ysc.YAHtzee = game.currentScore[12];
            ysc.refresh();
            textBox1.Text = Convert.ToString(ysc.Total);
            game = new Gameplay();
            updateSelectedScores();
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            radioButton7.Enabled = false;
            reset();
            ysc.FullHouse = game.currentScore[6];
            ysc.refresh();
            textBox1.Text = Convert.ToString(ysc.Total);
            game = new Gameplay();
            updateSelectedScores();
        }

    }
}
