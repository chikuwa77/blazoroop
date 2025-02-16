using Fluxor;

namespace BlazorApp.State.Features
{
    [FeatureState]
    public class TaskFeature : Feature<TaskNameState>
    {

        public override string GetName() => "TaskName";
        protected override TaskNameState GetInitialState() =>
            new TaskNameState(pTaskName: string.Empty);

    }

}
