using System.ComponentModel.DataAnnotations;

namespace CapstoneAPI.Models.Dto
{
    public class TeacherUpdateDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<CourseDto> Courses { get; set; }
    }
}
