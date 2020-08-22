using iVirtuaPet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iVirtuaPet
{
    public partial class Hunger : Happy, IHunger
    {
        private readonly int maxHungerLevel = 100;

        private readonly int minHungerLevel = 0;

        private int hungerLevel;

        public int HungerLevel
        {
            get { return hungerLevel; }
            set
            {
                hungerLevel = value;
                OnHungerChanged();
            }
        }

        public event System.EventHandler HungerChanged;

        protected virtual void OnHungerChanged()
        {
            if (HungerChanged != null) HungerChanged(this, EventArgs.Empty);
        }
        public int CurrentHungerLevel()
        {
            int getCurrentHunger = hungerLevel;
            return getCurrentHunger;
        }

        public Hunger()
        {
            SetDefaultHungerLevel();
        }

        public void FeedPet()
        {
            throw new NotImplementedException();
        }

        public void SetDefaultHungerLevel()
        {
            int defaulthunger = maxHungerLevel;

            hungerLevel = defaulthunger;
        }

        public void HungerTick()
        {
            if (HungerLevel > 100 && HungerLevel < 0)
                HungerLevel = HungerLevel - 1;
        }
    }
}
