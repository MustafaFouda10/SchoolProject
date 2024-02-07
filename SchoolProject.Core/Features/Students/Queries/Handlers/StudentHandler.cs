using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Queries.DTOs;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Data.Entities;
using SchoolProject.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler :ResponseHandler, IRequestHandler<GetStudentsListQuery, Response<List<GetStudentsListDto>>>
    {
        // Controller -> Mediator(IRequest<TResponse> -> IRequestHandler<TRequest,TResponse>) -> Service -> Repository -> DBContext -> DB

        #region Fields
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        #endregion

        #region Constructors
        public StudentHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        #endregion

        #region Methods
        public async Task<Response<List<GetStudentsListDto>>> Handle(GetStudentsListQuery request, CancellationToken cancellationToken)
        {
            var studentsList = await _studentService.GetStudentsListAsync();
            var studentsListMapper =  _mapper.Map<List<GetStudentsListDto>>(studentsList);
            return Success(studentsListMapper); // Success<T> --> will receive the response from service and turn it into a Reponse<T>
        }
        #endregion

    }
}
