using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bede.Lottery.Core.Interfaces
{
	public interface IPrizeService
	{
		Prize GetPrize(int id);
		Prize GetRandomPrize();
	}
}
