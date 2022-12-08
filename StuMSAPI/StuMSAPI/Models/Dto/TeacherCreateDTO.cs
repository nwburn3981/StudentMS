using System.ComponentModel.DataAnnotations;

namespace StuMSAPI.Models.Dto
{
    public class TeacherCreateDTO
    {
      
        [Required]
        public string Name { get; set; }

        public virtual ICollection<CourseDto> Courses { get; set; }
    }
}
