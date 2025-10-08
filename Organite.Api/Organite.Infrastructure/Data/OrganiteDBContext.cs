using Microsoft.EntityFrameworkCore;
using Organite.Domain.Entities;

namespace Organite.Infrastructure.Data;

internal class OrganiteDBContext : DbContext
{
    internal DbSet<Note> Notes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=OrganiteDB;Integrated Security=SSPI;MultipleActiveResultSets=true;TrustServerCertificate=True");
    }
}
