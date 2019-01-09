using System;
using System.Windows.Forms;

namespace Bede.Lottery.Forms.UI
{
	public partial class frmMain : Form
	{
		private readonly frmAwardPrize _awardsForm;
		private readonly frmHistory _historyForm;
		private readonly frmAddUser _addUserForm;
		private readonly frmAddPrize _addPrizeForm;

		public frmMain(frmAwardPrize awardsForm, frmHistory historyForm, frmAddUser addUserForm, frmAddPrize addPrizeForm)
		{
			_awardsForm = awardsForm;
			_historyForm = historyForm;
			_addUserForm = addUserForm;
			_addPrizeForm = addPrizeForm;
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

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			this.Hide();
			_addUserForm.ShowDialog(this);
			this.Show();
		}

		private void btnAddPrize_Click(object sender, EventArgs e)
		{
			this.Hide();
			_addPrizeForm.ShowDialog(this);
			this.Show();
		}
	}
}
