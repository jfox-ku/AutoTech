namespace Features.Items
{
    public interface IItemStateHandler
    {
        bool HasState(int stateId);
        void AddState(IItemState state);
        IItemState GetState(int stateId);
        T GetState<T>(int stateId) where T : IItemState;
        void RemoveState(int stateId);
        void ClearStates();

        static IItemStateHandler Default => new ItemStateHandler();
    }
}