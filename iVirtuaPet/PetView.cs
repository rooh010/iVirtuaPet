using iVirtuaPet.Enums;
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

            textBoxHappyLevel.ReadOnly = true;
            textBoxHappyLevel.BackColor = System.Drawing.SystemColors.Window;
            textBoxHappyLevel.Text = PetObj.CurrentHappyLevel().ToString();

            textBoxSleepLevel.ReadOnly = true;
            textBoxSleepLevel.BackColor = System.Drawing.SystemColors.Window;
            textBoxSleepLevel.Text = PetObj.CurrentSleepLevel().ToString();

            PetObj.EmotionChanged += HandleEmotionChanged;
            PetObj.HungerChanged += HandleHungerChanged;
            PetObj.HappyChanged += HandleHappyChanged;
            PetObj.SleepChanged += HandleSleepChanged;
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

        private void HandleHappyChanged(object sender, EventArgs e)
        {
            textBoxHappyLevel.Text = PetObj.CurrentHappyLevel().ToString();
        }

        private void HandleSleepChanged(object sender, EventArgs e)
        {
            textBoxSleepLevel.Text = PetObj.CurrentSleepLevel().ToString();
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
