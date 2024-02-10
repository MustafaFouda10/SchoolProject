using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.AppDBContext;
using SchoolProject.Infrastructure.Repos.IRepositories;
using SchoolProject.Service.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Service.Services
{
    public class StudentService : IStudentService
    {
        #region Fields
        private readonly IStudentRepository _studentRepository;

        #endregion

        #region Constructors
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        #endregion

        #region Methods
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _studentRepository.GetStudentsListAsync();
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            //return await _studentRepository.GetByIdAsync(id);
            return await _studentRepository.GetTableAsNoTracking()
                                           .Include(s => s.Department)
                                           .Where(s => s.StudentId.Equals(id))
                                           .FirstOrDefaultAsync();
        }

        #endregion
    }
}
