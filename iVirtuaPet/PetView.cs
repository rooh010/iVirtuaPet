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

            progressBarHunger.Value = PetObj.CurrentHungerLevel();

            textBoxHappyLevel.ReadOnly = true;
            textBoxHappyLevel.BackColor = System.Drawing.SystemColors.Window;
            textBoxHappyLevel.Text = PetObj.CurrentHappyLevel().ToString();

            progressBarHappy.Value = PetObj.CurrentHappyLevel();

            textBoxSleepLevel.ReadOnly = true;
            textBoxSleepLevel.BackColor = System.Drawing.SystemColors.Window;
            textBoxSleepLevel.Text = PetObj.CurrentSleepLevel().ToString();

            progressBarSleep.Value = PetObj.CurrentSleepLevel();

            progressBarAction.Value = PetObj.CurrentActionLevel();

            PetObj.EmotionChanged += HandleEmotionChanged;
            PetObj.HungerChanged += HandleHungerChanged;
            PetObj.HappyChanged += HandleHappyChanged;
            PetObj.SleepChanged += HandleSleepChanged;
            PetObj.LifeStateChanged += HandleLifeStateChanged;
            PetObj.ActionChanged += HandleActionChanged;
        }

        private void HandleEmotionChanged(object sender, EventArgs e)
        {
            ImageDisplayConverter Display = new ImageDisplayConverter();
            picBoxPetViewer.Image = Display.ConvertEnumToImage(PetObj.CurrentEmotion());
        }

        private void HandleHungerChanged(object sender, EventArgs e)
        {
            textBoxHungerLevel.Text = PetObj.CurrentHungerLevel().ToString();
            progressBarHunger.Value = PetObj.CurrentHungerLevel();
        }

        private void HandleLifeStateChanged(object sender, EventArgs e)
        {
            MessageBox.Show(PetObj.LifeState.ToString());
        }

        private void HandleHappyChanged(object sender, EventArgs e)
        {
            textBoxHappyLevel.Text = PetObj.CurrentHappyLevel().ToString();
            progressBarHappy.Value = PetObj.CurrentHappyLevel();
        }

        private void HandleSleepChanged(object sender, EventArgs e)
        {
            textBoxSleepLevel.Text = PetObj.CurrentSleepLevel().ToString();
            progressBarSleep.Value = PetObj.CurrentSleepLevel();
        }

        private void HandleActionChanged(object sender, EventArgs e)
        {
            progressBarAction.Value = PetObj.CurrentActionLevel();
        }

        private void btnHappy_Click(object sender, EventArgs e)
        {
            PetObj.ChangeEmotion(EmotionEnum.Happy);

            //test action
            if (PetObj.CurrentActionLevel() > 500)
            PetObj.UseAction(500);
        }

        private void btnSad_Click(object sender, EventArgs e)
        {
            PetObj.ChangeEmotion(EmotionEnum.Sad);

            // test action
            if (PetObj.CurrentActionLevel() > 1000)
                PetObj.UseAction(1000);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var value = RandomEnumValueHelper.RandomEnumValue<EmotionEnum>();
            PetObj.ChangeEmotion(value);
        }

        private void SleepTimer_Tick(object sender, EventArgs e)
        {
            PetObj.SleepTick();
        }

        private void HappyTimer_Tick(object sender, EventArgs e)
        {
            PetObj.HappyTick();
        }

        private void HungerTimer_Tick(object sender, EventArgs e)
        {
            PetObj.HungerTick();
        }

        private void ActionTimer_Tick(object sender, EventArgs e)
        {
            PetObj.ActionTick();
        }
    }
}
