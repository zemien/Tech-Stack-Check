using System;
using AutoMapper;
using TechStackCheck.Web.Models;

namespace TechStackCheck.Web.Mappers
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Value, ValueViewModel>()
                .ForMember(vm => vm.Id, opt => opt.MapFrom(v => v.PartitionKey))
                .ForMember(vm => vm.Id2, opt => opt.MapFrom(v => v.RowKey));
        }
    }
}
