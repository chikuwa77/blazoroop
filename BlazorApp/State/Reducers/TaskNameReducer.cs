using BlazorApp.State.Actions;
using Fluxor;

namespace BlazorApp.State.Reducers
{

    public class TaskNameReducer
    {
        [ReducerMethod]
        public static TaskNameState ReduceTaskAction
            (TaskNameState state, TaskNameAction action) => 
            new TaskNameState(pTaskName: action.TaskName);
    }

}
