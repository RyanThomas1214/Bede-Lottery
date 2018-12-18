namespace Bede.Lottery.Forms.UI
{
	partial class frmAwardPrize
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnBack = new System.Windows.Forms.Button();
			this.btnEmployeeRefresh = new System.Windows.Forms.Button();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.listView2 = new System.Windows.Forms.ListView();
			this.lblEmployee = new System.Windows.Forms.Label();
			this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
			this.btnPrizeRefresh = new System.Windows.Forms.Button();
			this.lblPrize = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(27, 33);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(83, 77);
			this.btnBack.TabIndex = 0;
			this.btnBack.Text = "BACK";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnEmployeeRefresh
			// 
			this.btnEmployeeRefresh.Location = new System.Drawing.Point(721, 647);
			this.btnEmployeeRefresh.Name = "btnEmployeeRefresh";
			this.btnEmployeeRefresh.Size = new System.Drawing.Size(121, 62);
			this.btnEmployeeRefresh.TabIndex = 2;
			this.btnEmployeeRefresh.Text = "Refresh";
			this.btnEmployeeRefresh.UseVisualStyleBackColor = true;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerate.Location = new System.Drawing.Point(630, 301);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(346, 77);
			this.btnGenerate.TabIndex = 3;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(27, 483);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(688, 226);
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// listView2
			// 
			this.listView2.Location = new System.Drawing.Point(906, 483);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(649, 226);
			this.listView2.TabIndex = 5;
			this.listView2.UseCompatibleStateImageBehavior = false;
			// 
			// lblEmployee
			// 
			this.lblEmployee.AutoSize = true;
			this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmployee.Location = new System.Drawing.Point(20, 443);
			this.lblEmployee.Name = "lblEmployee";
			this.lblEmployee.Size = new System.Drawing.Size(157, 37);
			this.lblEmployee.TabIndex = 6;
			this.lblEmployee.Text = "Employee";
			// 
			// btnPrizeRefresh
			// 
			this.btnPrizeRefresh.Location = new System.Drawing.Point(1561, 647);
			this.btnPrizeRefresh.Name = "btnPrizeRefresh";
			this.btnPrizeRefresh.Size = new System.Drawing.Size(121, 62);
			this.btnPrizeRefresh.TabIndex = 8;
			this.btnPrizeRefresh.Text = "Refresh";
			this.btnPrizeRefresh.UseVisualStyleBackColor = true;
			// 
			// lblPrize
			// 
			this.lblPrize.AutoSize = true;
			this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrize.Location = new System.Drawing.Point(899, 443);
			this.lblPrize.Name = "lblPrize";
			this.lblPrize.Size = new System.Drawing.Size(89, 37);
			this.lblPrize.TabIndex = 9;
			this.lblPrize.Text = "Prize";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(13, 136);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(658, 79);
			this.lblTitle.TabIndex = 10;
			this.lblTitle.Text = "Bede Lottery Winner";
			// 
			// frmAwardPrize
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1703, 965);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblPrize);
			this.Controls.Add(this.btnPrizeRefresh);
			this.Controls.Add(this.lblEmployee);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.btnEmployeeRefresh);
			this.Controls.Add(this.btnBack);
			this.Name = "frmAwardPrize";
			this.Text = "frmAwardPrize";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnEmployeeRefresh;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.Label lblEmployee;
		private System.DirectoryServices.DirectoryEntry directoryEntry1;
		private System.Windows.Forms.Button btnPrizeRefresh;
		private System.Windows.Forms.Label lblPrize;
		private System.Windows.Forms.Label lblTitle;
	}
}