#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Add this namespace
namespace BlazorApp.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Student name is required")]
        public string StudName { get; set; }
        [Range(1, 99, ErrorMessage = "Please enter a valid age between 1 and 99")]
        public int? StudAge { get; set; }
        [Required(ErrorMessage = "Student email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string StudEmail { get; set; }
        [Required(ErrorMessage = "Student department is required")]
        public string StudDepartment { get; set; }
        [StringLength(255, ErrorMessage = "Skills should be less than 255 characters")]
        public string Skills { get; set; }
        public bool? IsActive { get; set; }
        public virtual ICollection<Skill> SkillsNavigation { get; set; } = new List<Skill>();
    }
}
