﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bede.Lottery.Core.Interfaces.Services;
using Bede.Lottery.Core.Models;
using CET119_Assignments;

namespace Bede.Lottery.Forms.UI
{
	public partial class frmAwardPrize : Form
	{
		private IWinnersService _winnersService;

		public frmAwardPrize(IWinnersService winnersService)
		{
			_winnersService = winnersService;
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			var winner = _winnersService.ChooseWinner();
			
			//populate employee
			lblName.Text = winner.WinningEmployee.Name;
			lblId.Text = winner.WinningEmployee.Id.ToString();

			//populate prize
			lblPrizeName.Text = winner.WinningPrize.Name;
			lblDescription.Text = winner.WinningPrize.Description;
		}
	}
}
