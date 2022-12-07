using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace StuMSAPI.Models
{
    public class Student
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        public DateOnly Dob { get; set; }
        public String Email { get; set; }
        public List<Grade> Grades { get; set; }
    }
}
