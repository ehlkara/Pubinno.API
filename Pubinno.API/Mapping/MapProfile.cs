using Abp.Dependency;
using AutoMapper;

namespace Pubinno.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            using (var scope = IocManager.Instance.CreateScope())
            {

            }
        }
    }
}
