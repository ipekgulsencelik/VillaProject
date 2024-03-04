using AutoMapper;
using Villa.DTO.DTOs.BannerDTOs;
using Villa.DTO.DTOs.ContactDTOs;
using Villa.DTO.DTOs.CounterDTOs;
using Villa.DTO.DTOs.DealDTOs;
using Villa.DTO.DTOs.FeatureDTOs;
using Villa.DTO.DTOs.MessageDTOs;
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

            CreateMap<ResultContactDTO, Contact>().ReverseMap();
            CreateMap<UpdateContactDTO, Contact>().ReverseMap();
            CreateMap<CreateContactDTO, Contact>().ReverseMap();

            CreateMap<ResultCounterDTO, Counter>().ReverseMap();
            CreateMap<UpdateCounterDTO, Counter>().ReverseMap();
            CreateMap<CreateCounterDTO, Counter>().ReverseMap();

            CreateMap<ResultDealDTO, Deal>().ReverseMap();
            CreateMap<UpdateDealDTO, Deal>().ReverseMap();
            CreateMap<CreateDealDTO, Deal>().ReverseMap();

            CreateMap<ResultFeatureDTO, Feature>().ReverseMap();
            CreateMap<UpdateFeatureDTO, Feature>().ReverseMap();
            CreateMap<CreateFeatureDTO, Feature>().ReverseMap();

            CreateMap<ResultMessageDTO, Message>().ReverseMap();
            CreateMap<CreateMessageDTO, Message>().ReverseMap();
        }
    }
}