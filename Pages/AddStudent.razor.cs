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
            allSkills = await StudentService.GetAllSkills(); // Fetch all skills from the service
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
            // Set the selected skills for the new student
            newStudent.SkillsNavigation = allSkills.Where(skill => selectedSkills.Contains(skill.SkillId)).ToList();
            await StudentService.AddStudentAsync(newStudent, selectedSkills);

            NavigationManager.NavigateTo("/studentdata");
        }
        private async Task BackToList()
        {
            NavigationManager.NavigateTo("/studentdata");
        }
    }
}
