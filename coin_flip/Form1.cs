using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coin_flip
{
    public partial class Form1 : Form
    {
        private Timer changeImageTimer;

        private int balance = 0;
        private Random BalanceRandom = new Random();

        public Form1()
        {
            InitializeComponent();

            changeImageTimer = new Timer();
            changeImageTimer.Interval = 2600;
            changeImageTimer.Tick += ChangeImageTimer_Tick;

            pictureBoxDiamond.Click += Diamond_Click;
            SpawnDiamond();
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            string selection = "";

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
                    selection = "Kruuna";
                }
                else if (tailsBtn.Checked)
                {
                    selectionLabel.Text = "Valitsit klaavan!";
                    selection = "Klaava";
                }

                await RandomizeResultAsync(selection);
            }
        }

        private async Task RandomizeResultAsync(string selection)
        {
            pictureBox1.Image = Properties.Resources.download;  

            changeImageTimer.Start();

            await Task.Delay(2600); 
            Random random = new Random();

            string option1 = "Kruuna";
            string option2 = "Klaava";

            int randomChoice = random.Next(0, 2);

            string result = (randomChoice == 0) ? option1 : option2;

            resultLabel.Text = result;

            if (result == selection)
            {
                winLabel.Text = "Voitit! Olet voittanut!";
            }
            else
            {
                winLabel.Text = "hävisit! Yritä uudelleen!";
            }
        }

        private void ChangeImageTimer_Tick(object sender, EventArgs e)
        {
            changeImageTimer.Stop();

            pictureBox1.Image = Properties.Resources.staticImage;
        }

        private void playagainBtn_Click(object sender, EventArgs e)
        {
            betPanel.Visible = true;
            playPanel.Visible = false;

            selectionLabel.Text = "";
            resultLabel.Text = "";
            errorLabel.Text = "";
            winLabel.Text = "";

            headsBtn.Checked = false;
            tailsBtn.Checked = false;
        }

        private void Diamond_Click(object sender, EventArgs e)
        {
            balance += 1;
            balanceLabel.Text = $"Lompakko: {balance} 💎";

            SpawnDiamond();
        }

        private void SpawnDiamond()
        {
            int maxX = gamePanel.Width - pictureBoxDiamond.Width;
            int maxY = gamePanel.Height - pictureBoxDiamond.Height;

            int randomX = BalanceRandom.Next(0, maxX);
            int randomY = BalanceRandom.Next(100, maxY);

            pictureBoxDiamond.Location = new Point(randomX, randomY);
        }

        private void panelSwitchBtn_Click(object sender, EventArgs e)
        {
            gamePanel.Visible = false;
            betPanel.Visible = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            betPanel.Visible = false;
            gamePanel.Visible = true;
        }

        private void backBtn2_Click(object sender, EventArgs e)
        {
            playPanel.Visible = false;
            gamePanel.Visible = true;
        }
    }
}
