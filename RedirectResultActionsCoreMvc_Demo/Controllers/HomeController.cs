using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RedirectResultActionsCoreMvc_Demo.Models;

namespace RedirectResultActionsCoreMvc_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public RedirectResult MyProfile()
        {
            return Redirect("https://www.c-sharpcorner.com/members/farhan-ahmed24");
        }
        public RedirectResult Profile()
        {
            return RedirectPermanent("https://www.c-sharpcorner.com/members/farhan-ahmed24");
        }

        public RedirectToActionResult EmployeeList()
        {
            return RedirectToAction("Index", "Employees");
        }

        public RedirectToRouteResult DepartmentList()
        {
            return RedirectToRoute(new { action = "Index", controller = "Departments", area="" });
        }

        public LocalRedirectResult LocalRedirect()
        {
            return LocalRedirect("/Home/Index");
        }
    }
}
