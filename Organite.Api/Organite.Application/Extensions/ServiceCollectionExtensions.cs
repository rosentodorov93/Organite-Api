using Microsoft.Extensions.DependencyInjection;
using Organite.Application.Notes;

namespace Organite.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<INotesService, NotesService>();
        services.AddAutoMapper(typeof(ServiceCollectionExtensions).Assembly);
    }
}
