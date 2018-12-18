using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bede.Lottery.Forms.UI;

namespace CET119_Assignments
{
	public partial class frmMain : Form
	{
		private frmAwardPrize AwardPrizeForm;
		private frmHistory WinnerHistory;

		public frmMain()
		{
			InitializeComponent();
			
		}

		private void btnPickWinner_Click(object sender, EventArgs e)
		{
			this.Hide();
			AwardPrizeForm = new frmAwardPrize(this);
			AwardPrizeForm.Show();
		}

		private void btnPreviousWinners_Click(object sender, EventArgs e)
		{
			this.Hide();
			WinnerHistory = new frmHistory(this);
			WinnerHistory.Show();
		}
	}
}
