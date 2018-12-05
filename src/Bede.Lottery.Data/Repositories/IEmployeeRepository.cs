using System;
using System.Linq;
using Bede.Lottery.Core;
using Bede.Lottery.Core.Interfaces;
using Bede.Lottery.Core.Models;
using ModelEmployee = Bede.Lottery.Core.Models.Employee;

namespace Bede.Lottery.Data.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
	{

		public ModelEmployee GetEmployee(int id)
		{
			using (var context = new bedelotteryEntities())
			{
				Employee employee = context.Employees.Where(p => p.Id == id).FirstOrDefault();
				return ConvertFromTableToBusinessObject(employee);
			}
		}

		private Employee ConvertFromTableToBusinessObject(Employee employee)
		{
			return new Employee
			{
				Id = employee.Id,
				Name = employee.Name
			};
		}


	}
}