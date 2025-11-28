using AutoMapper;
using Organite.Application.Notes.Commands.CreateNote;
using Organite.Application.Notes.Commands.UpdateNote;
using Organite.Domain.Entities;

namespace Organite.Application.Notes.Dtos;

public class NoteProfile : Profile
{
    public NoteProfile()
    {
        CreateMap<CreateNoteCommand, Note>()
            .ForMember(n => n.CreatedAt, opt => opt.MapFrom(_=> DateTime.Now))
            .ForMember(n => n.UpdatedAt, opt => opt.MapFrom(_=> DateTime.Now))
            .ForMember(n => n.IsPinned, opt => opt.MapFrom(_ => false));

        CreateMap<UpdateNoteCommand, Note>()
           .ForMember(n => n.UpdatedAt, opt => opt.MapFrom(_ => DateTime.Now));

        CreateMap<Note, NoteDto>();
    }
}
