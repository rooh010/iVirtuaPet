﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iVirtuaPet
{
    class Pet
    {
        public EmotionEnum CurrentEmotion;

        public Pet()
        {
            CurrentEmotion = EmotionEnum.Happy;
        }
    }
}
