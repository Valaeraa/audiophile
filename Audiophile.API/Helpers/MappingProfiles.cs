using Audiophile.API.Dtos;
using Audiophile.Domain.Entities;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;

namespace Audiophile.API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<Image, ImageDto>()
                .ForMember(d => d.Mobile, o => o.MapFrom<MobileUrlResolver>())
                .ForMember(d => d.Tablet, o => o.MapFrom<TabletUrlResolver>())
                .ForMember(d => d.Desktop, o => o.MapFrom<DesktopUrlResolver>());
            CreateMap<Include, IncludeDto>();
            CreateMap<Gallery, GalleryDto>();
            CreateMap<Other, OtherDto>();
        }
    }
}
