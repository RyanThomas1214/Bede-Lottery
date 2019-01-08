using System;
using System.Collections.Generic;
using Bede.Lottery.Core.Interfaces.Repositories;
using Bede.Lottery.Core.Models;
using Bede.Lottery.Service;
using Moq;
using NUnit.Framework;

namespace Bede.Lottery.UnitTests
{
	[TestFixture]
	public class PrizeServiceTests
	{
		List<Prize> PrizeList = new List<Prize>()
		{
			new Prize()
			{
				Name = "Alcohol",
				Description = "Wine"
			},
			new Prize()
			{
				Name = "Food",
				Description = "Chocolate"
			}
		};

		[Test]
		public void GetRandomPrizeShouldNotThrowException()
		{
			var mockRepository = new Mock<IPrizeRepository>();
			mockRepository.Setup(repo => repo.GetRandomPrize()).Returns(PrizeList).Verifiable();
			var sut = new PrizeService(mockRepository.Object);

			var prize = sut.GetRandomPrize();

			Assert.That(prize != null);
			mockRepository.Verify(e => e.GetRandomPrize(), Times.Once);
		}

		[Test]
		public void GetRandomPrizeShouldReturnAFriendlyErrorMessageWhenRepositoryThrowsException()
		{
			var mockRepository = new Mock<IPrizeRepository>();
			mockRepository.Setup(repo => repo.GetRandomPrize()).Throws(new Exception("RepositoryError")).Verifiable();
			var sut = new PrizeService(mockRepository.Object);

			var thrownException = Assert.Throws<Exception>(() => sut.GetRandomPrize());
			mockRepository.Verify(e => e.GetRandomPrize(), Times.Once);
			Assert.That(thrownException.Message == "There was an error getting Random Prize, please try again");
		}

		[Test]
		public void AddPrizeShouldNotThrowExceptionWhenValidInputIsUsed()
		{
			var mockRepository = new Mock<IPrizeRepository>();
			mockRepository.Setup(repo => repo.AddPrize(It.IsAny<string>(), It.IsAny<string>())).Verifiable();
			var sut = new PrizeService(mockRepository.Object);

			Assert.DoesNotThrow(() => sut.AddPrize("Alcohol", "Wine"));
			mockRepository.Verify(e => e.AddPrize("Alcohol", "Wine"), Times.Once);
		}

		[Test]
		public void AddPrizeShouldReturnAFriendlyErrorMessageWhenRepositoryThrowsException()
		{
			var mockRepository = new Mock<IPrizeRepository>();
			mockRepository.Setup(repo => repo.AddPrize(It.IsAny<string>(), It.IsAny<string>())).Throws(new Exception("RepositoryError")).Verifiable();
			var sut = new PrizeService(mockRepository.Object);

			var thrownException = Assert.Throws<Exception>(() => sut.AddPrize("Alcohol", "Wine"));
			mockRepository.Verify(e => e.AddPrize("Alcohol", "Wine"), Times.Once);
			Assert.That(thrownException.Message == "There was an error adding a new Prize, please try again");
		}

	}
}
