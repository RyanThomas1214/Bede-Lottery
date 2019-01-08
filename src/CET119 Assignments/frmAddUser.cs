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
	public partial class frmAddUser : Form
	{
		private readonly IEmployeeService _employeeService;

		public frmAddUser(IEmployeeService employeeService)
		{
			_employeeService = employeeService;

			InitializeComponent();
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			
			try
			{
				var name = txtName.Text;
				_employeeService.AddEmployee(name);


				MessageBox.Show($"Employee Saved");

			}
			catch (Exception ex)
			{
				MessageBox.Show("Unable to save Employee, Please try again. \r\n Detail:" + ex.Message);
			}
		}
	

		private void btnBack_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
