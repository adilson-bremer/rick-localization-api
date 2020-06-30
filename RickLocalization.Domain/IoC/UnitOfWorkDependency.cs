using Microsoft.Extensions.DependencyInjection;
using RickLocalization.Domain.Repositories;
using RickLocalization.Domain.Repositories.Interface;

namespace RickLocalization.Domain.IoC {

    static class UnitOfWorkDependency {

        public static void AddUnitOfWorkDependency(this IServiceCollection services) {

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
