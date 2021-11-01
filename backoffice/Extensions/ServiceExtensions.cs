using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NewSchool.Backoffice.Handlers;
using NewSchool.Backoffice.Infra.Data.Context;
using NewSchool.Backoffice.Infra.Data.Repositories;
using NewSchool.Backoffice.Repositories;

namespace backoffice.Extensions
{
    public static class ServiceExtensions
    {
        #region Services

        /// <summary>
        /// The register service.
        /// </summary>
        /// <param name="services"></param>
        public static void AddContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<DataContext, DataContext>(provider => new DataContext(configuration["ConnectionString:Connection"]));
        }

        /// <summary>
        /// The register service.
        /// </summary>
        /// <param name="services"></param>
        public static void AddHandlers(this IServiceCollection services)
        {
            services.AddTransient<AlunoHandler, AlunoHandler>();
        }

        /// <summary>
        /// The register service.
        /// </summary>
        /// <param name="services"></param>
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IAlunoRepository, AlunoRepository>();
        }

        #endregion
    }
}
