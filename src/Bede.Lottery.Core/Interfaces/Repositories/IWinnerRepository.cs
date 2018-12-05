using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Core.Interfaces
{
	public interface IWinnerRepository
	{
		Prize GetWinner(int id);
		Prize GetWinningPrize(Prize prize);
	}
}
