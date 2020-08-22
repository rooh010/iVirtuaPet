namespace iVirtuaPet.Interfaces
{
    interface IHunger
    {
        void SetDefaultHungerLevel();

        int CurrentHungerLevel();

        void FeedPet();

        void HungerTick();

    }
}
