using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int attempts = 0;
        int points = 0;
        int n;
        char[] mas = new char[13] { 'x', '#', 'x', '7', '#', 'x', '7', 'x', '#', '$', 'x', '7', '#' };

        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            n = rnd.Next(1, 20);
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                button1.Text = mas[j].ToString();
                j++;
                if(j == 13)
                {
                    j = 0;
                }
            }
            n = rnd.Next(1, 20);
            for (int i = 0; i < n; i++)
            {
                button2.Text = mas[j].ToString();
                j++;
                if (j == 13)
                {
                    j = 0;
                }
            }
            n = rnd.Next(1, 20);
            for (int i = 0; i < n; i++)
            {
                button3.Text = mas[j].ToString();
                j++;
                if (j == 13)
                {
                    j = 0;
                }
            }

            if(button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if(button1.Text == "x")
                {
                    points += 50;
                }
                else if(button1.Text == "#")
                {
                    points += 100;
                }
                else if(button1.Text == "7")
                { 
                    points += 500;
                }
                else if(button1.Text == "$")
                {
                    points += 1000;
                }
            }

            attempts++;

            labelAttempts.Text = attempts.ToString();
            labelPoints.Text = points.ToString();
        }
    }
}
