using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Queries.DTOs;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetStudentsListQuery : IRequest<Response<List<GetStudentsListDto>>> //Response<T> --> is found in Respond.cs class
    {
        //IRequest --> Receives the request ,which its response is [List<Student>], from controller and redirects it to IRequestHandler.
    }
}
