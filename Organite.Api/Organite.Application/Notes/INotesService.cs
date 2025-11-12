using Organite.Application.Notes.Dtos;

namespace Organite.Application.Notes
{
    public interface INotesService
    {
        Task<IEnumerable<NoteDto>> GetAllNotes();
        Task<NoteDto?> GetById(int id);
        Task<int> Create(CreateNoteDto noteDto);
    }
}