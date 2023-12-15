using AutoMapper;
using SheepYourHackApp.Server.Controllers;

namespace SheepYourHackApp.Server.Helper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Test, TestDto>();
    }
}
