using Catalog.Repositories;
using Catalog.Repositories.Abstractions.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Services.IoC
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabases(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CatalogContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CatalogDb"));
            });

            services.AddTransient<IRepositoryPropertyGroup, RepositoryPropertyGroup>();

            return services;
        }
    }
}
