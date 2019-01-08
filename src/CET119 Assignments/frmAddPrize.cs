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

namespace Bede.Lottery.Forms.UI
{
	public partial class frmAddPrize : Form
	{
		private readonly IPrizeService _prizeService;

		public frmAddPrize(IPrizeService prizeService)
		{
			_prizeService = prizeService;

			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				var name = txtName.Text;
				var description = txtDescription.Text;
				_prizeService.AddPrize(name,description);


				MessageBox.Show("Prize Saved");

			}
			catch (Exception ex)
			{
				MessageBox.Show("Unable to save Prize, Please try again. \r\n Detail:" + ex.Message);
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}