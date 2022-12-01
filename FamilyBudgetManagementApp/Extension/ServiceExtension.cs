using FamilyBudgetApp.Services;
using FamilyBudgetManagementApp.Data;
using FamilyBudgetManagementApp.Services;
using Microsoft.EntityFrameworkCore;

namespace FamilyBudgetManagementApp.Extension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<BudgetService>();
            services.AddTransient<TransactionService>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContexts(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");

            services.AddDbContext<AppDbContext>(options =>
                 options.UseSqlServer(connectionString,
                     o => o.EnableRetryOnFailure()));
            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
    }
}
