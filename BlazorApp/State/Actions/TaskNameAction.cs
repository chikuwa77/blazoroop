namespace BlazorApp.State.Actions
{
    public class TaskNameAction
    {
        public string TaskName { get; private set; }

        public TaskNameAction(string pTaskName)
        {
            TaskName = pTaskName;
        }
    }
}
