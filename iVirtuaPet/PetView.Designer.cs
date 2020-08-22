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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetView));
            this.btnHappy = new System.Windows.Forms.Button();
            this.btnSad = new System.Windows.Forms.Button();
            this.picBoxPetViewer = new System.Windows.Forms.PictureBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.textBoxHungerLevel = new System.Windows.Forms.TextBox();
            this.labelHunger = new System.Windows.Forms.Label();
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
            this.textBoxHungerLevel.Location = new System.Drawing.Point(425, 37);
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
            // PetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(672, 603);
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
    }
}

