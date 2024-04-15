using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guessbutton_Click(object sender, EventArgs e)
        {
            StringBuilder wordToGuess = new StringBuilder(label1.Text);
            StringBuilder guessBox = new StringBuilder(textBox1.Text);

            if (guessBox.ToString().Equals("clocks"))
            {
                wordToGuess.Clear();
                wordToGuess.Append(guessBox.ToString());
                label1.Text = guessBox.ToString();
                MessageBox.Show("Your guess is correct!");


            }
            else 
            {
                wrongGuesses.Text = wordToGuess.ToString();
                guessBox.Clear();
                MessageBox.Show("You guessed the wrong word, Try again.");
            }
            

        }
    }
}

