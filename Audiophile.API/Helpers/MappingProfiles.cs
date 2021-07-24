using Audiophile.API.Dtos;
using Audiophile.Domain.Entities;
using AutoMapper;

namespace Audiophile.API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<Image, ImageDto>();
            CreateMap<Include, IncludeDto>();
            CreateMap<Gallery, GalleryDto>();
            CreateMap<Other, OtherDto>();
        }
    }
}
