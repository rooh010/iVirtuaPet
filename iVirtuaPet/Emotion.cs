using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iVirtuaPet
{
    public partial class Emotion : Hunger, IEmotion 
    {
        private EmotionEnum emotionSet;

        public event System.EventHandler EmotionChanged;

        protected virtual void OnEmotionChanged()
        {
            if (EmotionChanged != null) EmotionChanged(this, EventArgs.Empty);
        }

        public Emotion()
        {
            emotionSet = SetDefaultEmotion();

        }

        public EmotionEnum ChangeEmotion(EmotionEnum emotion)
        {
            emotionSet = emotion;

            OnEmotionChanged();

            return emotion;            
        }


        public EmotionEnum CurrentEmotion()
        {
            EmotionEnum currentEnum = emotionSet;
            return currentEnum;
        }

        public EmotionEnum SetDefaultEmotion()
        {
            EmotionEnum defaultEnum = EmotionEnum.Happy;
            return defaultEnum;
        }
    }


 }

