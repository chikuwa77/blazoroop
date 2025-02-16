
namespace BlazorApp.Services
{
    public interface IDelegateService
    {
        void AddChk(Action listener);
        void AddClr(Action listener);
        void AddUpd(Action listener);
        void BroadCastChk();
        void BroadCastClr();
        void BroadCastUpd();
        void RemoveChk(Action listener);
        void RemoveClr(Action listener);
        void RemoveUpd(Action listener);
    }
}