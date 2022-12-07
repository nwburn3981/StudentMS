using StuMSAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace StuMSAPI.Models
{
    public class Teacher
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
