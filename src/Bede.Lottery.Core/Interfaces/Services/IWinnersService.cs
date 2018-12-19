using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Core.Interfaces.Services
{
	public interface IWinnersService
	{
		Winner GetWinner(int id);
		Winner ChooseWinner();
		List<Winner> GetWinnersFromDraw(string prizeDraw);
		List<Winner> GetWinners(int skip = 0, int take = 10);
	}
}
