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
            // no implementation yet
        }

        public string ConvertEnumToImage(EmotionEnum passedEnum)
        {
            switch(passedEnum)
            {
                case EmotionEnum.Happy:
                    // code

                    MessageBox.Show("Emotion Enum passed to converter is HAPPY");

                    break;
                case EmotionEnum.Sad:

                    MessageBox.Show("Emotion Enum passed to converter is SAD");
                    // code
                    break;
                default:
                    // code
                    break;
            }
             

            string someValue = "test";
            return someValue;
        }

        
    }
}
