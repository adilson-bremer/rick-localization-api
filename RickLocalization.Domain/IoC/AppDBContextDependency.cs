using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RickLocalization.Domain.Context;

namespace RickLocalization.Domain.IoC {

    static class AppDBContextDependency {

        public static void AddAppDBContextDependency(this IServiceCollection services, IConfiguration configuration) {

            services.AddDbContext<AppDBContext>(options => {

                options.UseSqlServer(AppValues.SQLSERVER_CONNECTION_STRING);

                //options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
