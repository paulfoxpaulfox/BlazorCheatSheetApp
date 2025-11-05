using Microsoft.AspNetCore.Components;

namespace BlazorCheatSheet.Components
{
    public partial class Child
    {
        private bool _ImAGoodChild = true;

        [Parameter]
        public EventCallback OnChildButtonClick { get; set; }

        private async Task HandleChildClick()
        {
            _ImAGoodChild = !_ImAGoodChild;

            await OnChildButtonClick.InvokeAsync();
        }
    }
}
