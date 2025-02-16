using Fluxor;

namespace BlazorApp.State.Features
{
    [FeatureState]
    public class EnableSwitchFeature : Feature<EnableSwitchState>
    {

        public override string GetName() => "EnableSwitch";
        protected override EnableSwitchState GetInitialState() => 
            new EnableSwitchState(pEnableSwitch: false);
        
    }

}
