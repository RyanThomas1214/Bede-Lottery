using System;
using System.Collections.Generic;
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

		public List<ModelWinner> GetWinners(int skip, int take)
		{
			List<ModelWinner> winners = new List<ModelWinner>();

			using (var context = new bedelotteryEntities())
			{
				winners = context.Winners.Select( e=> new ModelWinner
				{
					Id = e.Id,
					WinningEmployee = e.Employee,
					WinningPrize = e.Prize
					//code to map
				}).OrderBy(e=>e.Id).Skip(skip).Take(take).ToList();
			}

			return winners;
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