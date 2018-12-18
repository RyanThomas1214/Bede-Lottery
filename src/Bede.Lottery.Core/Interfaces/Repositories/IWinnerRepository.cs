using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Core.Interfaces.Repositories
{
	public interface IWinnerRepository
	{
		Winner GetWinner(int id);
	}
}
