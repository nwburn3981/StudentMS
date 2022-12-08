using System.ComponentModel.DataAnnotations;

namespace StuMSAPI.Models.Dto
{
    public class TeacherDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<CourseDto> Courses { get; set; }
        
    }
}
