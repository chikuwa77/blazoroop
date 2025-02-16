using BlazorApp.Models;
using BlazorApp.Services;
using BlazorApp.State;
using BlazorApp.State.Actions;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Components.Shared
{
    public partial class Priority : IBase, IDisposable
    {

        [Inject]
        IDispatcher Dispacher { get; set; } = null!;

        [Inject]
        IDelegateService DelegateService { get; set; } = null!;

        [Inject]
        IState<PriorityState> PriorityState { get; set; } = null!;

        [Inject]
        IState<EnableSwitchState> EnableSwitchState { get; set; } = null!;

        string ErrMsg { get; set; } = null!;

        List<SelectOptionModel> PriorityLists = new List<SelectOptionModel>
        {
            new SelectOptionModel{
                Id = 0,
                Name = "",
            },
            new SelectOptionModel{
                Id = 10,
                Name = "10",
            },
            new SelectOptionModel{
                Id = 20,
                Name = "20",
            },
            new SelectOptionModel{
                Id = 30,
                Name = "30",
            },
            new SelectOptionModel{
                Id = 99,
                Name = "99",
            }
        };

        protected override Task OnInitializedAsync()
        {

            DelegateService.AddUpd(UpdateView);
            DelegateService.AddChk(CheckView);
            DelegateService.AddClr(ClearView);

            return base.OnInitializedAsync();
        }

        private void Input(ChangeEventArgs inputArgs)
        {
            Dispacher.Dispatch(new PriorityAction(Convert.ToByte(inputArgs.Value!.ToString()!)));

            DelegateService.BroadCastUpd();
        }

        public void UpdateView()
        {
            StateHasChanged();
        }

        public void ClearView()
        {
            Dispacher.Dispatch(new PriorityAction(0));
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
