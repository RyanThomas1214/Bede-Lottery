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
	public class EmployeeServiceTests
	{
		List<Employee> EmployeeList = new List<Employee>()
		{
			new Employee()
			{
				Name="Ryan",
				Id=1
			},
			new Employee()
			{
				Name="notRyan",
				Id=2
			}
		};

		[Test]
		public void AddEmployeeShouldNotThrowExceptionWhenValidInputIsUsed()
		{
			var mockRepository = new Mock<IEmployeeRepository>();
			mockRepository.Setup(repo => repo.AddEmployee(It.IsAny<string>())).Verifiable();
			var sut = new EmployeeService(mockRepository.Object);

			Assert.DoesNotThrow(() => sut.AddEmployee("Ryan"));
			mockRepository.Verify(e => e.AddEmployee("Ryan"), Times.Once);
		}

		[Test]
		public void AddEmployeeShouldReturnAFriendlyErrorMessageWhenRepositoryThrowsException()
		{
			var mockRepository = new Mock<IEmployeeRepository>();
			mockRepository.Setup(repo => repo.AddEmployee(It.IsAny<string>())).Throws(new Exception("RepositoryError")).Verifiable();
			var sut = new EmployeeService(mockRepository.Object);

			var thrownException = Assert.Throws<Exception>(() => sut.AddEmployee("Ryan"));
			mockRepository.Verify(e => e.AddEmployee("Ryan"), Times.Once);
			Assert.That(thrownException.Message == "There was an error adding a new Employee, please try again");
		}

		[Test]
		public void GetRandomEmployeeShouldNotThrowException()
		{
			var mockRepository = new Mock<IEmployeeRepository>();
			mockRepository.Setup(repo => repo.GetAll()).Returns(EmployeeList).Verifiable();
			var sut = new EmployeeService(mockRepository.Object);

			var employee = sut.GetRandomEmployee();

			Assert.That(employee != null);
			mockRepository.Verify(e => e.GetAll(), Times.Once);
		}

		[Test]
		public void GetRandomEmployeeShouldReturnAFriendlyErrorMessageWhenRepositoryThrowsException()
		{
			var mockRepository = new Mock<IEmployeeRepository>();
			mockRepository.Setup(repo => repo.GetAll()).Throws(new Exception("RepositoryError")).Verifiable();
			var sut = new EmployeeService(mockRepository.Object);

			var thrownException = Assert.Throws<Exception>(() => sut.GetRandomEmployee());
			mockRepository.Verify(e => e.GetAll(), Times.Once);
			Assert.That(thrownException.Message == "There was an error getting Random Employee, please try again");
		}

	}
}
