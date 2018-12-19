using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bede.Lottery.Core.Interfaces.Services;
using CET119_Assignments;

namespace Bede.Lottery.Forms.UI
{
	public partial class frmHistory : Form
	{
		private readonly IWinnersService _winnersService;

		public frmHistory(IWinnersService winnersService)
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

		}

		private void frmHistory_Load(object sender, EventArgs e)
		{
			//Get previous Winners
			var winners = _winnersService.GetWinners();
			//bind the collection to data grid
			//update UI?


		}
	}
}
