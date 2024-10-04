using MonTue.Models;

namespace MonTue.Interfaces
{
    public interface IEmployeeService
    {
        public Employee GetEmployee(int id);

        public List<Employee> GetEmployees();

        public void AddEmployee(Employee employee);

        void UpdateEmployee(Employee employee);

        void DeleteEmployee(int id);
    }
}
