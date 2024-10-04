using Microsoft.AspNetCore.Mvc;
using MonTue.Interfaces;

namespace MonTue.ViewComponents
{
    public class EmployeeDataViewComponent : ViewComponent
    {
        private IEmployeeService _employee;

        public EmployeeDataViewComponent(IEmployeeService employee)
        {
            _employee = employee;
        }

        public IViewComponentResult Invoke()
        {
            return View(_employee.GetEmployees());
        }
    }
}
