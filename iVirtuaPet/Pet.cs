using iVirtuaPet.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iVirtuaPet
{
    class Pet : Emotion
    {
        private LifeStateEnum lifeState;
        public LifeStateEnum LifeState
        {
            get { return lifeState; }
            set
            {
                lifeState = value;
                OnLifeStateChanged();
            }
        }


        public event System.EventHandler LifeStateChanged;

        protected virtual void OnLifeStateChanged()
        {
            if (LifeStateChanged != null) LifeStateChanged(this, EventArgs.Empty);
        }

        public Pet()
        {
            LifeState = LifeStateEnum.Alive;

            _ = new Emotion();
            _ = new Hunger();
            _ = new Happy();
            _ = new Sleep();

        }

    }
}
