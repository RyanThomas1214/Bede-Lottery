using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Core.Interfaces.Services
{
	public interface IPrizeService
	{
		Prize GetPrize(int id);
		Prize GetRandomPrize();
	}
}
