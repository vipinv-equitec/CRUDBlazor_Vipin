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
        private string? studList;
        protected override async Task OnInitializedAsync()
        {
            Student = await StudentService.GetStudentByyIdAsync(StudentId);
            selectedSkills = await StudentService.GetSkills(StudentId);
            foreach (var skillid in selectedSkills)
            {
                skills.Add(skillid.SkillName);
            }
            foreach (var skill in skills)
            {
                studList = studList + "," + skill;
            }
        }
        private async Task BackToList()
        {
            NavigationManager.NavigateTo("/studentdata");
        }
    }
}
