namespace BlazorApp.Pages
{
    public partial class RestoreStudentList
    {
        private List<BlazorApp.Models.RestoreStudentResult>? DeletedStudents;
        protected override async Task OnInitializedAsync()
        {
            DeletedStudents = await StudentService.GetDeletedStudents();
            foreach (var student in DeletedStudents)
            {
                var skills = await StudentService.Skills(student.StudentId);
                student.Skills = string.Join(", ", skills.Select(skill => skill.Skillname));
            }
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
