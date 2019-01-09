using System.Collections.Generic;
using System.Linq;
using Bede.Lottery.Core.Interfaces.Repositories;
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
                return EntityMapper.MapEmployeeToModel(employee);
            }
        }

        public IEnumerable<ModelEmployee> GetAll()
        {
            using (var context = new bedelotteryEntities())
            {
                return context.Employees.Select(p => new ModelEmployee { Id = p.Id, Name = p.Name }).ToList();
            }
        }

	    public void AddEmployee(string name)
	    
			{
				// connect to db
				using (var context = new bedelotteryEntities())
				{
					// create new row entry
					Employee dbEmployee = new Employee
					{
						
						Name = name

					};

					// add to table
					context.Employees.Add(dbEmployee);

					// save db changes
					context.SaveChanges();
				}
			}

		
	}
}