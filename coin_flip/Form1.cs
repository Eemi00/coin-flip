using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coin_flip
{
    public partial class Form1 : Form
    {
        // Kaikki timerit ja muuttujat
        private Timer changeImageTimer;

        private int balance = 0;
        private Random BalanceRandom = new Random();

        private int diamondMultiplier = 1;
        private bool autoClickerEnabled = false;
        private bool goldenDiamondUpgradePurchased = false;

        private Timer specialEventTimer;
        private Timer eventDurationTimer;
        private Random eventRandom = new Random();
        private bool specialEventActive = false;

        // määrittää onko päivityksiä ostettu
        private bool upgrade1Purchased = false;
        private bool upgrade2Purchased = false;
        private bool upgrade3Purchased = false;


        // Perus form. Timerit
        public Form1()
        {
            InitializeComponent();

            changeImageTimer = new Timer();
            changeImageTimer.Interval = 2600;
            changeImageTimer.Tick += ChangeImageTimer_Tick;

            pictureBoxDiamond.Click += Diamond_Click;
            SpawnDiamond();

            timerAutoClicker.Interval = 60000;
            timerAutoClicker.Tick += timerAutoClicker_Tick;

            timerGoldenDiamond.Interval = 120000; 
            timerGoldenDiamond.Tick += timerGoldenDiamond_Tick;
        }

        // Custom eventin tunnistus / arpominen
        private void InitializeEventTimer()
        {
            specialEventTimer = new Timer();
            specialEventTimer.Interval = eventRandom.Next(600000, 900000);
            specialEventTimer.Tick += SpecialEventTimer_Tick;
            specialEventTimer.Start();

            eventDurationTimer = new Timer();
            eventDurationTimer.Interval = 60000;
            eventDurationTimer.Tick += EventDurationTimer_Tick;
        }

        // Lopettaa kustom eventin
        private void EventDurationTimer_Tick(object sender, EventArgs e)
        {
            EndSpecialEvent();
        }

        // Ku eventti käynnistyy se sulkee timerin siks aikaa kun se eventti on käynnis
        private void SpecialEventTimer_Tick(object sender, EventArgs e)
        {
            if (specialEventActive) return;

            specialEventTimer.Stop(); 
            TriggerSpecialEvent();
        }

        // Asiat mitä se tekee kun eventti alkaa
        private void TriggerSpecialEvent()
        {
            MessageBox.Show("Eventti alkoi! Varo painamasta pommeja!");
            specialEventActive = true;

            MoveBomb();
            eventDurationTimer.Start();
        }

        // asiat mitä se tekee ku eventti loppuu
        private void EndSpecialEvent()
        {
            specialEventActive = false;
            MessageBox.Show("Eventti päättyi. Kannattaa odottaa seuraavaan!");
            
            bombEventPicture.Visible = false;
            eventDurationTimer.Stop(); 

            specialEventTimer.Interval = eventRandom.Next(600000, 900000);
            specialEventTimer.Start();
        }

        // Kolikonheiton alotukseen sääntöjä
        private async void startBtn_Click(object sender, EventArgs e)
        {
            string selection = "";

            // panos täytyy olla jotta voi pelata
            if (!int.TryParse(betAmount.Text, out int bet) || bet < 1)
            {
                errorLabel.Text = "Aseta panos! Vähintään 1.";
                return;
            }

            // lisää sääntöjä
            if (bet > balance)
            {
                errorLabel.Text = "Ei tarpeeksi timantteja! 💎";
                return;
            }

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

                playagainBtn.Enabled = false;
                backBtn2.Enabled = false;

                await RandomizeResultAsync(selection);
            }
        }

        // arpoo kumpi tulee kruuna vai klaava
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

            int.TryParse(betAmount.Text, out int bet);

            // Tuloksien määrittely
            if (result == selection)
            {
                winLabel.Text = "Voitit! Olet voittanut!";

                balance -= bet;
                balance += bet * 2;
                UpdateBalanceLabels();
            }
            else
            {
                winLabel.Text = "hävisit! Yritä uudelleen!";

                balance -= bet;
                UpdateBalanceLabels();
            }
        }

        // Pommi eventin pommi kuvan liikuttaminen aina kun timanttia painaa.
        private void MoveBomb()
        {
            if (!specialEventActive) return;

            bombEventPicture.Size = new Size(70, 70);

            int maxX = gamePanel.Width - bombEventPicture.Width;
            int maxY = gamePanel.Height - bombEventPicture.Height;

            int x = BalanceRandom.Next(0, Math.Max(1, maxX));
            int y = BalanceRandom.Next(50, Math.Max(51, maxY));

            bombEventPicture.Location = new Point(x, y);
            bombEventPicture.Visible = true;
        }

        // Asiat mitä tapahtuu ku klikkaa pommia
        private void bombEventPicture_Click(object sender, EventArgs e)
        {
            if (balance >= 20)
            {
                balance -= 20;
            }
            else
            {
                balance = 0;
            }

            UpdateBalanceLabels();
        }

        // Kolikonheitossa animaatio vaihtuu paikallaan olevaan kuvaan jotta animaatio ei looppaa kokoajan paikallaan
        private void ChangeImageTimer_Tick(object sender, EventArgs e)
        {
            changeImageTimer.Stop();

            pictureBox1.Image = Properties.Resources.staticImage;

            playagainBtn.Enabled = true;
            backBtn2.Enabled = true;
        }

        // Kolikonheiton uudelleen pelaukseen tehdyt säännöt
        private void playagainBtn_Click(object sender, EventArgs e)
        {
            betPanel.Visible = true;
            playPanel.Visible = false;

            UpdateBalanceLabels();

            selectionLabel.Text = "";
            resultLabel.Text = "";
            errorLabel.Text = "";
            winLabel.Text = "";
            betAmount.Text = "";

            headsBtn.Checked = false;
            tailsBtn.Checked = false;
        }

        // Asiat mitä saa ku timanttia painaa
        private void Diamond_Click(object sender, EventArgs e)
        {
            balance += 1 * diamondMultiplier;

            SpawnDiamond();
            UpdateBalanceLabels();

            if (specialEventActive)
            {
                MoveBomb();
            }
        }

        // Määritellää lompakko tekstit jotta joka paneelissa ne sanoo saman määrän
        private void UpdateBalanceLabels()
        {
            balanceLabel.Text = $"Lompakko: {balance} 💎";
            balanceLabel2.Text = $"Lompakko: {balance} 💎";
            balanceLabel3.Text = $"Lompakko: {balance} 💎";
        }

        // Timantin spawnaamisen funktio. Spawnaa aina randomisti koko ruudun verran (ei ihan ylös koska siellä on buttonit että ei mee niitte päälle)
        private void SpawnDiamond()
        {
            pictureBoxDiamond.Size = new Size(80, 70);
            int maxX = gamePanel.Width - pictureBoxDiamond.Width;
            int maxY = gamePanel.Height - pictureBoxDiamond.Height;

            int randomX = BalanceRandom.Next(0, maxX);
            int randomY = BalanceRandom.Next(100, maxY);

            pictureBoxDiamond.Location = new Point(randomX, randomY);
        }


        // Timantti paneelista buttoni joka vaihtaa kolikonheitto paneeliin
        private void panelSwitchBtn_Click(object sender, EventArgs e)
        {
            playPanel.Visible = false;
            shopPanel.Visible = false;
            gamePanel.Visible = false;
            betPanel.Visible = true;

            timerAutoClicker.Stop();
            timerGoldenDiamond.Stop();

            selectionLabel.Text = "";
            resultLabel.Text = "";
            errorLabel.Text = "";
            winLabel.Text = "";
            betAmount.Text = "";

            UpdateBalanceLabels();
        }

        // Kaikkien sivujen takaisin napit jotka vie takaisin timanttien keräyksee
        private void backBtn_Click(object sender, EventArgs e)
        {
            playPanel.Visible = false;
            shopPanel.Visible = false;
            betPanel.Visible = false;
            gamePanel.Visible = true;

            if (autoClickerEnabled)
            {
                timerAutoClicker.Start();
            }
            timerGoldenDiamond.Start();

            selectionLabel.Text = "";
            resultLabel.Text = "";
            errorLabel.Text = "";
            winLabel.Text = "";
            betAmount.Text = "";

            UpdateBalanceLabels();
        }

        // toinen takaisin buttoni
        private void backBtn2_Click(object sender, EventArgs e)
        {
            playPanel.Visible = false;
            shopPanel.Visible = false;
            betPanel.Visible = false;
            gamePanel.Visible = true;

            if (autoClickerEnabled)
            {
                timerAutoClicker.Start();
            }
            timerGoldenDiamond.Start();

            selectionLabel.Text = "";
            resultLabel.Text = "";
            errorLabel.Text = "";
            winLabel.Text = "";
            betAmount.Text = "";

            UpdateBalanceLabels();
        }

        // kolmas takaisin buttoni
        private void backBtn3_Click(object sender, EventArgs e)
        {
            playPanel.Visible = false;
            shopPanel.Visible = false;
            betPanel.Visible = false;
            gamePanel.Visible = true;

            if (autoClickerEnabled)
            {
                timerAutoClicker.Start();
            }
            timerGoldenDiamond.Start();

            selectionLabel.Text = "";
            resultLabel.Text = "";
            errorLabel.Text = "";
            winLabel.Text = "";
            betAmount.Text = "";

            UpdateBalanceLabels();
        }

        // Kaupan buttonit joilla ostetaan päivityksiä
        private void btnBuyUpgrade1_Click(object sender, EventArgs e)
        {
            if (upgrade1Purchased)
            {
                MessageBox.Show("Tämä päivitys on jo ostettu!");
                return;
            }

            int upgradeCost = 100;

            if (balance >= upgradeCost)
            {
                balance -= upgradeCost;
                diamondMultiplier = 2;
                upgrade1Purchased = true;
                UpdateBalanceLabels();
                MessageBox.Show("Päivitys Ostettu!");
            }
            else
            {
                MessageBox.Show("Ei tarpeeksi timantteja!");
            }
        }

        // Toisen kaupan buttonin funktio
        private void btnBuyUpgrade2_Click(object sender, EventArgs e)
        {
            if (upgrade2Purchased)
            {
                MessageBox.Show("Tämä päivitys on jo ostettu!");
                return;
            }

            int upgradeCost = 350;

            if (balance >= upgradeCost)
            {
                balance -= upgradeCost;
                autoClickerEnabled = true;
                timerAutoClicker.Start();
                upgrade2Purchased = true;
                UpdateBalanceLabels();
                MessageBox.Show("Päivitys Ostettu!");
            }
            else
            {
                MessageBox.Show("Ei tarpeeksi timantteja!");
            }
        }

        // ja kolmannen kaupan buttonin funktio
        private void btnBuyUpgrade3_Click(object sender, EventArgs e)
        {
            if (upgrade3Purchased)
            {
                MessageBox.Show("Tämä päivitys on jo ostettu!");
                return;
            }

            int upgradeCost = 500;

            if (balance >= upgradeCost)
            {
                balance -= upgradeCost;
                goldenDiamondUpgradePurchased = true;
                upgrade3Purchased = true;
                UpdateBalanceLabels();
                MessageBox.Show("Päivitys Ostettu!");
            }
            else
            {
                MessageBox.Show("Ei tarpeeksi timantteja!");
            }
        }

        // Kultanen timantti päivityksen määritykset
        private void goldenDiamond_Click(object sender, EventArgs e)
        {
            int goldenDiamondValue = 150 * diamondMultiplier;

            balance += goldenDiamondValue;
            UpdateBalanceLabels();

            goldenDiamond.Visible = false;
        }

        // Arpoo randomilla paikan mihin kultainen timantti spawnaa kahden minuutin välein
        private void timerGoldenDiamond_Tick(object sender, EventArgs e)
        {
            if (goldenDiamondUpgradePurchased)
            {
                Random rand = new Random();
                int x = rand.Next(50, gamePanel.Width - 100);
                int y = rand.Next(50, gamePanel.Height - 100);

                goldenDiamond.Location = new Point(x, y);
                goldenDiamond.Visible = true;
            }
        }

        // Auto clickerin funktio. Antaa 100 timanttia automaattisesti joka minuutti
        private void timerAutoClicker_Tick(object sender, EventArgs e)
        {
            balance += 100;
            UpdateBalanceLabels();
        }

        // Buttoni joka vie kauppaan timantti paneelista
        private void shopBtn_Click(object sender, EventArgs e)
        {
            betPanel.Visible = false;
            shopPanel.Visible = true;
            playPanel.Visible = false;
            gamePanel.Visible = false;

            selectionLabel.Text = "";
            resultLabel.Text = "";
            errorLabel.Text = "";
            winLabel.Text = "";
            betAmount.Text = "";

            UpdateBalanceLabels();
        }

        // funktiot jotka tapahtuu ku pelin aukasee
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBalanceFromFile();
            UpdateBalanceLabels();
            InitializeEventTimer();
        }

        // tallentaa lompakon kun peli laitetaan kiinni
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveBalanceToFile();
        }

        // funktio lompakon lataamisessa
        private void LoadBalanceFromFile()
        {
            string filePath = Path.Combine(Application.StartupPath, "lompakko.txt");

            // Funktio tarkistaa onko tiedostoa olemassa
            if (File.Exists(filePath))
            {
                try
                {
                    // Lukee lompakon tiedostosta
                    string balanceText = File.ReadAllText(filePath);
                    int.TryParse(balanceText, out balance);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errori tiedoston lukemisessa: {ex.Message}");
                }
            }
            else
            {
                // Jos tiedostoa ei oo se ottaa perusarvon lompakolle
                balance = 0;
            }
        }

        // funktio lompakon tallentamiseen
        private void SaveBalanceToFile()
        {
            string filePath = Path.Combine(Application.StartupPath, "lompakko.txt");

            try
            {
                // Tallentaa tiedostoon lompakon
                File.WriteAllText(filePath, balance.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errori tiedostoon tallentamisessa: {ex.Message}");
            }
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        private void playPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
