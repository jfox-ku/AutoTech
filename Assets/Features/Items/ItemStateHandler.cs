using System.Collections.Generic;

namespace Features.Items
{
    public class ItemStateHandler : IItemStateHandler
    {
        private Dictionary<int, IItemState> States { get; } = new();
        
        public bool HasState(int stateId) {
            return States.ContainsKey(stateId);
        }

        public void AddState(IItemState state) {
            States.Add(state.Id, state);
        }

        public IItemState GetState(int stateId) {
            States.TryGetValue(stateId, out var state);
            return state;
        }

        public T GetState<T>(int stateId) where T : IItemState {
            var state = GetState(stateId);
            if (state is T typedState) {
                return typedState;
            }

            return default;
        }

        public void RemoveState(int stateId) {
            if (States.ContainsKey(stateId)) {
                States.Remove(stateId);
            }
        }

        public void ClearStates() {
            States.Clear();
        }
    }
}