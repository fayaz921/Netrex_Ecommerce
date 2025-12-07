using Application_Service.Persistance.Repositories.UserManagment;
using Application_Service.RepoInterfaces.UserManagment;
using Domain_Service.RepoInterfaces.GenericRepo;
using Domain_Service.RepoInterfaces.UnitOfWork;
using Infrastructure_Service.Persistance.GenericRepo;
using Infrastructure_Service.Persistance.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure_Service.DI.Repositories_DI
{
    public static class InfrastructureDIConfiguration
    {
        public static IServiceCollection InfrastuctureDIConfig(this IServiceCollection services)
        {
            services.AddScoped<IUserRepo, UserRepo>()
                .AddScoped<IUserCreadRepo, UserCreadRepo>()
                .AddScoped<IUserRoleRepo, UserRoleRepo>()
                .AddScoped(typeof(IRepository<>), typeof(Repository<>))
                .AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
