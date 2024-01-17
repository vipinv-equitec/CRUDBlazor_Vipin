namespace BlazorApp.Pages
{
    public partial class DeletedStudent
    {
        private List<BlazorApp.Models.RestoreStudentResult>? DeletedStudents;

        protected override async Task OnInitializedAsync()
        {
            DeletedStudents = await StudentService.GetDeletedStudents();
        }

        private async Task OnRestoreClicked(int id)
        {
            await StudentService.RestoreStudentAsync(id);
            NavigationManager.NavigateTo(NavigationManager.Uri, forceLoad: true);
        }
        private async Task BackToList()
        {
            NavigationManager.NavigateTo("/studentdata");
        }
    }
}
