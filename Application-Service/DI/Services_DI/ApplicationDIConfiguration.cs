using Application_Service.Services.UserManagmentService.Implementation;
using Application_Service.Services.UserManagmentService.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Application_Service.DI.Services_DI
{
    public static class ApplicationDIConfiguration
    {
        public static IServiceCollection ApplicationDIConfig(this IServiceCollection services)
        {
            // Add application layer services here
            services.AddScoped<IUserAccountService, UserAccountService>()
                .AddScoped<IPasswordEncryptor, PasswordEncryptor>();
            return services;
        }
    }
}
