using System.Collections.Generic;
using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Core.Interfaces.Repositories
{
	public interface IEmployeeRepository
	{
		Employee GetEmployee(int id);
		IEnumerable<Employee> GetAll();
		void AddEmployee(string name);
	}
}
