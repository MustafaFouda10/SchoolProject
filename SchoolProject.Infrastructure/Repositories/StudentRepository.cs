using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.AppDBContext;
using SchoolProject.Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        #region Fields
        private readonly ApplicationDBContext _dbContext;

        #endregion

        #region Constructors
        public StudentRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion

        #region Methods
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _dbContext.Students.ToListAsync();
        }

        #endregion




    }
}
