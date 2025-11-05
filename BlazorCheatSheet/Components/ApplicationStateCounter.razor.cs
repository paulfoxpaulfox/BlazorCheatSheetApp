using BlazorCheatSheet.State;
using Microsoft.AspNetCore.Components;

namespace BlazorCheatSheet.Components
{
    public partial class ApplicationStateCounter
    {
        [Inject]
        public ApplicationState ApplicationState { get; set; } 

        private int ApplicationStateCount;

        protected override void OnInitialized()
        {
            ApplicationStateCount = new Random().Next(0, 100);

            ApplicationState.CounterValue = ApplicationStateCount;  
        }
    }
}
