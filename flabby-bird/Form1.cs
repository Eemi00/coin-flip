using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flabby_bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            if (!headsBtn.Checked && !tailsBtn.Checked)
            {
                errorLabel.Text = "Sinun täytyy valita joko kruuna tai klaava!";
            }
            else
            {
                errorLabel.Text = "";

                betPanel.Visible = false;
                playPanel.Visible = true;

                if (headsBtn.Checked)
                {
                    selectionLabel.Text = "Valitsit kruunan!";
                }
                else if (tailsBtn.Checked)
                {
                    selectionLabel.Text = "Valitsit klaavan!";
                }

                await RandomizeResultAsync();
            }
        }

        private async Task RandomizeResultAsync()
        {
            await Task.Delay(2400);

            Random random = new Random();

            string option1 = "Kruuna";
            string option2 = "Klaava";

            int randomChoice = random.Next(0, 2);

            string result = (randomChoice == 0) ? option1 : option2;

            resultLabel.Text = result;
        }
    }
}
