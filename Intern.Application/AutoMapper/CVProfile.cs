using AutoMapper;
using Intern.Domain.Entities;
using InternIngressInternal.Intern.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*CVProfile.cs needs to be created for AutoMapper to work properly. And it needs to be in the same namespace as the Startup.cs file.*/
namespace Intern.Application.AutoMapper
{
    public class CVProfile : Profile
    {
        public CVProfile()
        {
            CreateMap<CVViewModel, CV>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Mail))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Education, opt => opt.MapFrom(src => src.Education))
                .ForMember(dest => dest.Experience, opt => opt.MapFrom(src => src.Experience))
                .ForMember(dest => dest.Skills, opt => opt.MapFrom(src => src.Skills))
                .ForMember(dest => dest.Languages, opt => opt.MapFrom(src => src.Languages));
        }
    }
}
