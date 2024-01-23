using BlazorApp.Models;
using Microsoft.AspNetCore.Components;
namespace BlazorApp.Pages
{
    public partial class EditStudent
    {
        [Parameter]
        public int id { get; set; }
        private BlazorApp.Models.Student? editedStudent;
        private List<Skill> allSkills = new List<Skill>();
        private List<int> selectedSkills = new List<int>();
        private List<Skill> userSkills = new List<Skill>();
        protected override async Task OnInitializedAsync()
        {
                editedStudent = await StudentService.GetStudentByIdAsync(id);
                allSkills = await StudentService.GetAllSkills();
                userSkills = await StudentService.GetSkills(id);
                foreach(var userskill in userSkills)
                {
                    selectedSkills.Add(userskill.SkillId);
                }
        }
        private void ToggleSkill(int skillId)
        {
            if (selectedSkills.Contains(skillId))
                selectedSkills.Remove(skillId);
            else
                selectedSkills.Add(skillId);
        }
        private async Task UpdateStudent()
        {
            if (editedStudent != null)
            {
                await StudentService.EditStudentAsync(editedStudent);
                await StudentService.DeleteStudentSkills(id);
                foreach (var skill in selectedSkills)
                {
                    await StudentService.GetStudentsId(id, skill);
                }
            }
            NavigationManager.NavigateTo("/studentdata");
        }
        private async Task BackToList()
        {
            NavigationManager.NavigateTo("/editStudentList");
        }
    }
}
