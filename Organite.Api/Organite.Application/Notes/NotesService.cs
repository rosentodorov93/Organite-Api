using Microsoft.Extensions.Logging;
using Organite.Domain.Entities;
using Organite.Domain.Repositories;

namespace Organite.Application.Notes;

internal class NotesService(INotesRepository repo, ILogger<NotesService> logger) : INotesService
{
    public async Task<IEnumerable<Note>> GetAllNotes()
    {
        logger.LogInformation("Fetching all notes");
        var notes = await repo.GetAllAsync();
        return notes;
    }

    public async Task<Note?> GetById(int id)
    {
        logger.LogInformation($"Getting note with id: {id}");
        var note = await repo.GetByIdAsync(id);
        return note;
    }
}
