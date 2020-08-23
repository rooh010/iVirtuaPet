﻿namespace iVirtuaPet
{
    partial class PetView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetView));
            this.btnHappy = new System.Windows.Forms.Button();
            this.btnSad = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.textBoxHungerLevel = new System.Windows.Forms.TextBox();
            this.labelHunger = new System.Windows.Forms.Label();
            this.labelHappy = new System.Windows.Forms.Label();
            this.textBoxHappyLevel = new System.Windows.Forms.TextBox();
            this.picBoxPetViewer = new System.Windows.Forms.PictureBox();
            this.labelSleep = new System.Windows.Forms.Label();
            this.textBoxSleepLevel = new System.Windows.Forms.TextBox();
            this.SleepTimer = new System.Windows.Forms.Timer(this.components);
            this.HappyTimer = new System.Windows.Forms.Timer(this.components);
            this.HungerTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBarHunger = new System.Windows.Forms.ProgressBar();
            this.progressBarHappy = new System.Windows.Forms.ProgressBar();
            this.progressBarSleep = new System.Windows.Forms.ProgressBar();
            this.progressBarAction = new System.Windows.Forms.ProgressBar();
            this.ActionTimer = new System.Windows.Forms.Timer(this.components);
            this.labelPetName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPetViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHappy
            // 
            this.btnHappy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHappy.Location = new System.Drawing.Point(29, 434);
            this.btnHappy.Name = "btnHappy";
            this.btnHappy.Size = new System.Drawing.Size(125, 59);
            this.btnHappy.TabIndex = 1;
            this.btnHappy.Text = "Happy";
            this.btnHappy.UseVisualStyleBackColor = false;
            this.btnHappy.Click += new System.EventHandler(this.btnHappy_Click);
            // 
            // btnSad
            // 
            this.btnSad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSad.Location = new System.Drawing.Point(29, 505);
            this.btnSad.Name = "btnSad";
            this.btnSad.Size = new System.Drawing.Size(125, 59);
            this.btnSad.TabIndex = 2;
            this.btnSad.Text = "Sad";
            this.btnSad.UseVisualStyleBackColor = false;
            this.btnSad.Click += new System.EventHandler(this.btnSad_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRandom.Location = new System.Drawing.Point(160, 434);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(125, 59);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // textBoxHungerLevel
            // 
            this.textBoxHungerLevel.Location = new System.Drawing.Point(425, 28);
            this.textBoxHungerLevel.Name = "textBoxHungerLevel";
            this.textBoxHungerLevel.Size = new System.Drawing.Size(137, 20);
            this.textBoxHungerLevel.TabIndex = 4;
            this.textBoxHungerLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHunger
            // 
            this.labelHunger.AutoSize = true;
            this.labelHunger.Location = new System.Drawing.Point(425, 12);
            this.labelHunger.Name = "labelHunger";
            this.labelHunger.Size = new System.Drawing.Size(42, 13);
            this.labelHunger.TabIndex = 5;
            this.labelHunger.Text = "Hunger";
            // 
            // labelHappy
            // 
            this.labelHappy.AutoSize = true;
            this.labelHappy.Location = new System.Drawing.Point(425, 105);
            this.labelHappy.Name = "labelHappy";
            this.labelHappy.Size = new System.Drawing.Size(57, 13);
            this.labelHappy.TabIndex = 7;
            this.labelHappy.Text = "Happiness";
            // 
            // textBoxHappyLevel
            // 
            this.textBoxHappyLevel.Location = new System.Drawing.Point(425, 121);
            this.textBoxHappyLevel.Name = "textBoxHappyLevel";
            this.textBoxHappyLevel.Size = new System.Drawing.Size(137, 20);
            this.textBoxHappyLevel.TabIndex = 6;
            this.textBoxHappyLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBoxPetViewer
            // 
            this.picBoxPetViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxPetViewer.ErrorImage = null;
            this.picBoxPetViewer.Image = global::iVirtuaPet.Properties.Resources.happy;
            this.picBoxPetViewer.InitialImage = null;
            this.picBoxPetViewer.Location = new System.Drawing.Point(29, 12);
            this.picBoxPetViewer.Name = "picBoxPetViewer";
            this.picBoxPetViewer.Size = new System.Drawing.Size(375, 416);
            this.picBoxPetViewer.TabIndex = 0;
            this.picBoxPetViewer.TabStop = false;
            // 
            // labelSleep
            // 
            this.labelSleep.AutoSize = true;
            this.labelSleep.Location = new System.Drawing.Point(425, 203);
            this.labelSleep.Name = "labelSleep";
            this.labelSleep.Size = new System.Drawing.Size(34, 13);
            this.labelSleep.TabIndex = 9;
            this.labelSleep.Text = "Sleep";
            // 
            // textBoxSleepLevel
            // 
            this.textBoxSleepLevel.Location = new System.Drawing.Point(425, 219);
            this.textBoxSleepLevel.Name = "textBoxSleepLevel";
            this.textBoxSleepLevel.Size = new System.Drawing.Size(137, 20);
            this.textBoxSleepLevel.TabIndex = 8;
            this.textBoxSleepLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SleepTimer
            // 
            this.SleepTimer.Enabled = true;
            this.SleepTimer.Interval = 30000;
            this.SleepTimer.Tick += new System.EventHandler(this.SleepTimer_Tick);
            // 
            // HappyTimer
            // 
            this.HappyTimer.Enabled = true;
            this.HappyTimer.Interval = 10000;
            this.HappyTimer.Tick += new System.EventHandler(this.HappyTimer_Tick);
            // 
            // HungerTimer
            // 
            this.HungerTimer.Enabled = true;
            this.HungerTimer.Interval = 20000;
            this.HungerTimer.Tick += new System.EventHandler(this.HungerTimer_Tick);
            // 
            // progressBarHunger
            // 
            this.progressBarHunger.Location = new System.Drawing.Point(425, 55);
            this.progressBarHunger.MarqueeAnimationSpeed = 50;
            this.progressBarHunger.Name = "progressBarHunger";
            this.progressBarHunger.Size = new System.Drawing.Size(137, 23);
            this.progressBarHunger.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarHunger.TabIndex = 10;
            // 
            // progressBarHappy
            // 
            this.progressBarHappy.Location = new System.Drawing.Point(425, 147);
            this.progressBarHappy.MarqueeAnimationSpeed = 50;
            this.progressBarHappy.Name = "progressBarHappy";
            this.progressBarHappy.Size = new System.Drawing.Size(137, 23);
            this.progressBarHappy.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarHappy.TabIndex = 11;
            // 
            // progressBarSleep
            // 
            this.progressBarSleep.Location = new System.Drawing.Point(425, 245);
            this.progressBarSleep.MarqueeAnimationSpeed = 50;
            this.progressBarSleep.Name = "progressBarSleep";
            this.progressBarSleep.Size = new System.Drawing.Size(137, 23);
            this.progressBarSleep.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarSleep.TabIndex = 12;
            // 
            // progressBarAction
            // 
            this.progressBarAction.Location = new System.Drawing.Point(29, 571);
            this.progressBarAction.MarqueeAnimationSpeed = 50;
            this.progressBarAction.Maximum = 10000;
            this.progressBarAction.Name = "progressBarAction";
            this.progressBarAction.Size = new System.Drawing.Size(533, 23);
            this.progressBarAction.TabIndex = 13;
            // 
            // ActionTimer
            // 
            this.ActionTimer.Enabled = true;
            this.ActionTimer.Interval = 1000;
            this.ActionTimer.Tick += new System.EventHandler(this.ActionTimer_Tick);
            // 
            // labelPetName
            // 
            this.labelPetName.AutoSize = true;
            this.labelPetName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetName.Location = new System.Drawing.Point(424, 520);
            this.labelPetName.Name = "labelPetName";
            this.labelPetName.Size = new System.Drawing.Size(0, 23);
            this.labelPetName.TabIndex = 14;
            // 
            // PetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(586, 603);
            this.Controls.Add(this.labelPetName);
            this.Controls.Add(this.progressBarAction);
            this.Controls.Add(this.progressBarSleep);
            this.Controls.Add(this.progressBarHappy);
            this.Controls.Add(this.progressBarHunger);
            this.Controls.Add(this.labelSleep);
            this.Controls.Add(this.textBoxSleepLevel);
            this.Controls.Add(this.labelHappy);
            this.Controls.Add(this.textBoxHappyLevel);
            this.Controls.Add(this.labelHunger);
            this.Controls.Add(this.textBoxHungerLevel);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnSad);
            this.Controls.Add(this.btnHappy);
            this.Controls.Add(this.picBoxPetViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PetView";
            this.Text = "iVirtuaPet";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPetViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxPetViewer;
        private System.Windows.Forms.Button btnHappy;
        private System.Windows.Forms.Button btnSad;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox textBoxHungerLevel;
        private System.Windows.Forms.Label labelHunger;
        private System.Windows.Forms.Label labelHappy;
        private System.Windows.Forms.TextBox textBoxHappyLevel;
        private System.Windows.Forms.Label labelSleep;
        private System.Windows.Forms.TextBox textBoxSleepLevel;
        private System.Windows.Forms.Timer SleepTimer;
        private System.Windows.Forms.Timer HappyTimer;
        private System.Windows.Forms.Timer HungerTimer;
        private System.Windows.Forms.ProgressBar progressBarHunger;
        private System.Windows.Forms.ProgressBar progressBarHappy;
        private System.Windows.Forms.ProgressBar progressBarSleep;
        private System.Windows.Forms.ProgressBar progressBarAction;
        private System.Windows.Forms.Timer ActionTimer;
        private System.Windows.Forms.Label labelPetName;
    }
}

