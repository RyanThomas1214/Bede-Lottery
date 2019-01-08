using System.Collections.Generic;
using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Core.Interfaces.Repositories
{
	public interface IPrizeRepository
	{
		Prize GetPrize(int id);
		List<Prize> GetRandomPrize();
		//Prize AddPrize(Prize prize);
		Prize UpdatePrize(Prize prize);
		void AddPrize(string name, string description);
	}
}
