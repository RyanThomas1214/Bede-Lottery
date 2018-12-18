using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CET119_Assignments;

namespace Bede.Lottery.Forms.UI
{
	public partial class frmAwardPrize : Form
	{
		private readonly frmMain _mainForm;

		public frmAwardPrize(frmMain mainForm)
		{
			_mainForm = mainForm;
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			_mainForm.Show();
			Close();
		}
	}
}
