using System;
using System.Collections.Generic;
using System.Linq;
using Bede.Lottery.Core;
using Bede.Lottery.Core.Interfaces;
using Bede.Lottery.Core.Interfaces.Repositories;
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
				Employee employee = context.Employees.FirstOrDefault(p => p.Id == id);
				return ConvertFromTableToBusinessObject(employee);
			}
		}

		public IEnumerable<ModelEmployee> GetAll()
		{
			using (var context = new bedelotteryEntities())
			{
				return context.Employees.Select(p => new ModelEmployee { Id = p.Id, Name = p.Name }).ToList();
			}
		}

		private static ModelEmployee ConvertFromTableToBusinessObject(Employee employee)
		{
			return new ModelEmployee
			{
				Id = employee.Id,
				Name = employee.Name
			};
		}


	}
}