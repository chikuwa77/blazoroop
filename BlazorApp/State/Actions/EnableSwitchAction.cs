namespace BlazorApp.State.Actions
{

    public class EnableSwitchAction
    {
        public bool EnableSwitch { get; private set; }

        public EnableSwitchAction(bool pEnableSwitch)
        {
            EnableSwitch = pEnableSwitch;
        }

    }


}
