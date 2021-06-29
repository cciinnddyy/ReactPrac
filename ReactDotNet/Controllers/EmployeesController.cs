using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReactDotNet.Models;
namespace ReactDotNet.Controllers
{
    public class EmployeesController : Controller
    {
        private HumanResourceEntities _entity = new HumanResourceEntities();
        // GET: Employees
        public ActionResult Create()
        {
            Employees employee = _entity.Employees.FirstOrDefault();
            return View();
        }
    }
}