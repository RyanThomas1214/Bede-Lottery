using System.Collections.Generic;

namespace Bede.Lottery.Core
{
	public interface IEmployeeService
	{
		Employee GetEmployee(int id);
		Employee GetRandomEmployee();
		Employee GetEmployeeByName(string name);
		List<Employee> GetEmployees();
	}
}