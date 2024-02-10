using SchoolProject.Core.Features.Students.Queries.DTOs;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.StudentsMapping
{
    public partial class StudentProfilePartial
    {
        public void GetStudentByIdMapping()
        {
            CreateMap<Student, GetStudentByIdDto>()
                .ForMember(stdListDto => stdListDto.DepartmentName,
                src => src.MapFrom(std => std.Department.DName)); // to get department name instead of department id.

        }
    }
}
