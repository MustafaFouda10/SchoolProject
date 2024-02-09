using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.AppDBContext;
using SchoolProject.Infrastructure.Generic;
using SchoolProject.Infrastructure.Repos.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure.Repos.Repositories
{
    public class StudentRepository : GenericRepositoryAsync<Student> , IStudentRepository
    {
        #region Fields
        //private readonly ApplicationDBContext _dbContext;
        private readonly DbSet<Student> _students;

        #endregion

        #region Constructors
        public StudentRepository(ApplicationDBContext dbContext) : base(dbContext) 
        {
            _students = dbContext.Set<Student>();
        }

        #endregion

        #region Methods
        public async Task<List<Student>> GetStudentsListAsync()
        {
            //return await _dbContext.Students.Include(s => s.Department).ToListAsync();
            return await _students.Include(s => s.Department).ToListAsync();
        }

        #endregion




    }
}
