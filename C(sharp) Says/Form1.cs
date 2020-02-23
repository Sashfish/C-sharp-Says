using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace C_sharp__Says
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int itemsInList = 0;
        List<int> pattern = new List<int>();
        Random rnd = new Random();
        bool playingBack = false;

        private void Green_Click(object sender, EventArgs e)
        {
            TestCorrect(0);
        }

        private void Red_Click(object sender, EventArgs e)
        {
            TestCorrect(1);
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            TestCorrect(2);
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            TestCorrect(3);
        }

        void TestCorrect(int colour)
        {
            if (playingBack) 
                return;
            if (pattern[itemsInList] == colour)
                itemsInList++;
            else
            {
                MessageBox.Show("You falied. Final score: " + pattern.Count.ToString());
                itemsInList = 0;
                pattern = new List<int>();
                new Thread(Playback).Start();
            }
            if (itemsInList >= pattern.Count)
            {
                pattern.Add(rnd.Next(0, 4));
                itemsInList = 0;
                new Thread(Playback).Start();
            }
            ScoreLabel.Text = ("Score: " + pattern.Count.ToString());
            PatternLabel.Text = ("Pattern length: " + itemsInList.ToString());
        }

        void Playback()
        {
            playingBack = true;
            foreach (int colour in pattern)
            {
                switch (colour)
                {
                    case 0:
                        Green.BackColor = Color.Green;
                        Thread.Sleep(200);
                        Green.BackColor = Color.Transparent;
                        break;
                    case 1:
                        Red.BackColor = Color.Red;
                        Thread.Sleep(200);
                        Red.BackColor = Color.Transparent;
                        break;
                    case 2:
                        Yellow.BackColor = Color.Yellow;
                        Thread.Sleep(200);
                        Yellow.BackColor = Color.Transparent;
                        break;
                    case 3:
                        Blue.BackColor = Color.Blue;
                        Thread.Sleep(200);
                        Blue.BackColor = Color.Transparent;
                        break;
                }
                Thread.Sleep(200);
            }
            playingBack = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pattern.Add(rnd.Next(0, 4));
            new Thread(Playback).Start();
        }
    }
 }