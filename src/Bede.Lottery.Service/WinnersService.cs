﻿using System;
using System.Collections.Generic;
using Bede.Lottery.Core.Interfaces.Repositories;
using Bede.Lottery.Core.Interfaces.Services;
using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Service
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
			var drawId = Guid.NewGuid().ToString();

			// pick employee
			var employee = _employeeService.GetRandomEmployee();
			//pick prize
			var prize = _prizeService.GetRandomPrize();
			//make winner 
			var winner = new Winner
			{
				PrizeDraw = drawId,
				WinningEmployee= employee,
				WinningPrize = prize
			};
			return winner;
		}


		public List<Winner> GetWinners(int skip = 0, int take = 10)
		{
			try
			{
				var winners = _winnersRepository.GetWinners(skip, take);
				return winners;
			}
			catch (Exception e)
			{
				var exception = new Exception("There was an error getting a new Winner, please try again", e);
				throw exception;
			}


		}

		public void AddWinner(Winner winner)
		{
			try
			{
				_winnersRepository.AddWinner(winner);
			}
			catch (Exception e)
			{
				var exception = new Exception("There was an error adding a new Winner, please try again", e);
				throw exception;
			}
			
		}
	}
}
