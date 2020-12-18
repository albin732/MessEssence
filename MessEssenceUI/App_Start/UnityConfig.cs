using MessEssence.Business;
using MessEssence.Business.Interface;
using MessEssence.Repository.Infrastructure;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MessEssenceUI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IEmployeeBusiness, EmployeeBusiness>();
            container.RegisterType<IDepartmentBusiness, DepartmentBusiness>();

            container.RegisterType<IUnitOfWork, UnitOfWork>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}