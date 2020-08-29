using System.Collections.Generic;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;

namespace CleanArchitecture.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _dbContext;

        public CourseRepository(UniversityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _dbContext.Courses;
        }
    }
}