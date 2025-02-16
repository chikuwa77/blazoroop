namespace BlazorApp.State.Actions
{

    public class TermAction
    {
        public DateTime Term { get; private set; }

        public TermAction(DateTime pTerm)
        {
            Term = pTerm;
        }

    }


}
