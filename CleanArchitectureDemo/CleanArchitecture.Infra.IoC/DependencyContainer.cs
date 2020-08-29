using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.CommandHandlers;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infra.Bus;
using CleanArchitecture.Infra.Data.Context;
using CleanArchitecture.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CreateCourseCommandHandler>();

            services.AddScoped<ICourseService, CourseService>();

            services.AddScoped<ICourseRepository, CourseRepository>();

            services.AddScoped<UniversityDbContext>();
        }
    }
}