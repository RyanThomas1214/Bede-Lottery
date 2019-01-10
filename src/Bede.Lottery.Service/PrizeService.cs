using System;
using System.Linq;
using Bede.Lottery.Core.Interfaces.Repositories;
using Bede.Lottery.Core.Interfaces.Services;
using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Service
{
	public class PrizeService : IPrizeService
	{
		private readonly IPrizeRepository _prizeRepository;

		public PrizeService(IPrizeRepository prizeRepository)
		{
			_prizeRepository = prizeRepository;
		}
		
		public Prize GetRandomPrize()
		{
			try
			{
				var prize = _prizeRepository.GetAllPrizes();
				return prize.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
			}
			catch (Exception e)
			{
				var exception = new Exception("There was an error getting Random Prize, please try again", e);
				throw exception;
			}
		}

		public void AddPrize(string name, string description)
		{
			try
			{
				_prizeRepository.AddPrize(name, description);
			}
			catch (Exception e)
			{
				var exception = new Exception("There was an error adding a new Prize, please try again", e);
				throw exception;
			}
		}
	}
}
