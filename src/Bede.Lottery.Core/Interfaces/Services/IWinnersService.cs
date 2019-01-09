using System.Collections.Generic;
using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Core.Interfaces.Services
{
	public interface IWinnersService
	{
		Winner ChooseWinner();
		List<Winner> GetWinners(int skip = 0, int take = 10);
		void AddWinner(Winner winner);
	}
}
