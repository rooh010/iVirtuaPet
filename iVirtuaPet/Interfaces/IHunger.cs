using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iVirtuaPet
{
    interface IHunger
    {
        void SetDefaultHungerLevel();

        int CurrentHungerLevel();

        void FeedPet();

    }
}
