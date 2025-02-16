namespace BlazorApp.State
{

    public class PriorityState
    {
        public byte Priority { get; private set; }

        public PriorityState(byte pPriority)
        {
            Priority = pPriority;
        }

    }

}
