using BlazorApp.Models;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations.Schema;
namespace BlazorApp.Pages
{
    public partial class Student
    {
        private List<BlazorApp.Models.StudentViewAllResult>? Studlists;
        List<GetAllSkillsStudentResult> skills = new List<GetAllSkillsStudentResult>();
        public Dictionary<int, string> studentSkillPairs = new Dictionary<int, string>();
        protected override async Task OnInitializedAsync()
        {
            /*Studlists = await StudentService.GetStudentData();
            foreach (var student in Studlists)
            {
                skills = await StudentService.Skills(student.StudentId);
                var studentSkills = skills.Select(skill => skill.Skillname);
                studentSkillPairs[student.StudentId] = string.Join(", ", studentSkills);
            }*/
            Studlists = await StudentService.GetStudentData();

            foreach (var student in Studlists)
            {
                var skills = await StudentService.Skills(student.StudentId);
                student.Skills = string.Join(", ", skills.Select(skill => skill.Skillname));
            }
        }
        public void NavigateToAddStudent()
        {
            NavigationManager.NavigateTo("/addStudent");
        }
        public void OnEditClicked(int id)
        {
            NavigationManager.NavigateTo($"/editStudent/{id}");
        }
        public void OnDetailsClicked(int id)
        {
            NavigationManager.NavigateTo($"/detailstudent/{id}");
        }
        public async Task OnDeleteClicked(int id)
        {
            await StudentService.DeleteStudentAsync(id);
            NavigationManager.NavigateTo(NavigationManager.Uri, forceLoad: true);
        }
        public void NavigateToDeletedStudent()
        {
            NavigationManager.NavigateTo("/deletedstudents");
        }
    }
}
