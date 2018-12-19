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
		public Employee GetEmployee(int id)
		{
			throw new System.NotImplementedException();
		}

		public Employee GetEmployeeByName(string name)
		{
			throw new System.NotImplementedException();
		}

		public List<Employee> GetEmployees()
		{
			throw new System.NotImplementedException();
		}

		public Employee GetRandomEmployee()
		{
			var employees = _employeeRepository.GetAll();
			return employees.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
		}
	}
}