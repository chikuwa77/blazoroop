using Fluxor;

namespace BlazorApp.State.Features
{
    [FeatureState]
    public class TermFeature : Feature<TermState>
    {

        public override string GetName() => "Term";
        protected override TermState GetInitialState() => 
            new TermState(pTerm: DateTime.Now);
        
    }

}
