using BlazorCheatSheet.State;
using Microsoft.AspNetCore.Components;

namespace BlazorCheatSheet.Components
{
    public partial class ApplicationStateCounterReader
    {
        [Inject]
        public ApplicationState ApplicationState { get; set; } 

        private int ApplicationStateCount;
        protected override void OnInitialized()
        {
            ApplicationStateCount = ApplicationState.CounterValue;
        }
    }
}
