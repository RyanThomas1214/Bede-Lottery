using System.Collections.Generic;

namespace Bede.Lottery.Core.Interfaces.Services
{
	public interface IEmployeeService
	{
		Employee GetEmployee(int id);
		Employee GetRandomEmployee();
		Employee GetEmployeeByName(string name);
		List<Employee> GetEmployees();
	}
}