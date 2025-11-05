namespace BlazorCheatSheet.Components
{
    public partial class Parent
    {
        private bool _ImAGoodParent = true;
        private async Task ParentButtonHandlerExecuted()
        {
            _ImAGoodParent = !_ImAGoodParent;
        }
    }
}
