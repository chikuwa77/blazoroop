namespace BlazorApp.State.Actions
{

    public class MemoAction
    {
        public string Memo { get; private set; }

        public MemoAction(string pMemo)
        {
            Memo = pMemo;
        }

    }


}
