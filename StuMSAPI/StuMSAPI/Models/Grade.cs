using StuMSAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace StuMSAPI.Models
{
    public class Grade
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Grade")]
        public string LetterGrade { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
