using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Data.AppRouting;

namespace SchoolProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        #region Fields
        private readonly IMediator _mediator;
        #endregion

        #region Constructors
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region Methods
        [HttpGet(Router.StudentRouting.GetStudentsList)]
        public async Task<IActionResult> GetStudentsList()
        {
            // Request will come from controller to [public class GetStudentsListQuery : IRequest<List<Student>>], then request will be handled by  [public class StudentHandler : IRequestHandler<GetStudentsListQuery, List<Student>>]
            var response = await _mediator.Send(new GetStudentsListQuery()); 
            return Ok(response);
        }

        [HttpGet(Router.StudentRouting.GetStudentById)]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var response = await _mediator.Send(new GetStudentByIdQuery(id));
            return Ok(response);
        }
        #endregion


    }
}
