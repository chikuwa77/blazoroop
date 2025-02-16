using BlazorApp.Models;
using BlazorApp.Services;
using BlazorApp.State;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Components.Pages
{
    public partial class ToDoList:IBase, IDisposable
    {
        [Inject]
        IDispatcher Dispatcher { get; set; } = null!;

        [Inject]
        IState<TaskNameState> TaskNameState { get; set; } = null!;

        [Inject]
        IState<MemoState> MemoState { get; set; } = null!;

        [Inject]
        IState<PriorityState> PriorityState { get; set; } = null!;

        [Inject]
        IState<EnableSwitchState> EnableSwitchState { get; set; } = null!;

        [Inject]
        IState<TermState> TermState { get; set; } = null!;

        [Inject]
        IDelegateService DelegateService { get; set; } = null!;

        List<ToDoListModel> ToDoLists = new List<ToDoListModel>();

        protected override Task OnInitializedAsync()
        {

            DelegateService.AddUpd(UpdateView);
            DelegateService.AddChk(CheckView);
            DelegateService.AddClr(ClearView);

            return base.OnInitializedAsync();
        }


        public void UpdateView()
        {
            StateHasChanged();
        }

        public void ClearView()
        {
            ToDoLists.Clear();
        }

        public void CheckView()
        {
        }
        private void PushAdd()
        {
            DelegateService.BroadCastChk();


            ToDoListModel p = new()
            {
                TaskName = TaskNameState.Value.TaskName,
                Memo = MemoState.Value.Memo,
                Priority = PriorityState.Value.Priority,
                Term = TermState.Value.Term
            };

            ToDoLists?.Add(p);

        }
        private void PushClr()
        {
            DelegateService.BroadCastClr();
        }

        public void Dispose()
        {
            DelegateService.RemoveUpd(UpdateView);
            DelegateService.RemoveChk(CheckView);
            DelegateService.RemoveClr(ClearView);
        }
    }
}

