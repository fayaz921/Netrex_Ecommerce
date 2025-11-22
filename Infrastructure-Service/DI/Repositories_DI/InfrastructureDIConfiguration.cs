using Domain_Service.RepoInterfaces.UserCreadRepo;
using Domain_Service.RepoInterfaces.UserRoles;
using Domain_Service.RepoInterfaces.Users;
using Infrastructure_Service.Persistance.Repositories.UserCreadRepo;
using Infrastructure_Service.Persistance.Repositories.UserRoles;
using Infrastructure_Service.Persistance.Repositories.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure_Service.DI.Repositories_DI
{
    public static class InfrastructureDIConfiguration
    {
        public static IServiceCollection InfrastuctureDIConfig(this IServiceCollection services)
        {
            services.AddScoped<IUserRepo, UserRepo>()
                .AddScoped<IUserCreadRepo, UserCreadRepo>()
                .AddScoped<IUserRoleRepo, UserRoleRepo>();

            return services;
        }
    }
}
