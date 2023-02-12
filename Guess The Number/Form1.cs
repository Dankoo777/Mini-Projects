using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_The_Number
{
    public partial class Form1 : Form
    {
        private Random r = new Random();
        private int N;
        static int[] array = new int[101];
        public int tries = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            textBoxnum.Text = "";
            textBoxtries.Text = "";
            textBoxans.Text = "";
            N = r.Next(0, 100);
            for (int i = 0; i <= 100; i++)
            {
                array[i] = i;
            }
            buttonStart.Enabled = false;
        }

        private void buttonTry_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxnum.Text);
                tries++;
                if(n == array[N])
                {
                    buttonTry.Enabled = false;
                    textBoxtries.Text = tries.ToString();
                    textBoxans.Text = "ПОЗНА";
                    buttonStart.Enabled = true;
                }
                if(n < array[N])
                {
                    textBoxans.Text = "НАГОРЕ";
                    textBoxtries.Text = tries.ToString();
                    textBoxnum.Text = "";
                }
                if (n > array[N])
                {
                    textBoxans.Text = "НАДОЛУ";
                    textBoxtries.Text = tries.ToString();
                    textBoxnum.Text = "";
                }
        }
    }
}
