using AutoMapper;
using Organite.Domain.Entities;

namespace Organite.Application.Notes.Dtos;

public class NoteProfile : Profile
{
    public NoteProfile()
    {
        CreateMap<Note, NoteDto>();
    }
}
