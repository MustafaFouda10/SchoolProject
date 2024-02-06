using MediatR;
using SchoolProject.Core.Features.Students.Queries.DTOs;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetStudentsListQuery : IRequest<List<GetStudentsListDto>> 
    {
        //IRequest --> Receives the request ,which its response is [List<Student>], from controller and redirects it to IRequestHandler.
    }
}
