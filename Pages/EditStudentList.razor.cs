using BlazorApp.Models;
namespace BlazorApp.Pages
{
    public partial class EditStudentList
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
        public void OnEditClicked(int id)
        {
            NavigationManager.NavigateTo($"/editStudent/{id}");
        }
    }
}
