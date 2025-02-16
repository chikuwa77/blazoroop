using BlazorApp.State.Actions;
using Fluxor;

namespace BlazorApp.State.Reducers
{

    public class PriorityReducer
    {
        [ReducerMethod]
        public static PriorityState ReducePriorityAction
            (PriorityState state, PriorityAction action) => 
            new PriorityState(pPriority: action.Priority);
    }

}
