using System;
using System.Windows.Forms;

namespace Bede.Lottery.Forms.UI
{
	public partial class frmMain : Form
	{
		private readonly frmAwardPrize _awardsForm;
		private readonly frmHistory _historyForm;

		public frmMain(frmAwardPrize awardsForm, frmHistory historyForm)
		{
			_awardsForm = awardsForm;
			_historyForm = historyForm;
			InitializeComponent();
		}

		private void btnPickWinner_Click(object sender, EventArgs e)
		{
			this.Hide();
			_awardsForm.ShowDialog(this);
			this.Show();
		}

		private void btnPreviousWinners_Click(object sender, EventArgs e)
		{
			this.Hide();
			_historyForm.ShowDialog();
			this.Show();
		}
	}
}
