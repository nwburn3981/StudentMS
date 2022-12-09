using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StuMS.Models.Dto
{
    public class GradeCreateDTO
    {
        [Required]
        [Display(Name = "Grade")]
        public string LetterGrade { get; set; }

        public StudentDto Student { get; set; }
        public CourseDto Course { get; set; }
    }
}
