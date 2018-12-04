using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bede.Lottery.Core.Interfaces
{
	public interface IWinnersService
	{
		Winner GetWinner(int id);
		Winner ChooseWinner();
		List<Winner> GetWinnersFromDraw(string prizeDraw);
	}
}
