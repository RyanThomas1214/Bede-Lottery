using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Core.Interfaces
{
	public interface IEmployeeRepository
	{
		Employee GetEmployee(int id);
	}
}
