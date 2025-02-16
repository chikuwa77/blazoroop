using BlazorApp.State.Actions;
using Fluxor;

namespace BlazorApp.State.Reducers
{

    public class MemoReducer
    {
        [ReducerMethod]
        public static MemoState ReduceMemoAction
            (MemoState state, MemoAction action) => 
            new MemoState(pMemo: action.Memo);
    }

}
