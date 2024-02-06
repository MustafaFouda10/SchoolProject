using AutoMapper;
using MediatR;
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
    public class StudentHandler : IRequestHandler<GetStudentsListQuery, List<GetStudentsListDto>>
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
        public async Task<List<GetStudentsListDto>> Handle(GetStudentsListQuery request, CancellationToken cancellationToken)
        {
            var studentsList = await _studentService.GetStudentsListAsync();
            var studentsListMapper =  _mapper.Map<List<GetStudentsListDto>>(studentsList);
            return studentsListMapper;

        }
        #endregion

    }
}
