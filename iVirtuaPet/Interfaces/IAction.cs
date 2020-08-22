namespace iVirtuaPet.Interfaces
{
    interface IAction
    {
        void SetDefaultActionLevel();

        int CurrentActionLevel();

        void ActionTick();

        void UseAction(int actionPoints);

    }
}
