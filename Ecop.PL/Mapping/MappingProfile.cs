using AutoMapper;
using Ecop.DAL.Models;
using Ecop.PL.Areas.Dashboard.ViewModels;

namespace Ecop.PL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Citizen, CitizenVM>();


            CreateMap<ViolationFormVM, TrafficViolation>();
        }
    }
}
