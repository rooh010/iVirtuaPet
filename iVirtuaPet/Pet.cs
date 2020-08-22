using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iVirtuaPet
{
    class Pet
    {
        public Pet()
        {
            Emotion EmotionalState = new Emotion();
            MessageBox.Show(EmotionalState.EmotionSet.ToString());



        }
    }
}
