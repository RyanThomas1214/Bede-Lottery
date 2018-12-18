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
using Bede.Lottery.Forms.UI;

namespace CET119_Assignments
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
