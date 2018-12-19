using System;
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
		public Prize GetPrize(int id)
		{
			throw new NotImplementedException();
		}

		public Prize GetRandomPrize()
		{
			return _prizeRepository.GetRandomPrize();
		}
	}
}
