using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iVirtuaPet
{
    public partial class Hunger : IHunger
    {
        public void CurrentHungerLevel()
        {
            MessageBox.Show("current hunger level here");
        }

        public void FeedPet()
        {
            throw new NotImplementedException();
        }

        public void SetDefaultHungerLevel()
        {
            throw new NotImplementedException();
        }
    }
}
