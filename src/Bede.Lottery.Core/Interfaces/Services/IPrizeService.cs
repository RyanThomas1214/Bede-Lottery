using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Core.Interfaces.Services
{
	public interface IPrizeService
	{
		
		Prize GetRandomPrize();
		void AddPrize(string name, string description);
	}
}
