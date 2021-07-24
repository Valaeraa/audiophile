using Audiophile.API.Dtos;
using Audiophile.Domain.Entities;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace Audiophile.API.Helpers
{
    public class MobileUrlResolver : IValueResolver<Image, ImageDto, string>
    {
        private readonly IConfiguration _config;

        public MobileUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(Image source, ImageDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.Mobile))
            {
                return $"{_config["ApiUrl"]}{source.Mobile.Remove(0, 2)}";
            }

            return null;
        }
    }
}
