using System.Collections.Generic;
using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Core.Interfaces.Services
{
	public interface IEmployeeService
	{
		Employee GetRandomEmployee();
		void AddEmployee(string name);
	}
}