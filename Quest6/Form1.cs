using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Quest6
{
    public partial class Form1 : Form
    {
        Critter thisCreature = new Critter("TeReck", 200, 0);
        int foodBurn = 10, foodAmt = 10, boardRate = 10;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            barHunger.Maximum = 200;
            barBoardem.Maximum = 100;
            barBoardem.Value = thisCreature.Boredom;
            barHunger.Value = thisCreature.Hunger;
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            if (barHunger.Value == barHunger.Maximum)
            {
                btnFeed.Enabled = false;
                txtOutPut.Text = txtOutPut.Text + "Not hungry don't feed me \n";
            }
            else
            {
                thisCreature.feed(foodAmt);
                barHunger.Increment(thisCreature.Hunger);
                txtOutPut.Text = txtOutPut.Text + "You fed it 10 pellets\n";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Decrease the creatures hunger and bar value so they are equally decremented 
            barHunger.Increment(-foodBurn);
            thisCreature.Hunger -= foodBurn;
            barBoardem.Increment(boardRate);
            thisCreature.Boredom += boardRate;
           
            // This checks the bar value
        #region hunger
            if (barHunger.Value < 200)
            {
                btnFeed.Enabled = true;
            }
            if(barHunger.Value == 150)
            {
                txtOutPut.Text = txtOutPut.Text + "I'm feeling for a snack\n";
            }
            if (barHunger.Value == 100)
            {
                txtOutPut.Text = txtOutPut.Text + "When's Dinner?\n";
            }
            if (barHunger.Value == 70)
            {
                txtOutPut.Text = txtOutPut.Text + "Hey I'm seriously hungry!!\n";
            }
            if (barHunger.Value == 50)
            {
                txtOutPut.Text = txtOutPut.Text + "Where is MY DINNER YOU MEAT THING?!!\n";
            }
            if (barHunger.Value == 20)
            {
                txtOutPut.Text = txtOutPut.Text + ". . .\n";
            }
            if (barHunger.Value == 0)
            {
                txtOutPut.Text = txtOutPut.Text + "YOU'RE MY DINNER !!! " + thisCreature.Name + " reveals its calws and sinks them into your legs\n and begins to rip into your tourso as you lose consciousness . . .\n all but a dream\n";
                btnFeed.Enabled = false;
                btnListen.Enabled = false;
                btnPlay.Enabled = false;
                btnTrick.Enabled = false;
                barBoardem.Value = barBoardem.Minimum;
                timer1.Stop();   
            }
            #endregion
        #region boardom
            if (thisCreature.Boredom == 30)
            {
                txtOutPut.Text = txtOutPut.Text + "Mood: Meh\n";
            }
            if (thisCreature.Boredom == 50)
            {
                txtOutPut.Text = txtOutPut.Text + "Wow nothing again?\n";
            }
            if (thisCreature.Boredom == 70)
            {
                txtOutPut.Text = txtOutPut.Text + "Can we do something?\n";
            }
            if (thisCreature.Boredom == 90)
            {
                txtOutPut.Text = txtOutPut.Text + "I think I know what will be fun\n";
            }
            if(thisCreature.Boredom == 100)
            {
                txtOutPut.Text = txtOutPut.Text + "RAAAGGEEEEE!!! " + thisCreature.Name + " Rips your head off and plays vollyball with his friends with your head\n and eats the rest for dinner";
                btnFeed.Enabled = false;
                btnListen.Enabled = false;
                btnPlay.Enabled = false;
                btnTrick.Enabled = false;
                barBoardem.Value = barBoardem.Minimum;
                timer1.Stop();
            }
            #endregion
        }

        private void btnTrick_Click(object sender, EventArgs e)
        {
            barBoardem.Increment(boardRate);
            thisCreature.increaseBoardem(boardRate);
            txtOutPut.Text = txtOutPut.Text + "This is only fun for you!\n";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            thisCreature.reduceBoardem(boardRate);
            barBoardem.Increment(-boardRate);
            txtOutPut.Text = txtOutPut.Text + "HHeey " + thisCreature.Name + " Look at mee!!\n";
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            txtOutPut.Text = "Current Mood: " + thisCreature.getMood(thisCreature.Boredom, thisCreature.Hunger) + "\n";
        }
    }

    class Critter
{
    int m_hunger = 0, m_boredom = 0;
    string m_name = "";

    public Critter(string _name, int _hunger, int _boredom)
    {
        Boredom = _boredom;
        Hunger = _hunger;
        Name = _name;
    }
   
    public string getMood(int board, int hunger)
    {
            int moodNumber = (board);
            string mood = " . . . ";

            if(moodNumber == 20)
            {
                mood = "Indifferent";
            }     
            if(moodNumber == 30)
            { 
                mood = "Not thinking about murder. . . ";
            }

            if (moodNumber == 40)
            {
                mood = "Kind of Angry";
            }
            if(moodNumber == 70)
            {
                mood = "Will eat half of all children in a 10 mile raduis";
            }
            if (moodNumber == 80)
            {
                mood = "Feels fine, (obviously lying DO SOMETHING!!)";
            }
            if(moodNumber == 100)
            {
                mood = "Will paint the town red!";
            }

            return mood;    
    }
    public void reduceBoardem(int boardem)
    {
      Boredom -= boardem;
    }
    public void increaseBoardem(int boardem)
    {
      Boredom += boardem;
    }
    public void feed(int foodAmt)
    {
      Hunger += foodAmt;
    }

    public int Boredom
    {
        get
        {
            return m_boredom;
        }

        set
        {
            m_boredom = value;
        }
    }

    public int Hunger
    {
        get
        {
            return m_hunger;
        }

        set
        {
            m_hunger = value;
        }
    }

    public string Name
    {
        get
        {
            return m_name;
        }

        set
        {
            m_name = value;
        }
    }
}
}


