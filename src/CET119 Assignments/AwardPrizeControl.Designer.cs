namespace Bede.Lottery.Forms.UI
{
	partial class AwardPrizeControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblPrize = new System.Windows.Forms.Label();
			this.btnPrizeRefresh = new System.Windows.Forms.Button();
			this.lblEmployee = new System.Windows.Forms.Label();
			this.listView2 = new System.Windows.Forms.ListView();
			this.listView1 = new System.Windows.Forms.ListView();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.btnEmployeeRefresh = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblPrize
			// 
			this.lblPrize.AutoSize = true;
			this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrize.Location = new System.Drawing.Point(916, 217);
			this.lblPrize.Name = "lblPrize";
			this.lblPrize.Size = new System.Drawing.Size(89, 37);
			this.lblPrize.TabIndex = 16;
			this.lblPrize.Text = "Prize";
			// 
			// btnPrizeRefresh
			// 
			this.btnPrizeRefresh.Location = new System.Drawing.Point(1578, 421);
			this.btnPrizeRefresh.Name = "btnPrizeRefresh";
			this.btnPrizeRefresh.Size = new System.Drawing.Size(121, 62);
			this.btnPrizeRefresh.TabIndex = 15;
			this.btnPrizeRefresh.Text = "Refresh";
			this.btnPrizeRefresh.UseVisualStyleBackColor = true;
			// 
			// lblEmployee
			// 
			this.lblEmployee.AutoSize = true;
			this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmployee.Location = new System.Drawing.Point(37, 217);
			this.lblEmployee.Name = "lblEmployee";
			this.lblEmployee.Size = new System.Drawing.Size(157, 37);
			this.lblEmployee.TabIndex = 14;
			this.lblEmployee.Text = "Employee";
			// 
			// listView2
			// 
			this.listView2.Location = new System.Drawing.Point(923, 257);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(649, 226);
			this.listView2.TabIndex = 13;
			this.listView2.UseCompatibleStateImageBehavior = false;
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(44, 257);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(688, 226);
			this.listView1.TabIndex = 12;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerate.Location = new System.Drawing.Point(647, 75);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(346, 77);
			this.btnGenerate.TabIndex = 11;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			// 
			// btnEmployeeRefresh
			// 
			this.btnEmployeeRefresh.Location = new System.Drawing.Point(738, 421);
			this.btnEmployeeRefresh.Name = "btnEmployeeRefresh";
			this.btnEmployeeRefresh.Size = new System.Drawing.Size(121, 62);
			this.btnEmployeeRefresh.TabIndex = 10;
			this.btnEmployeeRefresh.Text = "Refresh";
			this.btnEmployeeRefresh.UseVisualStyleBackColor = true;
			// 
			// AwardPrizeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblPrize);
			this.Controls.Add(this.btnPrizeRefresh);
			this.Controls.Add(this.lblEmployee);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.btnEmployeeRefresh);
			this.Name = "AwardPrizeControl";
			this.Size = new System.Drawing.Size(1728, 611);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPrize;
		private System.Windows.Forms.Button btnPrizeRefresh;
		private System.Windows.Forms.Label lblEmployee;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnEmployeeRefresh;
	}
}
