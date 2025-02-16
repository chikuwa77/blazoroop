using Fluxor;

namespace BlazorApp.State.Features
{
    [FeatureState]
    public class PriorityFeature : Feature<PriorityState>
    {

        public override string GetName() => "Priority";
        protected override PriorityState GetInitialState() => 
            new PriorityState(pPriority: 0);
        
    }

}
