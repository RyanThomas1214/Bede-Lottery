﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bede.Lottery.Core.Models
{
	public class Winner
	{
		public int Id { get; set; }
		public Employee WinningEmployee { get; set; }
		public Prize WinningPrize { get; set; }
		public string PrizeDraw { get; set; }
	}
}
