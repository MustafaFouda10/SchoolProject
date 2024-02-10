using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Queries.DTOs;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentQueryHandler : ResponseHandler
                                      ,IRequestHandler<GetStudentsListQuery, Response<List<GetStudentsListDto>>>
                                      ,IRequestHandler<GetStudentByIdQuery, Response<GetStudentByIdDto>>
    {
        // Controller -> Mediator(IRequest<TResponse> -> IRequestHandler<TRequest,TResponse>) -> Service -> Repository -> DBContext -> DB

        #region Fields
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        #endregion

        #region Constructors
        public StudentQueryHandler(IStudentService studentService, IMapper mapper)
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

        public async Task<Response<GetStudentByIdDto>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentByIdAsync(request.Id);
            if(student == null)
                return NotFound<GetStudentByIdDto>();

            var studentMapper = _mapper.Map<GetStudentByIdDto>(student);
            return Success(studentMapper);
        }
        #endregion

    }
}
