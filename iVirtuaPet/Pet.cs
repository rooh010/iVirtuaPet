﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iVirtuaPet
{
    class Pet : Emotion
    {
        public Pet()
        {
            Emotion EmotionalState = new Emotion();

            //MessageBox.Show(EmotionalState.CurrentEmotion().ToString());

            //EmotionalState.ChangeEmotion(EmotionEnum.Sad);
            //MessageBox.Show(EmotionalState.CurrentEmotion().ToString());

        }

    }
}
