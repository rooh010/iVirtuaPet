using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iVirtuaPet
{
    public partial class PetView : Form
    {
        Pet TestPet = new Pet();
        

        public PetView()
        {
            InitializeComponent();
            TestPet.EmotionChanged += HandleEmotionChanged;


        }

        private void HandleEmotionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("emotion changed event triggered");
        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            
            TestPet.ChangeEmotion(EmotionEnum.Happy);
            MessageBox.Show(TestPet.CurrentEmotion().ToString());
        }

        private void btnSad_Click(object sender, EventArgs e)
        {
            
            TestPet.ChangeEmotion(EmotionEnum.Sad);
            MessageBox.Show(TestPet.CurrentEmotion().ToString());
        }

    }
}
