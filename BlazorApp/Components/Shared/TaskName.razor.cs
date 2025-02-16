using BlazorApp.Services;
using BlazorApp.State;
using BlazorApp.State.Actions;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Components.Shared
{
    public partial class TaskName : IBase, IDisposable
    {

        [Inject]
        IDispatcher Dispacher { get; set; } = null!;

        [Inject]
        IDelegateService DelegateService { get; set; } = null!;

        [Inject]
        IState<TaskNameState> TaskNameState { get; set; } = null!;

        [Inject]
        IState<EnableSwitchState> EnableSwitchState { get; set; } = null!;

        string ErrMsg { get; set; } = null!;

        protected override Task OnInitializedAsync()
        {

            DelegateService.AddUpd(UpdateView);
            DelegateService.AddChk(CheckView);
            DelegateService.AddClr(ClearView);

            return base.OnInitializedAsync();
        }

        private void Input(ChangeEventArgs inputArgs)
        {
            Dispacher.Dispatch(new TaskNameAction(inputArgs.Value!.ToString()!));

            DelegateService.BroadCastUpd();
        }

        public void UpdateView()
        {
            StateHasChanged();
        }

        public void ClearView()
        {
            Dispacher.Dispatch(new TaskNameAction(string.Empty));
            ErrMsg = string.Empty;
        }

        public void CheckView()
        {

        }

        public void Dispose()
        {
            DelegateService.RemoveUpd(UpdateView);
            DelegateService.RemoveChk(CheckView);
            DelegateService.RemoveClr(ClearView);
        }

    }
}
