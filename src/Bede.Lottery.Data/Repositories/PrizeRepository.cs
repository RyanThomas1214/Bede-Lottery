using System;
using System.Collections.Generic;
using System.Linq;
using ModelPrize = Bede.Lottery.Core.Models.Prize;
using Bede.Lottery.Core.Interfaces.Repositories;
using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Data.Repositories
{
    public class PrizeRepository : IPrizeRepository
    {
		public ModelPrize GetPrize(int id)
        {
            using (var context = new bedelotteryEntities())
            {
                Prize prize = context.Prizes.FirstOrDefault(p => p.Id == id);
                return EntityMapper.MapPrizeToModel(prize);
            }
        }

		public IEnumerable<ModelPrize> GetAll()
		{
			using (var context = new bedelotteryEntities())
			{
				return context.Employees.Select(p => new ModelPrize { Id = p.Id, Name = p.Name }).ToList();
			}
		}

		public IEnumerable<ModelPrize> GetRandomPrize()
        {
			using (var context = new bedelotteryEntities())
			{
				return context.Employees.Select(p => new ModelPrize { Id = p.Id, Name = p.Name }).ToList();
			}
		}


        public ModelPrize UpdatePrize(ModelPrize prize)
        {
            using (var context = new bedelotteryEntities())
            {
                // get db entity
                Prize dbPrize = context.Prizes.FirstOrDefault(p => p.Id == prize.Id);

                // update fields
                dbPrize.Description = prize.Description;
                dbPrize.Name = prize.Name;

                //save db record
                context.SaveChanges();

                // return converted model
                return EntityMapper.MapPrizeToModel(dbPrize);
            }
        }

		public void AddPrize(string name, string description)
		{
			// connect to db
			using (var context = new bedelotteryEntities())
			{
				// create new row entry
				Prize dbPrize = new Prize
				{
					Name = name,
					Description = description
				};

				// add to table
				context.Prizes.Add(dbPrize);

				// save db changes
				context.SaveChanges();

			}
		}

		List<ModelPrize> IPrizeRepository.GetRandomPrize()
		{
			using (var context = new bedelotteryEntities())
			{
				return context.Employees.Select(p => new ModelPrize { Id = p.Id, Name = p.Name }).ToList();
			}
		}
	}
}