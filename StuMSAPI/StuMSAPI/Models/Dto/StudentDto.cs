using System.ComponentModel.DataAnnotations;

namespace StuMSAPI.Models.Dto
{
    public class StudentDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(55)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime dateOfBirth { get; set; }
        public virtual ICollection<CourseDto> Courses { get; set; }
        public virtual ICollection<GradeDto> Grades { get; set; }

    }
}
