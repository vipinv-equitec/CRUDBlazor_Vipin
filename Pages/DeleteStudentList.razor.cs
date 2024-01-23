using BlazorApp.Models;
namespace BlazorApp.Pages
{
    public partial class DeleteStudentList
    {
        private List<BlazorApp.Models.StudentViewAllResult>? Studlists;
        List<GetAllSkillsStudentResult> skills = new List<GetAllSkillsStudentResult>();
        public Dictionary<int, string> studentSkillPairs = new Dictionary<int, string>();
        protected override async Task OnInitializedAsync()
        {
            Studlists = await StudentService.GetStudentData();
            foreach (var student in Studlists)
            {
                var skills = await StudentService.Skills(student.StudentId);
                student.Skills = string.Join(", ", skills.Select(skill => skill.Skillname));
            }
        }
        public async Task Delete(int studentId)
        {
            NavigationManager.NavigateTo($"/detailStudentList/{studentId}");
        }
    }
}
