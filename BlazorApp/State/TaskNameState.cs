namespace BlazorApp.State
{
    public class TaskNameState
    {
        public string TaskName { get; private set; }
        public TaskNameState(string pTaskName)
        {
            TaskName = pTaskName;
        }

    }

}
