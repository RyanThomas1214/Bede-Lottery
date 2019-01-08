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
			this.btnGenerate = new System.Windows.Forms.Button();
			this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtNumber = new System.Windows.Forms.TextBox();
			this.lblNumber = new System.Windows.Forms.Label();
			this.dgvWinners = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvWinners)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(27, 33);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(150, 49);
			this.btnBack.TabIndex = 0;
			this.btnBack.Text = "BACK";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerate.Location = new System.Drawing.Point(341, 253);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(346, 77);
			this.btnGenerate.TabIndex = 3;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
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
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(262, 677);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(150, 49);
			this.btnSave.TabIndex = 19;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtNumber
			// 
			this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumber.Location = new System.Drawing.Point(235, 270);
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(100, 49);
			this.txtNumber.TabIndex = 20;
			this.txtNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// lblNumber
			// 
			this.lblNumber.AutoSize = true;
			this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumber.Location = new System.Drawing.Point(12, 270);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(217, 37);
			this.lblNumber.TabIndex = 21;
			this.lblNumber.Text = "Enter Number";
			// 
			// dgvWinners
			// 
			this.dgvWinners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvWinners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvWinners.Location = new System.Drawing.Point(13, 408);
			this.dgvWinners.Name = "dgvWinners";
			this.dgvWinners.RowTemplate.Height = 33;
			this.dgvWinners.Size = new System.Drawing.Size(657, 228);
			this.dgvWinners.TabIndex = 22;
			// 
			// frmAwardPrize
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 881);
			this.Controls.Add(this.dgvWinners);
			this.Controls.Add(this.lblNumber);
			this.Controls.Add(this.txtNumber);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.btnBack);
			this.Name = "frmAwardPrize";
			this.Text = "frmAwardPrize";
			this.Load += new System.EventHandler(this.frmAwardPrize_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvWinners)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnGenerate;
		private System.DirectoryServices.DirectoryEntry directoryEntry1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtNumber;
		private System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.DataGridView dgvWinners;
	}
}