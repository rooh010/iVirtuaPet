using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iVirtuaPet
{
    public class Emotion : IEmotion
    {
        public EmotionEnum EmotionSet;

        public Emotion()
        {
            EmotionSet = SetDefaultEmotion();

        }



        public EmotionEnum ChangeEmotion(EmotionEnum emotionSet)
        {
            throw new NotImplementedException();
        }

 

        public EmotionEnum CurrentEmotion(EmotionEnum emotionSet)
        {
            throw new NotImplementedException();
        }

        public EmotionEnum SetDefaultEmotion()
        {
            EmotionEnum defaultEnum = EmotionEnum.Happy;
            return defaultEnum;
        }
    }


 }

