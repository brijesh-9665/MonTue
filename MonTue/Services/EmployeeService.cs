using MonTue.Interfaces;
using MonTue.Models;

namespace MonTue.Services
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees;
        public EmployeeService()
        {
            employees = new List<Employee>
            {
                new Employee(){eid=1,ename="Brijesh",salary=10000},
                new Employee(){eid=2,ename="Harsh",salary=100000},
                new Employee(){eid=3,ename="Hemanth",salary=100000},
                new Employee(){eid=4,ename="Umesh",salary=100000},
                new Employee(){eid=5,ename="Hareesh",salary=100000},
                new Employee(){eid=6,ename="Daggad",salary=100000}
            };
        }
        public Employee GetEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.eid == id);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = employees.FirstOrDefault(e=>e.eid==employee.eid);

            if (existingEmployee != null)
            {
                existingEmployee.eid = employee.eid;
                existingEmployee.ename = employee.ename;
                existingEmployee.salary = employee.salary;
            }
        }

        public void DeleteEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.eid == id);

            if(employee!=null)
            {
                employees.Remove(employee);
            }
        }
    }
}
