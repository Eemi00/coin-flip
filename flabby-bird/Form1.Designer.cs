namespace flabby_bird
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
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.headsBtn = new System.Windows.Forms.RadioButton();
            this.tailsBtn = new System.Windows.Forms.RadioButton();
            this.errorLabel = new System.Windows.Forms.Label();
            this.playPanel = new System.Windows.Forms.Panel();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.playagainBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.betPanel.SuspendLayout();
            this.playPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // betPanel
            // 
            this.betPanel.Controls.Add(this.errorLabel);
            this.betPanel.Controls.Add(this.tailsBtn);
            this.betPanel.Controls.Add(this.headsBtn);
            this.betPanel.Controls.Add(this.startBtn);
            this.betPanel.Controls.Add(this.label1);
            this.betPanel.Location = new System.Drawing.Point(0, 0);
            this.betPanel.Name = "betPanel";
            this.betPanel.Size = new System.Drawing.Size(1508, 861);
            this.betPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UniSansBold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(542, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valitse kruuna vai klaava";
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.startBtn.FlatAppearance.BorderSize = 5;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(681, 492);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(127, 39);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Aloita";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // headsBtn
            // 
            this.headsBtn.AutoSize = true;
            this.headsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headsBtn.ForeColor = System.Drawing.Color.White;
            this.headsBtn.Location = new System.Drawing.Point(550, 321);
            this.headsBtn.Name = "headsBtn";
            this.headsBtn.Size = new System.Drawing.Size(133, 36);
            this.headsBtn.TabIndex = 6;
            this.headsBtn.TabStop = true;
            this.headsBtn.Text = "Kruuna";
            this.headsBtn.UseVisualStyleBackColor = true;
            // 
            // tailsBtn
            // 
            this.tailsBtn.AutoSize = true;
            this.tailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tailsBtn.ForeColor = System.Drawing.Color.White;
            this.tailsBtn.Location = new System.Drawing.Point(813, 321);
            this.tailsBtn.Name = "tailsBtn";
            this.tailsBtn.Size = new System.Drawing.Size(129, 36);
            this.tailsBtn.TabIndex = 7;
            this.tailsBtn.TabStop = true;
            this.tailsBtn.Text = "Klaava";
            this.tailsBtn.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(545, 558);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 31);
            this.errorLabel.TabIndex = 8;
            // 
            // playPanel
            // 
            this.playPanel.Controls.Add(this.playagainBtn);
            this.playPanel.Controls.Add(this.selectionLabel);
            this.playPanel.Controls.Add(this.resultLabel);
            this.playPanel.Controls.Add(this.winLabel);
            this.playPanel.Controls.Add(this.pictureBox1);
            this.playPanel.Location = new System.Drawing.Point(0, 0);
            this.playPanel.Name = "playPanel";
            this.playPanel.Size = new System.Drawing.Size(1885, 1076);
            this.playPanel.TabIndex = 9;
            this.playPanel.Visible = false;
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionLabel.ForeColor = System.Drawing.Color.White;
            this.selectionLabel.Location = new System.Drawing.Point(636, 117);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(0, 29);
            this.selectionLabel.TabIndex = 0;
            // 
            // playagainBtn
            // 
            this.playagainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagainBtn.Location = new System.Drawing.Point(620, 744);
            this.playagainBtn.Name = "playagainBtn";
            this.playagainBtn.Size = new System.Drawing.Size(212, 35);
            this.playagainBtn.TabIndex = 1;
            this.playagainBtn.Text = "Pelaa Uudestaan";
            this.playagainBtn.UseVisualStyleBackColor = true;
            this.playagainBtn.Click += new System.EventHandler(this.playagainBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 556);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(666, 641);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 29);
            this.resultLabel.TabIndex = 3;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(592, 686);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(0, 29);
            this.winLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1506, 848);
            this.Controls.Add(this.playPanel);
            this.Controls.Add(this.betPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.betPanel.ResumeLayout(false);
            this.betPanel.PerformLayout();
            this.playPanel.ResumeLayout(false);
            this.playPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

