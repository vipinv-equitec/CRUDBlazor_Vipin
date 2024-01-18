using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;
namespace BlazorApp.Data
{
    public class StudentService
    {
        private readonly StudentContext _dbContext;
        public StudentService(StudentContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<StudentViewAllResult>> GetStudentData()
        {
            List<StudentViewAllResult> students = await _dbContext.Procedures.StudentViewAllAsync();
            return students;
        }
        public async Task AddStudentAsync(Student newStudent, List<int> selectedSkills)
        {
            await _dbContext.Procedures.StudentEditAsync(newStudent.StudentId, newStudent.StudName, newStudent.StudAge, newStudent.StudEmail, newStudent.StudDepartment, newStudent.Skills);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<Student?> GetStudentByIdAsync(int studentId)
        {
            Student? student = _dbContext.Students.Where(x => x.StudentId == studentId).FirstOrDefault();
            if (student == null)
            {
                return null;
            }
            return student;
        }
        public async Task EditStudentAsync(Student editedStudent)
        {
            await _dbContext.Procedures.StudentEditAsync(editedStudent.StudentId, editedStudent.StudName, editedStudent.StudAge, editedStudent.StudEmail, editedStudent.StudDepartment, editedStudent.Skills);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<StudentViewByIdResult?> GetStudentByyIdAsync(int studentId)
        {
            StudentViewByIdResult? student = await _dbContext.Procedures.StudentViewByIdAsync(studentId);
            return student;
        }
        public async Task DeleteStudentAsync(int id)
        {
            await _dbContext.Procedures.DeleteSoftAsync(id);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<RestoreStudentResult>> GetDeletedStudents()
        {
            List<RestoreStudentResult> deletedStudents = await _dbContext.Procedures.RestoreStudentAsync();
            return deletedStudents;
        }

        public async Task RestoreStudentAsync(int studentId)
        {
            await _dbContext.Procedures.BackStudentAsync(studentId);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<GetAllSkillsStudentResult>> Skills(int studentId)
        {
            return await _dbContext.Procedures.GetAllSkillsStudentAsync(studentId);
        }
        public async Task<List<Skill>> GetAllSkills()
        {
            return await _dbContext.Skills.ToListAsync();
        }
    }
}
