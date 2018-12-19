using System;
using System.Linq;
using ModelPrize = Bede.Lottery.Core.Models.Prize;
using Bede.Lottery.Core.Interfaces.Repositories;

namespace Bede.Lottery.Data.Repositories
{
    public class PrizeRepository : IPrizeRepository
    {
        public ModelPrize AddPrize(ModelPrize prize)
        {
            // connect to db
            using (var context = new bedelotteryEntities())
            {
                // create new row entry
                Prize dbPrize = new Prize
                {
                    Description = prize.Description,
                    Name = prize.Name

                };

                // add to table
                context.Prizes.Add(dbPrize);

                // save db changes
                context.SaveChanges();

                // return db object (with Id)
                return EntityMapper.MapPrizeToModel(dbPrize);
            }
        }

        public ModelPrize GetPrize(int id)
        {
            using (var context = new bedelotteryEntities())
            {
                Prize prize = context.Prizes.FirstOrDefault(p => p.Id == id);
                return EntityMapper.MapPrizeToModel(prize);
            }
        }

        public ModelPrize GetRandomPrize()
        {
            using (var context = new bedelotteryEntities())
            {
                Prize prize = context.Prizes.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
                return EntityMapper.MapPrizeToModel(prize);
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
    }
}