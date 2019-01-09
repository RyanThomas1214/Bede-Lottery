using System;
using System.Collections.Generic;
using Bede.Lottery.Core.Interfaces.Repositories;
using Bede.Lottery.Core.Interfaces.Services;
using Bede.Lottery.Core.Models;
using Bede.Lottery.Service;
using Moq;
using NUnit.Framework;

namespace Bede.Lottery.UnitTests
{
	[TestFixture]
	public class WinnerServiceTests
	{
		List<Winner> WinnerList = new List<Winner>()
		{
			new Winner()
			{
				WinningEmployee = new Employee(),
				WinningPrize = new Prize(),
				PrizeDraw = "poiuytrewq"
			},
			new Winner()
			{
				WinningEmployee = new Employee(),
				WinningPrize = new Prize(),
				PrizeDraw = "qwertyuiop"
			}
		};

		Winner ValidWinner = new Winner()
		{
			PrizeDraw = "sdfgfgsgsfdg",
			WinningEmployee = new Employee(),
			WinningPrize = new Prize()
		};

		[Test]
		public void AddWinnerShouldNotThrowExceptionWhenValidInputIsUsed()
		{
			var mockRepository = new Mock<IWinnerRepository>();
			var mockPrizeService = new Mock<IPrizeService>();
			var mockEmployeeService = new Mock<IEmployeeService>();

			mockRepository.Setup(repo => repo.AddWinner(It.IsAny<Winner>())).Verifiable();
			var sut = new WinnersService(mockRepository.Object, mockPrizeService.Object, mockEmployeeService.Object);

			Assert.DoesNotThrow(() => sut.AddWinner(ValidWinner));
			mockRepository.Verify(e => e.AddWinner(ValidWinner), Times.Once);
		}

		[Test]
		public void AddWinnerShouldReturnAFriendlyErrorMessageWhenRepositoryThrowsException()
		{
			var mockRepository = new Mock<IWinnerRepository>();
			var mockPrizeService = new Mock<IPrizeService>();
			var mockEmployeeService = new Mock<IEmployeeService>();
			mockRepository.Setup(repo => repo.AddWinner(It.IsAny<Winner>())).Throws(new Exception("RepositoryError")).Verifiable();
			var sut = new WinnersService(mockRepository.Object, mockPrizeService.Object, mockEmployeeService.Object);

			var thrownException = Assert.Throws<Exception>(() => sut.AddWinner(ValidWinner));
			mockRepository.Verify(e => e.AddWinner(ValidWinner), Times.Once);
			Assert.That(thrownException.Message == "There was an error adding a new Winner, please try again");
		}

		[Test]
		public void GetWinnerShouldNotThrowException()
		{
			var mockRepository = new Mock<IWinnerRepository>();
			var mockPrizeService = new Mock<IPrizeService>();
			var mockEmployeeService = new Mock<IEmployeeService>();

			mockRepository.Setup(repo => repo.GetWinners(It.IsAny<int>(), It.IsAny<int>())).Returns(WinnerList).Verifiable();

			var sut = new WinnersService(mockRepository.Object, mockPrizeService.Object, mockEmployeeService.Object);

			var winner = sut.GetWinners();

			Assert.That(winner != null);
		}

		[Test]
		public void GetWinnerShouldReturnAFriendlyErrorMessageWhenRepositoryThrowsException()
		{
			var mockRepository = new Mock<IWinnerRepository>();
			var mockPrizeService = new Mock<IPrizeService>();
			var mockEmployeeService = new Mock<IEmployeeService>();

			mockRepository.Setup(repo => repo.GetWinners(It.IsAny<int>(), It.IsAny<int>())).Throws(new Exception("RepositoryError")).Verifiable();
			var sut = new WinnersService(mockRepository.Object, mockPrizeService.Object, mockEmployeeService.Object);

			var thrownException = Assert.Throws<Exception>(() => sut.GetWinners());
			Assert.That(thrownException.Message == "There was an error getting a new Winner, please try again");
		}
	}
}
