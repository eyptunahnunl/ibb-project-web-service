using Autofac.Core;

using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection servisCollection)
        {
            servisCollection.AddMemoryCache();
            servisCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //servisCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            servisCollection.AddSingleton<Stopwatch>();
        }
    }
}
