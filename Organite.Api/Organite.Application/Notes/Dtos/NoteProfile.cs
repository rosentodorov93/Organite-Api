using AutoMapper;
using Organite.Domain.Entities;

namespace Organite.Application.Notes.Dtos;

public class NoteProfile : Profile
{
    public NoteProfile()
    {
        CreateMap<CreateNoteDto, Note>()
            .ForMember(n => n.CreatedAt, opt => opt.MapFrom(_=> DateTime.Now))
            .ForMember(n => n.UpdatedAt, opt => opt.MapFrom(_=> DateTime.Now))
            .ForMember(n => n.IsPinned, opt => opt.MapFrom(_ => false));

        CreateMap<Note, NoteDto>();
    }
}
