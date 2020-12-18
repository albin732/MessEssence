using AutoMapper;
using MessEssenceUI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessEssenceUI.App_Start
{
    public class AutoMapperConfig
    {
        //public static void config()
        //{
        //    Mapper.Initialize( cfg => cfg.CreateMap<Author,AuthorDTO>());
        //}

        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                //way one, either this line of code plus controller code  :,,ReverseMap() is added to Viceversa transfer between Models
                //cfg.CreateMap<EmployeeDomainModel, EmployeeViewModel>().ReverseMap();

                //way two, or this line os code plus AutoMapperWebProfile code plus the container code
                cfg.AddProfile<AutomapperWebProfile>();
            }
           );

            return config;
        }
    }
}