using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bede.Lottery.Core.Models;

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