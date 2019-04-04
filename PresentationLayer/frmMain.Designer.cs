namespace PresentationLayer
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblIncome = new System.Windows.Forms.Label();
			this.lblExpenses = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnAddTransaction = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(248, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Income";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(786, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Expenses";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(1345, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "Total";
			// 
			// lblIncome
			// 
			this.lblIncome.AutoSize = true;
			this.lblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIncome.ForeColor = System.Drawing.Color.LimeGreen;
			this.lblIncome.Location = new System.Drawing.Point(179, 154);
			this.lblIncome.Name = "lblIncome";
			this.lblIncome.Size = new System.Drawing.Size(237, 76);
			this.lblIncome.TabIndex = 3;
			this.lblIncome.Text = "$00.00";
			// 
			// lblExpenses
			// 
			this.lblExpenses.AutoSize = true;
			this.lblExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExpenses.ForeColor = System.Drawing.Color.Red;
			this.lblExpenses.Location = new System.Drawing.Point(749, 154);
			this.lblExpenses.Name = "lblExpenses";
			this.lblExpenses.Size = new System.Drawing.Size(237, 76);
			this.lblExpenses.TabIndex = 4;
			this.lblExpenses.Text = "$00.00";
			// 
			// lblTotal
			// 
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(1278, 154);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(396, 76);
			this.lblTotal.TabIndex = 5;
			this.lblTotal.Text = "$00.00";
			// 
			// btnAddTransaction
			// 
			this.btnAddTransaction.Location = new System.Drawing.Point(655, 784);
			this.btnAddTransaction.Name = "btnAddTransaction";
			this.btnAddTransaction.Size = new System.Drawing.Size(406, 125);
			this.btnAddTransaction.TabIndex = 7;
			this.btnAddTransaction.Text = "Add Transaction";
			this.btnAddTransaction.UseVisualStyleBackColor = true;
			this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1686, 983);
			this.Controls.Add(this.btnAddTransaction);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblExpenses);
			this.Controls.Add(this.lblIncome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Overview";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblExpenses;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblIncome;
		private System.Windows.Forms.Button btnAddTransaction;
	}
}

