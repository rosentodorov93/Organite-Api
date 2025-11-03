using Organite.Domain.Entities;
using Organite.Infrastructure.Data;

namespace Organite.Infrastructure.Seeders;

internal class NotesSeeder(OrganiteDBContext dbContext) : INotesSeeder
{
    public async Task Seed()
    {
        if (await dbContext.Database.CanConnectAsync())
        {
            if (!dbContext.Notes.Any())
            {
                var notes = GetNotes();
                dbContext.Notes.AddRange(notes);
                await dbContext.SaveChangesAsync();
            }
        }
    }

    private IEnumerable<Note> GetNotes()
    {
        List<Note> notes = [
                new Note
                {
                    Title = "Meeting Notes",
                    Content = "Discuss project milestones, budget, and responsibilities.",
                    CreatedAt = new DateTime(2025, 10, 25),
                    UpdatedAt = new DateTime(2025, 10, 25),
                    Tags = new List<string> { "work", "project", "meeting" }, // stored as JSON
                    IsPinned = true
                },
                new Note
                {
                    Title = "Grocery List",
                    Content = "Milk, Bread, Eggs, Coffee, Apples.",
                    CreatedAt = new DateTime(2025, 10, 28),
                    UpdatedAt = new DateTime(2025, 10, 28),
                    Tags = new List<string> { "personal", "shopping" },
                    IsPinned = false
                },
                new Note
                {
                    Title = "Learning Plan",
                    Content = "Finish React Native course and practice EF Core seeding.",
                    CreatedAt = new DateTime(2025, 10, 29),
                    UpdatedAt = new DateTime(2025, 10, 30),
                    Tags = new List<string> { "learning", "development", "dotnet" },
                    IsPinned = true
                }
            ];

        return notes;
    }
}
