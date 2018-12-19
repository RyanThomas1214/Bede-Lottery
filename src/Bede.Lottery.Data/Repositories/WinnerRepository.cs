using System.Collections.Generic;
using System.Linq;
using ModelWinner = Bede.Lottery.Core.Models.Winner;
using Bede.Lottery.Core.Interfaces.Repositories;
using ModelPrize = Bede.Lottery.Core.Models.Prize;
using ModelEmployee = Bede.Lottery.Core.Models.Employee;

namespace Bede.Lottery.Data.Repositories
{
    public class WinnerRepository : IWinnerRepository
    {

        public ModelWinner GetWinner(int id)
        {
            using (var context = new bedelotteryEntities())
            {
                Winner winner = context.Winners.Where(p => p.Id == id).FirstOrDefault();
                return EntityMapper.MapWinnerToModel(winner);
            }
        }

        public List<ModelWinner> GetWinners(int skip, int take)
        {
            List<ModelWinner> winners = new List<ModelWinner>();

            using (var context = new bedelotteryEntities())
            {
                winners = context.Winners.Select(e => new ModelWinner
                {
                    Id = e.Id,
                    WinningEmployee = new ModelEmployee
                    {
                        Id = e.Employee.Id,
                        Name = e.Employee.Name
                    },
                    WinningPrize = new ModelPrize
                    {
                        Id = e.Prize.Id,
                        Description = e.Prize.Description,
                        Name = e.Prize.Name,
                    },
                    PrizeDraw = e.PrizeDraw

                }).OrderByDescending(e => e.Id).Skip(skip).Take(take).ToList();
            }

            return winners;
        }
    }
}