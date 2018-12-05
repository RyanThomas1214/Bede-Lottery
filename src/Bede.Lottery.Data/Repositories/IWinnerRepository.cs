using System;
using System.Linq;
using Bede.Lottery.Core;
using Bede.Lottery.Core.Interfaces;
using Bede.Lottery.Core.Models;
using ModelWinner = Bede.Lottery.Core.Models.Winner;

namespace Bede.Lottery.Data.Repositories
{
	public class WinnerRepository : IWinnerRepository
	{

		public ModelWinner GetWinner(int id)
		{
			using (var context = new bedelotteryEntities())
			{
				Winner winner = context.Winner.Where(p => p.Id == id).FirstOrDefault();
				return ConvertFromTableToBusinessObject(winner);
			}
		}

		public Core.Models.Prize GetWinningPrize(Core.Models.Prize prize)
		{
			using (var context = new bedelotteryEntities())
			{
				Prize prize = context.Prizes.Where(p => p.Id == id).FirstOrDefault();
				return ConvertFromTableToBusinessObject(prize);
			}
		}

		private Winner ConvertFromTableToBusinessObject(Winner winner)
		{
			return new Winner
			{
				Id = winner.Id
			};
		}

		public ModelWinner AddPrize(Prize prize)
		{
			// connect to db
			using (var context = new bedelotteryEntities())
			{
				// create new row entry
				Prize dbWinner = new Prize()
				{
					Description = prize.Description,
					Name = prize.Name

				};

				// add to table
				context.Winners.Add(dbWinner);

				// save db changes
				context.SaveChanges();

				// return db object (with Id)
				return ConvertFromTableToBusinessObject(dbWinner);
			}
		}

		private ModelWinner ConvertFromTableToBusinessObject(Prize prize)
		{
			return new ModelWinner
			{
				Id = prize.Id,
			};
		}

		//Core.Models.Prize IWinnerRepository.GetWinner(int id)
		//{
		//	using (var context = new bedelotteryEntities())
		//	{
		//		Winner winner = context.Winner.Where(p => p.Id == id).FirstOrDefault();
		//		return ConvertFromTableToBusinessObject(winner);
		//	}
		//}
	}
}