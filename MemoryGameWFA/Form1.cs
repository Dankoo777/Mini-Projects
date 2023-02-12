using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameWFA
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        List<string> icons = new List<string>()
        {
            "[","[",">",">","z","z","M","M","N","N","(","(","T","T","6","6",
        };
        Label firstClicked, secondClicked;
        public Form1()
        {
            InitializeComponent();
            AssignIcons();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
            {
                return;
            }
            Label clickedLabel = sender as Label;
            if (clickedLabel == null)
            {
                return;
            }
            if (clickedLabel.ForeColor == Color.Black)
            {
                return;
            }
            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;
            WinCheck();
            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked.BackColor = Color.LightGreen;
                secondClicked.BackColor = Color.LightGreen;
                firstClicked = null;
                secondClicked = null;
            }
            else
            {
                timer1.Start();
            }
        }
        private void WinCheck()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = (Label)tableLayoutPanel1.Controls[i];
                if (label != null && label.ForeColor == label.BackColor)
                {
                    return;
                }
            }
            tableLayoutPanel1.BackColor = Color.LightGreen;
            MessageBox.Show("You finished the game!!!", "Congratulations!!!");
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }

        private void AssignIcons()
        {
            Label label;
            int randomNum;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                }
                else
                { continue; }
                randomNum = r.Next(0, icons.Count);
                label.Text = icons[randomNum];
                icons.RemoveAt(randomNum);
            }
        }
    }
}
