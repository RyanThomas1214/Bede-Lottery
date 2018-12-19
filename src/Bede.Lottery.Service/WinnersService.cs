using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bede.Lottery.Core.Interfaces.Repositories;
using Bede.Lottery.Core.Models;
using Bede.Lottery.Core.Interfaces.Services;

namespace Bede.Lottery.Core.Interfaces
{
	public class WinnersService : IWinnersService
	{
		private readonly IWinnerRepository _winnersRepository;
		private readonly IPrizeService _prizeService;
		private readonly IEmployeeService _employeeService;

		public WinnersService(IWinnerRepository winnersRepository, IPrizeService prizeService, IEmployeeService employeeService)
		{
			_winnersRepository = winnersRepository;
			_prizeService = prizeService;
			_employeeService = employeeService;
		}
		public Winner ChooseWinner()
		{
			// generate prize draw ID (in future multiple winners may be needed and need to be tied together)
			var drawId = new Guid().ToString();

			// pick employee,
			var employee = _employeeService.GetRandomEmployee();
			//pick prize
			var prize = _prizeService.GetRandomPrize();
			//make winner 
			var winner = new Winner
			{
				PrizeDraw = drawId,
				WinningEmployee=employee,
				WinningPrize = prize
			};
			return winner;
		}

		public Winner GetWinner(int id)
		{
			throw new NotImplementedException();
		}

		public List<Winner> GetWinnersFromDraw(string prizeDraw)
		{
			throw new NotImplementedException();
		}

		public List<Winner> GetWinners(int skip = 0, int take = 10)
		{
			var winners = _winnersRepository.GetWinners(skip, take);
		}
	}
}
