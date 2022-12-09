using System.ComponentModel.DataAnnotations;

namespace StuMSAPI.Models.Dto
{
    public class GradeDto
    {

        public int Id { get; set; }
        [Required]
        [Display(Name="Grade")]
        public string LetterGrade { get; set; }

        public StudentDto Student { get; set; }
        public CourseDto Course { get; set; }
    }
}
