using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Bede.Lottery.Core.Interfaces.Services;
using Bede.Lottery.Core.Models;

namespace Bede.Lottery.Forms.UI
{
	public partial class frmAwardPrize : Form
	{
		private IWinnersService _winnersService;
		private List<Winner> _winners;

		public frmAwardPrize(IWinnersService winnersService)
		{
			_winnersService = winnersService;
			InitializeComponent();
			_winners = new List<Winner>();

			dgvWinners.DataSource = _winners;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			//empty list
			_winners = new List<Winner>();

			//get required amount of prizes
			int prizesToAward;
			if (!int.TryParse(txtNumber.Text, out prizesToAward))
			{
				MessageBox.Show("Please enter a valid number");
				return;
			}

			// randomly select prizes
			for (var i = 0; i < prizesToAward; i++)
			{
				var winner = _winnersService.ChooseWinner();
				_winners.Add(winner);
			}

			// update data grid
			dgvWinners.DataSource = typeof(List<Winner>);
			dgvWinners.DataSource = _winners;

		}


		private void frmAwardPrize_Load(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (var winner in _winners)
				{
					_winnersService.AddWinner(winner);
				}
			
				MessageBox.Show($"Added {_winners.Count} new winners!");

			}
			catch (Exception ex)
			{
				MessageBox.Show("Unable to save Prize, Please try again. \r\n Detail:" + ex.Message);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
