﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bede.Lottery.Core.Interfaces
{
	public class WinnersService : IWinnersService
	{
		public Winner ChooseWinner()
		{
			throw new NotImplementedException();
		}

		public Winner GetWinner(int id)
		{
			throw new NotImplementedException();
		}

		public List<Winner> GetWinnersFromDraw(string prizeDraw)
		{
			throw new NotImplementedException();
		}
	}
}