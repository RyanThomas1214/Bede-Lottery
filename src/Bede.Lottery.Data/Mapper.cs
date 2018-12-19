using ModelWinner = Bede.Lottery.Core.Models.Winner;
using ModelPrize = Bede.Lottery.Core.Models.Prize;
using ModelEmployee = Bede.Lottery.Core.Models.Employee;

namespace Bede.Lottery.Data
{
    public static class EntityMapper
    {
        public static ModelWinner MapWinnerToModel(Winner winner)
        {
            return new ModelWinner
            {
                Id = winner.Id
            };
        }

        public static ModelPrize MapPrizeToModel(Prize prize)
        {
            return new ModelPrize
            {
                Id = prize.Id,
                Description = prize.Description,
                Name = prize.Name
            };
        }
        public static ModelEmployee MapEmployeeToModel(Employee employee)
        {
            return new ModelEmployee
            {
                Id = employee.Id,
                Name = employee.Name
            };
        }
    }
}