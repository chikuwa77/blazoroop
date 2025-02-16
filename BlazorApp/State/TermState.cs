namespace BlazorApp.State
{

    public class TermState
    {
        public DateTime Term { get; private set; }

        public TermState(DateTime pTerm)
        {
            Term = pTerm;
        }

    }

}
