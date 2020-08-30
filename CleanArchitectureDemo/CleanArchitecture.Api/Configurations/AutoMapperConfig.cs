﻿using AutoMapper;
using CleanArchitecture.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Api.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}