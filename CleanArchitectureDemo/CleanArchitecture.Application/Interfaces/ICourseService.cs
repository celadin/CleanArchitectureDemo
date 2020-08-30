using System.Collections.Generic;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
        void CreateCourse(CourseViewModel createCourseViewModel);
    }
}