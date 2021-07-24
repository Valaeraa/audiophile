using Audiophile.API.Dtos;
using Audiophile.Domain.Entities;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace Audiophile.API.Helpers
{
    public class TabletUrlResolver : IValueResolver<Image, ImageDto, string>
    {
        private readonly IConfiguration _config;

        public TabletUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(Image source, ImageDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.Tablet))
            {
                return $"{_config["ApiUrl"]}{source.Tablet.Remove(0, 2)}";
            }

            return null;
        }
    }
}
