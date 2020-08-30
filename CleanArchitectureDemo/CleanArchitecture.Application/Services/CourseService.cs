using System.Collections.Generic;
using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly IMediatorHandler _bus;
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;


        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _mapper = mapper;
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _mapper.Map<IEnumerable<CourseViewModel>>(_courseRepository.GetCourses());
        }

        public void CreateCourse(CourseViewModel course)
        {
            _bus.SendCommand(_mapper.Map<CreateCourseCommand>(course));
        }
    }
}