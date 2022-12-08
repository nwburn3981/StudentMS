using StuMSAPI.Controllers;
using System.ComponentModel.DataAnnotations;

namespace StuMSAPI.Models.Dto
{
    public class CourseDto
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Course Name")]
        public string Name { get; set; }
        public TeacherDto Teacher { get; set; }

        public virtual ICollection<StudentDto> Students { get; set; }
        public virtual ICollection<GradeDto> Grades { get; set; }
    }
}

