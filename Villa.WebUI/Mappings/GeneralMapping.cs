using AutoMapper;
using Villa.DTO.DTOs.BannerDTOs;
using Villa.Entity.Entities;

namespace Villa.WebUI.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<ResultBannerDTO, Banner>().ReverseMap();
            CreateMap<UpdateBannerDTO, Banner>().ReverseMap();
            CreateMap<CreateBannerDTO, Banner>().ReverseMap();
        }
    }
}