namespace BlazorApp.State
{

    public class EnableSwitchState
    {
        public bool EnableSwitch { get; private set; }

        public EnableSwitchState(bool pEnableSwitch)
        {
            EnableSwitch = pEnableSwitch;
        }

    }

}
