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
        public ActionResult Employee()
        {
            string city = "Mississauga";
            int count = employees.Count(e => e.City == city);
            ViewBag.EmployeeCount = count;
            return View();
        }        

        List<EmployeeViewModel> employees = new List<EmployeeViewModel> {
            new EmployeeViewModel{ FullName = "Miguel Saritama", EmployeeID = "id1", SIN = 111111111, PhoneNumber = "5612005637", City = "Boynton Beach", Salary = 1233.896m, Country = "USA"},
            new EmployeeViewModel{ FullName = "Jonathan Valles", EmployeeID = "id2", SIN = 222222222, PhoneNumber = "2222005637", City = "Delray Beach", Salary = 222.644m, Country = "UNITED STATES"},
            new EmployeeViewModel{ FullName = "Robert Moran", EmployeeID = "id3", SIN = 333333333, PhoneNumber = "3332005637", City = "Pompano Beach", Salary = 333.5966m, Country = "UNITED STATES OF AMERICA"},
            new EmployeeViewModel{ FullName = "Jairo Flores", EmployeeID = "id4", SIN = 4444444, PhoneNumber = "4442005637", City = "Mississauga", Salary = 111, Country = "CANADA"},
            new EmployeeViewModel{ FullName = "NameF", EmployeeID = "id5", SIN = 555555555, PhoneNumber = "5552005637", City = "Sarasota", Salary = 111, Country = "GERMANY"},
            new EmployeeViewModel{ FullName = "NameG", EmployeeID = "id6", SIN = 666666666, PhoneNumber = "6662005637", City = "Boca Raton", Salary = 111, Country = "UKRAINE"},
            new EmployeeViewModel{ FullName = "NameH", EmployeeID = "id7", SIN = 777777777, PhoneNumber = "7772005637", City = "Fort Lauderdale", Salary = 111, Country = "AFRICA"},
            new EmployeeViewModel{ FullName = "NameI", EmployeeID = "id8", SIN = 888888888, PhoneNumber = "8882005637", City = "Welington", Salary = 111, Country = "ENGLAND"},
            new EmployeeViewModel{ FullName = "NameG", EmployeeID = "id9", SIN = 999999999, PhoneNumber = "9992005637", City = "Congress", Salary = 111, Country = "MEXICO"},
            new EmployeeViewModel{ FullName = "NameK", EmployeeID = "id10", SIN = 110111111, PhoneNumber = "5612001010", City = "city kkk", Salary = 111, Country = "HONDURAS"},
            new EmployeeViewModel{ FullName = "NameL", EmployeeID = "id11", SIN = 111111111, PhoneNumber = "5612001111", City = "city lll", Salary = 111, Country = "GUATEMALA"},
            new EmployeeViewModel{ FullName = "NameM", EmployeeID = "id12", SIN = 112111111, PhoneNumber = "5612001212", City = "Mississauga", Salary = 111, Country = "COSTA RICA"},
            new EmployeeViewModel{ FullName = "NameN", EmployeeID = "id13", SIN = 113111111, PhoneNumber = "5612001313", City = "city nnn", Salary = 111, Country = "PUERTO RICO"},
            new EmployeeViewModel{ FullName = "NameO", EmployeeID = "id14", SIN = 114111111, PhoneNumber = "5612001414", City = "city ooo", Salary = 111, Country = "CUBA"},
            new EmployeeViewModel{ FullName = "NameP", EmployeeID = "id15", SIN = 115111111, PhoneNumber = "5612001515", City = "city ppp", Salary = 111, Country = "CANADA"},
            new EmployeeViewModel{ FullName = "NameQ", EmployeeID = "id16", SIN = 116111111, PhoneNumber = "5612001616", City = "city qqq", Salary = 111, Country = "AUSTRALIA"},
        };

        public JsonResult Grid_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(employees.ToDataSourceResult(request));
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
