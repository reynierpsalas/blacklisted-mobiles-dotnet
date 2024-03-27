using AutoMapper;
using BlacklistedMobiles.API.Models.Domain;
using BlacklistedMobiles.API.Models.DTO;

namespace BlacklistedMobiles.API.Mappings;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Trademark, TrademarkDto>().ReverseMap();
        CreateMap<AddTrademarkRequestDto, Trademark>().ReverseMap();
        CreateMap<UpdateTrademarkRequestDto, Trademark>().ReverseMap();

        CreateMap<Province, ProvinceDto>().ReverseMap();

        CreateMap<MunicipalityDto, Municipality>().ReverseMap();
    }
}