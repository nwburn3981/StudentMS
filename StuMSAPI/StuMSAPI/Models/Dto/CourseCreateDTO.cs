using System.ComponentModel.DataAnnotations;

namespace CapstoneAPI.Models.Dto
{
    public class CourseCreateDTO
    {
        [Required]
        [Display(Name = "Course Name")]
        public string Name { get; set; }
        public TeacherDto Teacher { get; set; }
        public virtual ICollection<StudentDto> Students { get; set; }
        public virtual ICollection<GradeDto> Grades { get; set; }
    }
}
