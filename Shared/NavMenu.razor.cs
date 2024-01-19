namespace BlazorApp.Shared
{
    public partial class NavMenu
    {
        private string listDisplay => showList ? "block" : "none";
        private bool showList = false;
        private void ToggleDropdown()
        {
            showList = !showList;
        }
    }
   
}
