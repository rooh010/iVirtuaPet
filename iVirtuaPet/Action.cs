using iVirtuaPet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iVirtuaPet
{
    // Action points for using abilities to bring your attributes up
    public partial class Action : IAction
    {
        private readonly int maxActionLevel = 10000;

        private readonly int minActionLevel = 0;

        private int actionLevel;

        public int ActionLevel
        {
            get { return actionLevel; }
            set
            {
                actionLevel = value;
                OnActionChanged();
            }
        }

        public event System.EventHandler ActionChanged;

        protected virtual void OnActionChanged()
        {
            if (ActionChanged != null) ActionChanged(this, EventArgs.Empty);
        }
        public int CurrentActionLevel()
        {
            int getCurrentAction = actionLevel;
            return getCurrentAction;
        }

        public void SetDefaultActionLevel()
        {
            int defaultaction = maxActionLevel;

            actionLevel = defaultaction;
        }

        public void ActionTick()
        {
            if (ActionLevel < maxActionLevel-1 && ActionLevel > minActionLevel )
            ActionLevel = ActionLevel + 100;
            
        }

        public void UseAction(int actionPoints)
        {
            ActionLevel = ActionLevel - actionPoints;
        }

        public Action()
        {
            SetDefaultActionLevel();
        }
    }
}
