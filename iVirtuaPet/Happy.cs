using iVirtuaPet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iVirtuaPet
{
    public partial class Happy : Sleep, IHappy
    {
        private readonly int maxHappyLevel = 100;

        private readonly int minHappyLevel = 0;

        private int happyLevel;

        public int HappyLevel
        {
            get { return happyLevel; }
            set
            {
                happyLevel = value;
                OnHappyChanged();
            }
        }

        public event System.EventHandler HappyChanged;

        protected virtual void OnHappyChanged()
        {
            if (HappyChanged != null) HappyChanged(this, EventArgs.Empty);
        }
        public int CurrentHappyLevel()
        {
            int getCurrentHappy = happyLevel;
            return getCurrentHappy;
        }

        public void SetDefaultHappyLevel()
        {
            int defaulthappy = maxHappyLevel;

            happyLevel = defaulthappy;
        }

        public void HappyTick()
        {
            throw new NotImplementedException();
        }

        public Happy()
        {
            SetDefaultHappyLevel();
        }
    }
}
