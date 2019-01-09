using System;
using System.Windows.Forms;
using Bede.Lottery.Core.Interfaces.Services;

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
		    RefreshData();
		}

		private void frmHistory_Load(object sender, EventArgs e)
		{
		    RefreshData();
		}

	    void RefreshData()
	    {
	        var winners = _winnersService.GetWinners();
	        dgvWinners.DataSource = winners;
	    }
	}
}
