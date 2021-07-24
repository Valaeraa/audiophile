using Audiophile.API.Dtos;
using Audiophile.Domain.Entities;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace Audiophile.API.Helpers
{
    public class DesktopUrlResolver : IValueResolver<Image, ImageDto, string>
    {
        private readonly IConfiguration _config;

        public DesktopUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(Image source, ImageDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.Desktop))
            {
                return $"{_config["ApiUrl"]}{source.Desktop.Remove(0, 2)}";
            }

            return null;
        }
    }
}
