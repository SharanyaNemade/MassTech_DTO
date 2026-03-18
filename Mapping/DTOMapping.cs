using AutoMapper;
using FebBatch2026WebApi.DTO;
using FebBatch2026WebApi.Models;

namespace FebBatch2026WebApi.Mapping
{
    public class DTOMapping : Profile
    {
        public DTOMapping()
        {
            CreateMap<Emp, EmpDTO>().ReverseMap();
            CreateMap<Emp, EmpDTOFetch>().ForMember(x => x.mname, x => x.MapFrom(x => x.managers.mname != null ? x.managers.mname : "No"));

        }
    }
}
