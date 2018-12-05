using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Core.Interfaces
{
	public interface IPrizeRepository
	{
		Prize GetPrize(int id);
		Prize GetRandomPrize();
		Prize AddPrize(Prize prize);
		Prize UpdatePrize(Prize prize);
	}
}
