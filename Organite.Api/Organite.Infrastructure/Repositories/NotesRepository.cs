using Microsoft.EntityFrameworkCore;
using Organite.Domain.Entities;
using Organite.Domain.Repositories;
using Organite.Infrastructure.Data;

namespace Organite.Infrastructure.Repositories
{
    internal class NotesRepository(OrganiteDBContext dbContext) : INotesRepository
    {
        public async Task<IEnumerable<Note>> GetAllAsync()
        {
            var notes = await dbContext.Notes.ToListAsync();
            return notes;
        }

        public async Task<Note?> GetByIdAsync(int id)
        {
            var note = await dbContext.Notes.FirstOrDefaultAsync(x => x.Id == id);
            return note;
        }
    }
}
