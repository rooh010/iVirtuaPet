using iVirtuaPet.Enums;
using iVirtuaPet.Interfaces;
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

        public EmotionEnum EmotionSet
        {
            get { return emotionSet; }
            set
            {
                emotionSet = value;
                OnEmotionChanged();
            }
        }


        public event System.EventHandler EmotionChanged;

        protected virtual void OnEmotionChanged()
        {
            if (EmotionChanged != null) EmotionChanged(this, EventArgs.Empty);
        }

        public Emotion()
        {
            EmotionSet = SetDefaultEmotion();

        }

        public EmotionEnum ChangeEmotion(EmotionEnum emotion)
        {
            EmotionSet = emotion;

            return emotion;
        }


        public EmotionEnum CurrentEmotion()
        {
            EmotionEnum currentEnum = EmotionSet;
            return currentEnum;
        }

        public EmotionEnum SetDefaultEmotion()
        {
            EmotionEnum defaultEnum = EmotionEnum.Happy;
            return defaultEnum;
        }
    }


}

