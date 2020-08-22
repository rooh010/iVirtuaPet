using System;
using System.Windows.Forms;

namespace iVirtuaPet
{
    public partial class PetView : Form
    {
        Pet PetObj = new Pet();


        public PetView()
        {
            InitializeComponent();
            textBoxHungerLevel.ReadOnly = true;
            textBoxHungerLevel.BackColor = System.Drawing.SystemColors.Window;
            textBoxHungerLevel.Text = PetObj.CurrentHungerLevel().ToString();
            PetObj.EmotionChanged += HandleEmotionChanged;
            PetObj.HungerChanged += HandleHungerChanged;
        }

        private void HandleEmotionChanged(object sender, EventArgs e)
        {
            ImageDisplayConverter Display = new ImageDisplayConverter();

            Display.ConvertEnumToImage(PetObj.CurrentEmotion());

            picBoxPetViewer.Image = Display.ConvertEnumToImage(PetObj.CurrentEmotion());
        }

        private void HandleHungerChanged(object sender, EventArgs e)
        {
            textBoxHungerLevel.Text = PetObj.CurrentHungerLevel().ToString();

        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            PetObj.ChangeEmotion(EmotionEnum.Happy);
        }

        private void btnSad_Click(object sender, EventArgs e)
        {
            PetObj.ChangeEmotion(EmotionEnum.Sad);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var value = RandomEnumValueHelper.RandomEnumValue<EmotionEnum>();
            PetObj.ChangeEmotion(value);

        }
    }
}
