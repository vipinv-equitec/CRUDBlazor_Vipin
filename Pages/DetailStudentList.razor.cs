using BlazorApp.Models;
using Microsoft.AspNetCore.Components;
namespace BlazorApp.Pages
{
    public partial class DetailStudentList
    {
        [Parameter] public int StudentId { get; set; }
        private StudentViewByIdResult? Student { get; set; }
        private List<Skill> selectedSkills = new List<Skill>();
        private List<string> skills = new List<string>();
        private List<Skill> allSkills = new List<Skill>();
        private List<int> skillsId = new List<int>();
       // private string? studList;
        protected override async Task OnInitializedAsync()
        {
            Student = await StudentService.GetStudentByyIdAsync(StudentId);
            selectedSkills = await StudentService.GetSkills(StudentId);
            allSkills = await StudentService.GetAllSkills();
            foreach (var skillid in selectedSkills)
            {
                skills.Add(skillid.SkillName);
            }
       /*     foreach(var skill in skills)
            {
                studList =  skill + "," + studList;
            }
            if (studList != null)
            {
                studList = studList.Substring(0, studList.Length - 1);
            }
            else
            {
                studList = "no skills";
            }*/
            foreach(var skill in selectedSkills)
            {
                skillsId.Add(skill.SkillId);
            }
        }
        public async Task OnDeleteClicked(int id)
        {
            await StudentService.DeleteStudentAsync(id);
            NavigationManager.NavigateTo("/studentdata");
        }
        private async Task BackToList()
        {
            NavigationManager.NavigateTo("/studentdata");
        }
    }
}
