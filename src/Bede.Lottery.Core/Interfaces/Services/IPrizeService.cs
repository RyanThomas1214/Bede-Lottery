using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Core.Interfaces.Services
{
	public interface IPrizeService
	{
		Prize GetPrize(int id);
		Prize GetRandomPrize();
	}
}
