using System.ComponentModel.DataAnnotations;

namespace StuMS.Models
{
    public class Course
    {

        public int Id { get; set; }
        [Required]
        [Display(Name="Course Name")]
        public string Name { get; set;}
        public List<Grade> Grades { get; set; }
        public Teacher Teacher { get; set; }
    }
}
