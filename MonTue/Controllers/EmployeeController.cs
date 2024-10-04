using Microsoft.AspNetCore.Mvc;
using MonTue.Interfaces;
using MonTue.Models;
using MonTue.Services;

namespace MonTue.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private IEmployeeService _employee;

        public EmployeeController(IEmployeeService employee)
        {
            _employee = employee;
        }

        [Route("~/")]
        [Route("[action]")]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost("[action]")]
        public ActionResult Login(string username,string password)
        {
            if(username.Equals("brijesh")&&password.Equals("daggad"))
            {
                return View("Index");
            }
            return View();
        }

        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]/{id?}")]
        public ActionResult ErrorPage(int? id)
        {
            return View(id);
        }

        [HttpGet("[action]")]
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost("[action]")]
        public ActionResult AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                // Save the employee
                _employee.AddEmployee(employee);

                // Return JSON response with employee data
                return Json(new { success = true});
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpGet("[action]")]
        public ActionResult GetEmployee()
        {
            
            return ViewComponent("EmployeeData");
        }



        [HttpGet("[action]")]
        public ActionResult UpdateEmployee()
        {

            return View();
        }

        [HttpPost("[action]")]
        public ActionResult UpdateEmployee(Employee employee)
        {
            if(ModelState.IsValid)
            {
                _employee.UpdateEmployee(employee);

                return View();
            }
            return View(employee);
        }

        [HttpGet("[action]")]
        public ActionResult DeleteEmployee(int id)
        {
            _employee.DeleteEmployee(id);

            return View();
        }
    }
}
