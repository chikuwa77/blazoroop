using Fluxor;

namespace BlazorApp.State.Features
{
    [FeatureState]
    public class MemoFeature : Feature<MemoState>
    {

        public override string GetName() => "Memo";
        protected override MemoState GetInitialState() => 
            new MemoState(pMemo: string.Empty);
        
    }

}
