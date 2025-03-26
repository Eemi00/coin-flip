namespace coin_flip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.betPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.tailsBtn = new System.Windows.Forms.RadioButton();
            this.headsBtn = new System.Windows.Forms.RadioButton();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playPanel = new System.Windows.Forms.Panel();
            this.playagainBtn = new System.Windows.Forms.Button();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.pictureBoxDiamond = new System.Windows.Forms.PictureBox();
            this.panelSwitchBtn = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.backBtn2 = new System.Windows.Forms.Button();
            this.balanceLabel2 = new System.Windows.Forms.Label();
            this.betAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.betPanel.SuspendLayout();
            this.playPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiamond)).BeginInit();
            this.SuspendLayout();
            // 
            // betPanel
            // 
            this.betPanel.Controls.Add(this.label2);
            this.betPanel.Controls.Add(this.betAmount);
            this.betPanel.Controls.Add(this.balanceLabel2);
            this.betPanel.Controls.Add(this.backBtn);
            this.betPanel.Controls.Add(this.errorLabel);
            this.betPanel.Controls.Add(this.tailsBtn);
            this.betPanel.Controls.Add(this.headsBtn);
            this.betPanel.Controls.Add(this.startBtn);
            this.betPanel.Controls.Add(this.label1);
            this.betPanel.Location = new System.Drawing.Point(0, 0);
            this.betPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.betPanel.Name = "betPanel";
            this.betPanel.Size = new System.Drawing.Size(1131, 700);
            this.betPanel.TabIndex = 0;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(440, 559);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 8;
            // 
            // tailsBtn
            // 
            this.tailsBtn.AutoSize = true;
            this.tailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tailsBtn.ForeColor = System.Drawing.Color.White;
            this.tailsBtn.Location = new System.Drawing.Point(610, 261);
            this.tailsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tailsBtn.Name = "tailsBtn";
            this.tailsBtn.Size = new System.Drawing.Size(103, 30);
            this.tailsBtn.TabIndex = 7;
            this.tailsBtn.TabStop = true;
            this.tailsBtn.Text = "Klaava";
            this.tailsBtn.UseVisualStyleBackColor = true;
            // 
            // headsBtn
            // 
            this.headsBtn.AutoSize = true;
            this.headsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headsBtn.ForeColor = System.Drawing.Color.White;
            this.headsBtn.Location = new System.Drawing.Point(412, 261);
            this.headsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headsBtn.Name = "headsBtn";
            this.headsBtn.Size = new System.Drawing.Size(106, 30);
            this.headsBtn.TabIndex = 6;
            this.headsBtn.TabStop = true;
            this.headsBtn.Text = "Kruuna";
            this.headsBtn.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.startBtn.FlatAppearance.BorderSize = 5;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(511, 446);
            this.startBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(95, 32);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Aloita";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UniSansBold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(406, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valitse kruuna vai klaava";
            // 
            // playPanel
            // 
            this.playPanel.Controls.Add(this.backBtn2);
            this.playPanel.Controls.Add(this.playagainBtn);
            this.playPanel.Controls.Add(this.selectionLabel);
            this.playPanel.Controls.Add(this.resultLabel);
            this.playPanel.Controls.Add(this.winLabel);
            this.playPanel.Controls.Add(this.pictureBox1);
            this.playPanel.Location = new System.Drawing.Point(0, 0);
            this.playPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playPanel.Name = "playPanel";
            this.playPanel.Size = new System.Drawing.Size(1414, 874);
            this.playPanel.TabIndex = 9;
            this.playPanel.Visible = false;
            // 
            // playagainBtn
            // 
            this.playagainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagainBtn.Location = new System.Drawing.Point(465, 604);
            this.playagainBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playagainBtn.Name = "playagainBtn";
            this.playagainBtn.Size = new System.Drawing.Size(159, 28);
            this.playagainBtn.TabIndex = 1;
            this.playagainBtn.Text = "Pelaa Uudestaan";
            this.playagainBtn.UseVisualStyleBackColor = true;
            this.playagainBtn.Click += new System.EventHandler(this.playagainBtn_Click);
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionLabel.ForeColor = System.Drawing.Color.White;
            this.selectionLabel.Location = new System.Drawing.Point(477, 95);
            this.selectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(0, 24);
            this.selectionLabel.TabIndex = 0;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(500, 521);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 24);
            this.resultLabel.TabIndex = 3;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(440, 557);
            this.winLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(0, 24);
            this.winLabel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 452);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.panelSwitchBtn);
            this.gamePanel.Controls.Add(this.pictureBoxDiamond);
            this.gamePanel.Controls.Add(this.balanceLabel);
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(1131, 697);
            this.gamePanel.TabIndex = 5;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.BackColor = System.Drawing.Color.White;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.ForeColor = System.Drawing.Color.Black;
            this.balanceLabel.Location = new System.Drawing.Point(21, 21);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(156, 24);
            this.balanceLabel.TabIndex = 0;
            this.balanceLabel.Text = "Lompakko: 0 💎";
            // 
            // pictureBoxDiamond
            // 
            this.pictureBoxDiamond.Image = global::coin_flip.Properties.Resources.diamond;
            this.pictureBoxDiamond.Location = new System.Drawing.Point(1051, 0);
            this.pictureBoxDiamond.Name = "pictureBoxDiamond";
            this.pictureBoxDiamond.Size = new System.Drawing.Size(80, 75);
            this.pictureBoxDiamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDiamond.TabIndex = 1;
            this.pictureBoxDiamond.TabStop = false;
            // 
            // panelSwitchBtn
            // 
            this.panelSwitchBtn.AutoSize = true;
            this.panelSwitchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelSwitchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSwitchBtn.ForeColor = System.Drawing.Color.Black;
            this.panelSwitchBtn.Location = new System.Drawing.Point(477, 28);
            this.panelSwitchBtn.Name = "panelSwitchBtn";
            this.panelSwitchBtn.Size = new System.Drawing.Size(145, 24);
            this.panelSwitchBtn.TabIndex = 2;
            this.panelSwitchBtn.Text = "Heitä kolikkoa!";
            this.panelSwitchBtn.Click += new System.EventHandler(this.panelSwitchBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.backBtn.FlatAppearance.BorderSize = 5;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(511, 500);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(95, 32);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Poistu";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // backBtn2
            // 
            this.backBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn2.Location = new System.Drawing.Point(465, 650);
            this.backBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn2.Name = "backBtn2";
            this.backBtn2.Size = new System.Drawing.Size(159, 28);
            this.backBtn2.TabIndex = 5;
            this.backBtn2.Text = "Poistu";
            this.backBtn2.UseVisualStyleBackColor = true;
            this.backBtn2.Click += new System.EventHandler(this.backBtn2_Click);
            // 
            // balanceLabel2
            // 
            this.balanceLabel2.AutoSize = true;
            this.balanceLabel2.BackColor = System.Drawing.Color.White;
            this.balanceLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel2.ForeColor = System.Drawing.Color.Black;
            this.balanceLabel2.Location = new System.Drawing.Point(21, 21);
            this.balanceLabel2.Name = "balanceLabel2";
            this.balanceLabel2.Size = new System.Drawing.Size(156, 24);
            this.balanceLabel2.TabIndex = 10;
            this.balanceLabel2.Text = "Lompakko: 0 💎";
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(511, 372);
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(95, 20);
            this.betAmount.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("UniSansBold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(460, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Timanttien määrä";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1130, 689);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.betPanel);
            this.Controls.Add(this.playPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.betPanel.ResumeLayout(false);
            this.betPanel.PerformLayout();
            this.playPanel.ResumeLayout(false);
            this.playPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiamond)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel betPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.RadioButton headsBtn;
        private System.Windows.Forms.RadioButton tailsBtn;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Panel playPanel;
        private System.Windows.Forms.Button playagainBtn;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.PictureBox pictureBoxDiamond;
        private System.Windows.Forms.Label panelSwitchBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button backBtn2;
        private System.Windows.Forms.Label balanceLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox betAmount;
    }
}

