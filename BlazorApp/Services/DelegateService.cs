namespace BlazorApp.Services
{
    public class DelegateService : IDelegateService
    {
        private Action? _updView;
        private Action? _chkView;
        private Action? _clrView;

        public void AddUpd(Action listener)
        {
            _updView += listener;
        }

        public void AddChk(Action listener)
        {
            _chkView += listener;
        }

        public void AddClr(Action listener)
        {
            _clrView += listener;
        }

        public void BroadCastUpd()
        {
            _updView!.Invoke();
        }

        public void BroadCastChk()
        {
            _chkView!.Invoke();
            _updView!.Invoke();
        }

        public void BroadCastClr()
        {
            _clrView!.Invoke();
            _updView!.Invoke();
        }


        public void RemoveUpd(Action listener)
        {
            _updView -= listener;
        }


        public void RemoveChk(Action listener)
        {
            _chkView -= listener;
        }

        public void RemoveClr(Action listener)
        {
            _clrView -= listener;
        }

    }
}
