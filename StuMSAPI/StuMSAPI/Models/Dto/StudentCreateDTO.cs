using System.ComponentModel.DataAnnotations;

namespace CapstoneAPI.Models.Dto
{
    public class StudentCreateDTO
    {
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
