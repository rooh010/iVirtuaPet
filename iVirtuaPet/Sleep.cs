using iVirtuaPet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iVirtuaPet
{
    public partial class Sleep : Action, ISleep
    {
        private readonly int maxSleepLevel = 100;

        private readonly int minSleepLevel = 0;

        private int sleepLevel;

        public int SleepLevel
        {
            get { return sleepLevel; }
            set
            {
                sleepLevel = value;
                OnSleepChanged();
            }
        }

        public event System.EventHandler SleepChanged;

        protected virtual void OnSleepChanged()
        {
            if (SleepChanged != null) SleepChanged(this, EventArgs.Empty);
        }
        public int CurrentSleepLevel()
        {
            int getCurrentSleep = sleepLevel;
            return getCurrentSleep;
        }

        public void SetDefaultSleepLevel()
        {
            int defaultsleep = maxSleepLevel;

            sleepLevel = defaultsleep;
        }

        public void SleepTick()
        {
            if (SleepLevel > 100 && SleepLevel < 0)
                SleepLevel = SleepLevel - 1;
        }

        public Sleep()
        {
            SetDefaultSleepLevel();
        }
    }
}
