using AutoMapper;
using StuMS.Models;
using StuMS.Models.Dto;

namespace StuMS
{
    public class MappingConfig: Profile
    {
        public MappingConfig()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<StudentDto, Student>();

            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Student, StudentDto>().ReverseMap();

            CreateMap<Teacher, TeacherDto>();
            CreateMap<TeacherDto, Teacher>();

            CreateMap<Teacher, TeacherDto>().ReverseMap();
            CreateMap<Teacher, TeacherDto>().ReverseMap();

            CreateMap<Course, CourseDto>();
            CreateMap<CourseDto, Course>();

            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Course, CourseDto>().ReverseMap();

            CreateMap<Grade, GradeDto>();
            CreateMap<GradeDto, Grade>();

            CreateMap<Grade, GradeDto>().ReverseMap();
            CreateMap<Grade, GradeDto>().ReverseMap();
        }
    }
}
