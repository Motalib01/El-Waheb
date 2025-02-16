using AutoMapper;
using ElWaheb.Api.Dtos;
using ElWaheb.Api.Entites;

namespace ElWaheb.Api.Extentions
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<DonationRequest, DonationRequestDto>().ReverseMap();
            CreateMap<Location, LocationDto>().ReverseMap();
            CreateMap<Notification, NotificationDto>().ReverseMap();
        }
    }
}
