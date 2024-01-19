using BlazorApp.Models;
namespace BlazorApp.Pages
{
    public partial class AddStudent
    {
        private BlazorApp.Models.Student newStudent = new BlazorApp.Models.Student();
        private List<Skill> allSkills = new List<Skill>();
        private List<int> selectedSkills = new List<int>();
        protected override async Task OnInitializedAsync()
        {
            allSkills = await StudentService.GetAllSkills();
        }
        private void ToggleSkill(int skillId)
        {
            if (selectedSkills.Contains(skillId))
                selectedSkills.Remove(skillId);
            else
                selectedSkills.Add(skillId);
        }
        private async Task AddStud()
        {
            await StudentService.AddStudentAsync(newStudent);
            int id = await StudentService.GetStudentId(newStudent.StudEmail);
            foreach (var skill in selectedSkills)
            {
                await StudentService.GetStudentsId(id, skill);
            }
            NavigationManager.NavigateTo("/studentdata");
        }
        private async Task BackToList()
        {
            NavigationManager.NavigateTo("/studentdata");
        }
    }
}
