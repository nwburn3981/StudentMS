using System.ComponentModel.DataAnnotations;

namespace StuMS.Models.Dto
{
    public class CourseDto
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Course Name")]
        public string Name { get; set; }

        //public virtual ICollection<StudentDto> Students { get; set; }
        //public virtual ICollection<GradeDto> Grades { get; set; }
    }
}

