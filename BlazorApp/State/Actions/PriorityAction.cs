namespace BlazorApp.State.Actions
{

    public class PriorityAction
    {
        public byte Priority { get; private set; }

        public PriorityAction(byte pPriority)
        {
            Priority = pPriority;
        }

    }


}
