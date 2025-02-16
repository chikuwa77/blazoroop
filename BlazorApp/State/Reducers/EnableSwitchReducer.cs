using BlazorApp.State.Actions;
using Fluxor;

namespace BlazorApp.State.Reducers
{

    public class EnableSwitchReducer
    {
        [ReducerMethod]
        public static EnableSwitchState ReduceEnableSwitchAction
            (EnableSwitchState state, EnableSwitchAction action) => 
            new EnableSwitchState(pEnableSwitch: action.EnableSwitch);
    }

}
