using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Organite.Infrastructure.Data;
using Organite.Infrastructure.Seeders;

namespace Organite.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("OrganiteDB");
        services.AddDbContext<OrganiteDBContext>(options => options.UseSqlServer(connectionString));

        services.AddScoped<INotesSeeder, NotesSeeder>();
    }
}
