using Microsoft.EntityFrameworkCore;
using Organite.Domain.Entities;

namespace Organite.Infrastructure.Data;

internal class OrganiteDBContext(DbContextOptions<OrganiteDBContext> options) : DbContext(options)
{
    internal DbSet<Note> Notes { get; set; }
}
