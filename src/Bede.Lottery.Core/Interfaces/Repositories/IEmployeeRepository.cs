using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Core.Interfaces.Repositories
{
	public interface IEmployeeRepository
	{
		Employee GetEmployee(int id);
	}
}
