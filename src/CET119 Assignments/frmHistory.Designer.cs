namespace Bede.Lottery.Forms.UI
{
	partial class frmHistory
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
			this.btnGenerate = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.dgvWinners = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvWinners)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(12, 12);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(83, 77);
			this.btnBack.TabIndex = 1;
			this.btnBack.Text = "BACK";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerate.Location = new System.Drawing.Point(646, 238);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(346, 77);
			this.btnGenerate.TabIndex = 4;
			this.btnGenerate.Text = "Refresh";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(-2, 128);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(574, 79);
			this.lblTitle.TabIndex = 11;
			this.lblTitle.Text = "Previous Winners";
			// 
			// dgvWinners
			// 
			this.dgvWinners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvWinners.Location = new System.Drawing.Point(138, 368);
			this.dgvWinners.Name = "dgvWinners";
			this.dgvWinners.RowTemplate.Height = 33;
			this.dgvWinners.Size = new System.Drawing.Size(1456, 584);
			this.dgvWinners.TabIndex = 12;
			// 
			// frmHistory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1695, 1002);
			this.Controls.Add(this.dgvWinners);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.btnBack);
			this.Name = "frmHistory";
			this.Text = "frmHistory";
			this.Load += new System.EventHandler(this.frmHistory_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvWinners)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.DataGridView dgvWinners;
	}
}