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
			this.lblEmployee = new System.Windows.Forms.Label();
			this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
			this.lblPrize = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblNameTag = new System.Windows.Forms.Label();
			this.lblIdTag = new System.Windows.Forms.Label();
			this.lblId = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblPrizeName = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
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
			// btnGenerate
			// 
			this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerate.Location = new System.Drawing.Point(88, 261);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(346, 77);
			this.btnGenerate.TabIndex = 3;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
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
			// lblPrize
			// 
			this.lblPrize.AutoSize = true;
			this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrize.Location = new System.Drawing.Point(292, 443);
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
			// lblNameTag
			// 
			this.lblNameTag.AutoSize = true;
			this.lblNameTag.Location = new System.Drawing.Point(22, 579);
			this.lblNameTag.Name = "lblNameTag";
			this.lblNameTag.Size = new System.Drawing.Size(80, 25);
			this.lblNameTag.TabIndex = 11;
			this.lblNameTag.Text = "Name: ";
			// 
			// lblIdTag
			// 
			this.lblIdTag.AutoSize = true;
			this.lblIdTag.Location = new System.Drawing.Point(22, 520);
			this.lblIdTag.Name = "lblIdTag";
			this.lblIdTag.Size = new System.Drawing.Size(35, 25);
			this.lblIdTag.TabIndex = 12;
			this.lblIdTag.Text = "Id:";
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(121, 520);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(0, 25);
			this.lblId.TabIndex = 14;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(121, 579);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(0, 25);
			this.lblName.TabIndex = 13;
			// 
			// lblPrizeName
			// 
			this.lblPrizeName.AutoSize = true;
			this.lblPrizeName.Location = new System.Drawing.Point(446, 520);
			this.lblPrizeName.Name = "lblPrizeName";
			this.lblPrizeName.Size = new System.Drawing.Size(0, 25);
			this.lblPrizeName.TabIndex = 15;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(446, 579);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(0, 25);
			this.lblDescription.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(294, 579);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 25);
			this.label1.TabIndex = 18;
			this.label1.Text = "Description:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(294, 520);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 25);
			this.label2.TabIndex = 17;
			this.label2.Text = "Name:";
			// 
			// frmAwardPrize
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(819, 897);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblPrizeName);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblIdTag);
			this.Controls.Add(this.lblNameTag);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblPrize);
			this.Controls.Add(this.lblEmployee);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.btnBack);
			this.Name = "frmAwardPrize";
			this.Text = "frmAwardPrize";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Label lblEmployee;
		private System.DirectoryServices.DirectoryEntry directoryEntry1;
		private System.Windows.Forms.Label lblPrize;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblNameTag;
		private System.Windows.Forms.Label lblIdTag;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblPrizeName;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}