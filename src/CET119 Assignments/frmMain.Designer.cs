namespace CET119_Assignments
{
	partial class frmMain
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
			this.components = new System.ComponentModel.Container();
			this.btnHelp = new System.Windows.Forms.Button();
			this.btnPickWinner = new System.Windows.Forms.Button();
			this.btnPreviousWinners = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.lblTitle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnHelp
			// 
			this.btnHelp.Location = new System.Drawing.Point(1487, 47);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(81, 70);
			this.btnHelp.TabIndex = 0;
			this.btnHelp.Text = "HELP";
			this.btnHelp.UseVisualStyleBackColor = true;
			// 
			// btnPickWinner
			// 
			this.btnPickWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPickWinner.Location = new System.Drawing.Point(40, 381);
			this.btnPickWinner.Name = "btnPickWinner";
			this.btnPickWinner.Size = new System.Drawing.Size(713, 212);
			this.btnPickWinner.TabIndex = 1;
			this.btnPickWinner.Text = "Pick Winner";
			this.btnPickWinner.UseVisualStyleBackColor = true;
			this.btnPickWinner.Click += new System.EventHandler(this.btnPickWinner_Click);
			// 
			// btnPreviousWinners
			// 
			this.btnPreviousWinners.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPreviousWinners.Location = new System.Drawing.Point(855, 381);
			this.btnPreviousWinners.Name = "btnPreviousWinners";
			this.btnPreviousWinners.Size = new System.Drawing.Size(713, 212);
			this.btnPreviousWinners.TabIndex = 2;
			this.btnPreviousWinners.Text = "View Previous Winners\r\n";
			this.btnPreviousWinners.UseVisualStyleBackColor = true;
			this.btnPreviousWinners.Click += new System.EventHandler(this.btnPreviousWinners_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(52, 38);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(422, 79);
			this.lblTitle.TabIndex = 4;
			this.lblTitle.Text = "Bede Lottery";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1616, 854);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnPreviousWinners);
			this.Controls.Add(this.btnPickWinner);
			this.Controls.Add(this.btnHelp);
			this.Name = "frmMain";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.Button btnPickWinner;
		private System.Windows.Forms.Button btnPreviousWinners;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label lblTitle;
	}
}

