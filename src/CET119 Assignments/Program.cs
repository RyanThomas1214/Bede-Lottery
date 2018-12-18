using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Bede.Lottery.Core;
using Bede.Lottery.Core.Interfaces;
using Bede.Lottery.Core.Interfaces.Repositories;
using Bede.Lottery.Core.Interfaces.Services;
using Bede.Lottery.Data.Repositories;
using Bede.Lottery.Forms.UI;

namespace CET119_Assignments
{
	static class Program
	{
		private static IContainer _container;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			BuildContainer();
			Application.Run(_container.Resolve<frmMain>());
		}

		static void BuildContainer()
		{
			var builder = new ContainerBuilder();

			// Register individual services
			builder.RegisterType<WinnersService>().As<IWinnersService>();
			builder.RegisterType<PrizeService>().As<IPrizeService>();
			builder.RegisterType<EmployeeService>().As<IEmployeeService>();

			// register forms
			builder.RegisterType<frmMain>();
			builder.RegisterType<frmAwardPrize>();
			builder.RegisterType<frmHistory>();

			//register data providers
			builder.RegisterType<PrizeRepository>().As<IPrizeRepository>();
			builder.RegisterType<WinnerRepository>().As<IWinnerRepository>();
			builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>();

			//build container
			_container = builder.Build();
		}
	}
}
