using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    public static class ServiceTool
    {
        /// <summary>
        /// .NET Servislerini build eder. 
        /// Injection yapmak için kullanılır.
        /// 
        /// </summary>
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services) 
        {
            ServiceProvider = services.BuildServiceProvider(); 
            return services;
        }
    }
}
