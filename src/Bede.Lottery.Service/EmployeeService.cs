using System;
using System.Collections.Generic;
using System.Linq;
using Bede.Lottery.Core.Interfaces.Repositories;
using Bede.Lottery.Core.Interfaces.Services;
using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Service
{
	public class EmployeeService : IEmployeeService
	{
		private readonly IEmployeeRepository _employeeRepository;

		public EmployeeService(IEmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}
		public void AddEmployee(string name)
		{
			try
			{
				_employeeRepository.AddEmployee(name);
			}
			catch (Exception e)
			{
				var exception = new Exception("There was an error adding a new Employee, please try again", e);
				throw exception;
			}
		}

		public Employee GetRandomEmployee()
		{
			try
			{
				var employees = _employeeRepository.GetAll();
				return employees.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
			}
			catch (Exception e)
			{
				var exception = new Exception("There was an error getting Random Employee, please try again", e);
				throw exception;
			}
		}
	}
}