using Abp.Dependency;
using AutoMapper;
using Pubinno.Models.Entities.Pubinno;
using Pubinno.Shared.PubinnoDTOs;

namespace Pubinno.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            using (var scope = IocManager.Instance.CreateScope())
            {
                CreateMap<Location, LocationDto>().ReverseMap();
            }
        }
    }
}
