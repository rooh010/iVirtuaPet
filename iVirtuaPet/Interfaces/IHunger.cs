namespace iVirtuaPet
{
    interface IHunger
    {
        void SetDefaultHungerLevel();

        int CurrentHungerLevel();

        void FeedPet();

    }
}
