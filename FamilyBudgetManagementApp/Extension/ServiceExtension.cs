using FamilyBudgetManagementApp.Data;
using FamilyBudgetManagementApp.Services;
using FamilyBudgetManagementApp.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace FamilyBudgetManagementApp.Extension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<BudgetService>();
           
            return services;
        }

        public static IServiceCollection AddApplicationDbContexts(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");

            services.AddDbContext<AppDbContext>(options =>
                 options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
    }
}
