﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iVirtuaPet
{
    public partial class PetView : Form
    {
        Pet PetObj = new Pet();
        

        public PetView()
        {
            InitializeComponent();
            PetObj.EmotionChanged += HandleEmotionChanged;
        }

        private void HandleEmotionChanged(object sender, EventArgs e)
        {
            ImageDisplayConverter Display = new ImageDisplayConverter();

            Display.ConvertEnumToImage(PetObj.CurrentEmotion());

            picBoxPetViewer.Image = Display.ConvertEnumToImage(PetObj.CurrentEmotion());
        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            PetObj.ChangeEmotion(EmotionEnum.Happy);
        }

        private void btnSad_Click(object sender, EventArgs e)
        {
            PetObj.ChangeEmotion(EmotionEnum.Sad);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var value = RandomEnumValueHelper.RandomEnumValue<EmotionEnum>();
            PetObj.ChangeEmotion(value);

        }
    }
}
