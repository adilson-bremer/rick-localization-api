using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RickLocalization.Domain.IoC {

    public static class DomainDependency {

        public static void AddDomaninDependency(this IServiceCollection services, IConfiguration configuration) {

            UnitOfWorkDependency.AddUnitOfWorkDependency(services);
            AppDBContextDependency.AddAppDBContextDependency(services, configuration);
        }
    }
}
