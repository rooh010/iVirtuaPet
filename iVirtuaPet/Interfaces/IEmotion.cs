using iVirtuaPet.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iVirtuaPet.Interfaces
{
    interface IEmotion
    {

        EmotionEnum SetDefaultEmotion();

        EmotionEnum CurrentEmotion();

        EmotionEnum ChangeEmotion(EmotionEnum emotionSet);

    }
}
