using AutoMapper;
using MessEssence.Business.Interface;
using MessEssence.Domain;
using MessEssenceUI.App_Start;
using MessEssenceUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MessEssenceUI.Controllers
{
    public class HomeController : Controller
    {
        //public HomeController() { }

        IEmployeeBusiness employeeBusiness;
        public HomeController(IEmployeeBusiness _empBusiness)
        {
            employeeBusiness = _empBusiness;
        }


        public ActionResult Index()
        {
            List<EmployeeDomainModel>  employeeDomainModelList = employeeBusiness.GetAllEmployee();
            List<EmployeeViewModel> employeeViewModelList = new List<EmployeeViewModel>();


            // Automaper starts
            var config = new AutoMapperConfig().Configure();
            IMapper imapper = config.CreateMapper();

            ViewBag.EmployeeList = imapper.Map(employeeDomainModelList, employeeViewModelList);
            // Automapper ends

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}