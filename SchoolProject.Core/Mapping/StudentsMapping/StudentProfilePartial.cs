using AutoMapper;
using SchoolProject.Core.Features.Students.Queries.DTOs;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.StudentsMapping
{
    public partial class StudentProfilePartial : Profile
    {
        public StudentProfilePartial()
        {
            GetStudentsListMapping();
        }
    }
}
