using System;
using System.Linq;
using Bede.Lottery.Core.Interfaces;
using Bede.Lottery.Core.Models;
using ModelWinner = Bede.Lottery.Core.Models.Winner;
using Bede.Lottery.Core.Interfaces.Repositories;

namespace Bede.Lottery.Data.Repositories
{
	public class WinnerRepository : IWinnerRepository
	{

		public ModelWinner GetWinner(int id)
		{
			using (var context = new bedelotteryEntities())
			{
				Winner winner = context.Winners.Where(p => p.Id == id).FirstOrDefault();
				return ConvertFromTableToBusinessObject(winner);
			}
		}

		private ModelWinner ConvertFromTableToBusinessObject(Winner winner)
		{
			return new ModelWinner
			{
				Id = winner.Id
			};
		}
	}
}