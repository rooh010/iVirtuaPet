using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iVirtuaPet
{
    interface IEmotion
    {

        EmotionEnum SetDefaultEmotion();

        EmotionEnum CurrentEmotion(EmotionEnum emotionSet);

        EmotionEnum ChangeEmotion(EmotionEnum emotionSet);

    }
}
