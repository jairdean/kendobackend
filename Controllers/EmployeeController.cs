using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // GET: EmployeeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: https://localhost:7245/Employee/LoadEmployees
        public ViewResult LoadEmployees()
        {
            //https://www.youtube.com/watch?v=nHAMDUtiV6w
            List<EmployeeViewModel> myList = new List<EmployeeViewModel>() {

                new EmployeeViewModel{ FullName = "Miguel Saritama", EmployeeID = "id1", SIN = 11, PhoneNumber = 5612005637, City = "Boynton Beach", Salary = 1111, Country = "USA"},
                new EmployeeViewModel{ FullName = "NameB", EmployeeID = "id2", SIN = 22, PhoneNumber = 2222005637, City = "Delray Beach", Salary = 111, Country = "UNITED STATES"},
                new EmployeeViewModel{ FullName = "NameC", EmployeeID = "id3", SIN = 33, PhoneNumber = 3332005637, City = "Pompano Beach", Salary = 111, Country = "UNITED STATES OF AMERICA"},
                new EmployeeViewModel{ FullName = "NameD", EmployeeID = "id4", SIN = 44, PhoneNumber = 4442005637, City = "City Place", Salary = 111, Country = "POLAND"},
                new EmployeeViewModel{ FullName = "NameF", EmployeeID = "id5", SIN = 55, PhoneNumber = 5552005637, City = "Sarasota", Salary = 111, Country = "GERMANY"},
                new EmployeeViewModel{ FullName = "NameG", EmployeeID = "id6", SIN = 66, PhoneNumber = 6662005637, City = "Boca Raton", Salary = 111, Country = "UKRAINE"},
                new EmployeeViewModel{ FullName = "NameH", EmployeeID = "id7", SIN = 77, PhoneNumber = 7772005637, City = "Fort Lauderdale", Salary = 111, Country = "AFRICA"},
                new EmployeeViewModel{ FullName = "NameI", EmployeeID = "id8", SIN = 88, PhoneNumber = 8882005637, City = "Welington", Salary = 111, Country = "ENGLAND"},
                new EmployeeViewModel{ FullName = "NameG", EmployeeID = "id9", SIN = 99, PhoneNumber = 9992005637, City = "Congress", Salary = 111, Country = "MEXICO"},
                new EmployeeViewModel{ FullName = "NameK", EmployeeID = "id10", SIN = 110, PhoneNumber = 5612001010, City = "city kkk", Salary = 111, Country = "HONDURAS"},
                new EmployeeViewModel{ FullName = "NameL", EmployeeID = "id11", SIN = 111, PhoneNumber = 5612001111, City = "city lll", Salary = 111, Country = "GUATEMALA"},
                new EmployeeViewModel{ FullName = "NameM", EmployeeID = "id12", SIN = 112, PhoneNumber = 5612001212, City = "city mmm", Salary = 111, Country = "COSTA RICA"},
                new EmployeeViewModel{ FullName = "NameN", EmployeeID = "id13", SIN = 113, PhoneNumber = 5612001313, City = "city nnn", Salary = 111, Country = "PUERTO RICO"},
                new EmployeeViewModel{ FullName = "NameO", EmployeeID = "id14", SIN = 114, PhoneNumber = 5612001414, City = "city ooo", Salary = 111, Country = "CUBA"},
                new EmployeeViewModel{ FullName = "NameP", EmployeeID = "id15", SIN = 115, PhoneNumber = 5612001515, City = "city ppp", Salary = 111, Country = "PANAMA"},
                new EmployeeViewModel{ FullName = "NameQ", EmployeeID = "id16", SIN = 116, PhoneNumber = 5612001616, City = "city qqq", Salary = 111, Country = "AUSTRALIA"},
            };

            return View(myList);
        }

        // GET: https://localhost:7245/Employee/Grid_Read
        //https://docs.telerik.com/aspnet-core/html-helpers/data-management/grid/getting-started-grid

        List<EmployeeViewModel> employees = new List<EmployeeViewModel> {
            new EmployeeViewModel{ FullName = "Miguel Saritama", EmployeeID = "id1", SIN = 11, PhoneNumber = 5612005637, City = "Boynton Beach", Salary = 1111, Country = "USA"},
            new EmployeeViewModel{ FullName = "NameB", EmployeeID = "id2", SIN = 22, PhoneNumber = 2222005637, City = "Delray Beach", Salary = 111, Country = "UNITED STATES"},
            new EmployeeViewModel{ FullName = "NameC", EmployeeID = "id3", SIN = 33, PhoneNumber = 3332005637, City = "Pompano Beach", Salary = 111, Country = "UNITED STATES OF AMERICA"},
            new EmployeeViewModel{ FullName = "NameD", EmployeeID = "id4", SIN = 44, PhoneNumber = 4442005637, City = "City Place", Salary = 111, Country = "POLAND"},
            new EmployeeViewModel{ FullName = "NameF", EmployeeID = "id5", SIN = 55, PhoneNumber = 5552005637, City = "Sarasota", Salary = 111, Country = "GERMANY"},
            new EmployeeViewModel{ FullName = "NameG", EmployeeID = "id6", SIN = 66, PhoneNumber = 6662005637, City = "Boca Raton", Salary = 111, Country = "UKRAINE"},
            new EmployeeViewModel{ FullName = "NameH", EmployeeID = "id7", SIN = 77, PhoneNumber = 7772005637, City = "Fort Lauderdale", Salary = 111, Country = "AFRICA"},
            new EmployeeViewModel{ FullName = "NameI", EmployeeID = "id8", SIN = 88, PhoneNumber = 8882005637, City = "Welington", Salary = 111, Country = "ENGLAND"},
            new EmployeeViewModel{ FullName = "NameG", EmployeeID = "id9", SIN = 99, PhoneNumber = 9992005637, City = "Congress", Salary = 111, Country = "MEXICO"},
            new EmployeeViewModel{ FullName = "NameK", EmployeeID = "id10", SIN = 110, PhoneNumber = 5612001010, City = "city kkk", Salary = 111, Country = "HONDURAS"},
            new EmployeeViewModel{ FullName = "NameL", EmployeeID = "id11", SIN = 111, PhoneNumber = 5612001111, City = "city lll", Salary = 111, Country = "GUATEMALA"},
            new EmployeeViewModel{ FullName = "NameM", EmployeeID = "id12", SIN = 112, PhoneNumber = 5612001212, City = "city mmm", Salary = 111, Country = "COSTA RICA"},
            new EmployeeViewModel{ FullName = "NameN", EmployeeID = "id13", SIN = 113, PhoneNumber = 5612001313, City = "city nnn", Salary = 111, Country = "PUERTO RICO"},
            new EmployeeViewModel{ FullName = "NameO", EmployeeID = "id14", SIN = 114, PhoneNumber = 5612001414, City = "city ooo", Salary = 111, Country = "CUBA"},
            new EmployeeViewModel{ FullName = "NameP", EmployeeID = "id15", SIN = 115, PhoneNumber = 5612001515, City = "city ppp", Salary = 111, Country = "PANAMA"},
            new EmployeeViewModel{ FullName = "NameQ", EmployeeID = "id16", SIN = 116, PhoneNumber = 5612001616, City = "city qqq", Salary = 111, Country = "AUSTRALIA"},
        };

        public JsonResult Grid_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(employees.ToDataSourceResult(request));
        }

        public JsonResult GetEmployeeCountByCity(string city)
        {
            int count = employees.Count(e => e.City == city);
            return Json(new { City = city, Count = count });
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
