using AutoMapper;
using MessEssence.Domain;
using MessEssenceUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessEssenceUI.Infrastructure
{
    public class AutomapperWebProfile : AutoMapper.Profile
    {
        public AutomapperWebProfile()
        {
            CreateMap<EmployeeDomainModel, EmployeeViewModel>().ReverseMap();
        }
    }
}