using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Bede.Lottery.Core
{
	class Winner
	{
		public Employee WinningEmployee { get; set; }
		public Prize WinningPrize { get; set; }
	}
}
