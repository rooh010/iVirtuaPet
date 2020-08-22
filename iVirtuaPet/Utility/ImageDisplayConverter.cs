using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iVirtuaPet
{
    class ImageDisplayConverter
    {
        

        public ImageDisplayConverter()
        {


        }

        public System.Drawing.Image ConvertEnumToImage(EmotionEnum passedEnum)
        {
            switch (passedEnum)
            {
                case EmotionEnum.Happy:
                    return global::iVirtuaPet.Properties.Resources.happy;
                case EmotionEnum.Sad:
                    return global::iVirtuaPet.Properties.Resources.sad;
                case EmotionEnum.Angry:
                    return global::iVirtuaPet.Properties.Resources.angry;
                case EmotionEnum.Asleep:
                    return global::iVirtuaPet.Properties.Resources.asleep;
                case EmotionEnum.Hungry:
                    return global::iVirtuaPet.Properties.Resources.hungry;
                case EmotionEnum.Sleepy:
                    return global::iVirtuaPet.Properties.Resources.sleepy;
                case EmotionEnum.Unknown:
                    return global::iVirtuaPet.Properties.Resources.unknown;
                case EmotionEnum.Indifferent:
                    return global::iVirtuaPet.Properties.Resources.indifferent;
                case EmotionEnum.Dead:
                    return global::iVirtuaPet.Properties.Resources.dead;
                default:
                    return global::iVirtuaPet.Properties.Resources.unknown;
            }

        }


    }
}
