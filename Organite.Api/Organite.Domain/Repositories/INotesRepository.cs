using Organite.Domain.Entities;

namespace Organite.Domain.Repositories;

public interface INotesRepository
{
    public Task<IEnumerable<Note>> GetAllAsync();
    public Task<Note?> GetByIdAsync(int id);
    public Task<int> Create(Note note);
    Task Delete(Note note);
    Task SaveChangesAsync();
}
