namespace BlazorApp.State
{

    public class MemoState
    {
        public string Memo { get; private set; }

        public MemoState(string pMemo)
        {
            Memo = pMemo;
        }

    }

}
