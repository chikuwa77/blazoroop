using BlazorApp.State.Actions;
using Fluxor;

namespace BlazorApp.State.Reducers
{

    public class TermReducer
    {
        [ReducerMethod]
        public static TermState ReduceTermAction
            (TermState state, TermAction action) => 
            new TermState(pTerm: action.Term);
    }

}
