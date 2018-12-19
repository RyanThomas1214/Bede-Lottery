using System.Collections.Generic;
using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Core.Interfaces.Repositories
{
	public interface IWinnerRepository
	{
		Winner GetWinner(int id);
		List<Winner> GetWinners(int skip, int take);
	}
}
