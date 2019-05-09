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
			this.lstTransactions = new System.Windows.Forms.ListView();
			this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnEditTransaction = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(93, 24);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Income";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(295, 24);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Expenses";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(504, 24);
			this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Total";
			// 
			// lblIncome
			// 
			this.lblIncome.AutoSize = true;
			this.lblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIncome.ForeColor = System.Drawing.Color.LimeGreen;
			this.lblIncome.Location = new System.Drawing.Point(69, 65);
			this.lblIncome.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.lblIncome.Name = "lblIncome";
			this.lblIncome.Size = new System.Drawing.Size(97, 31);
			this.lblIncome.TabIndex = 3;
			this.lblIncome.Text = "$00.00";
			this.lblIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblExpenses
			// 
			this.lblExpenses.AutoSize = true;
			this.lblExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExpenses.ForeColor = System.Drawing.Color.Red;
			this.lblExpenses.Location = new System.Drawing.Point(278, 65);
			this.lblExpenses.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.lblExpenses.Name = "lblExpenses";
			this.lblExpenses.Size = new System.Drawing.Size(97, 31);
			this.lblExpenses.TabIndex = 4;
			this.lblExpenses.Text = "$00.00";
			this.lblExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTotal
			// 
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(451, 64);
			this.lblTotal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(148, 32);
			this.lblTotal.TabIndex = 5;
			this.lblTotal.Text = "$00.00";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAddTransaction
			// 
			this.btnAddTransaction.Location = new System.Drawing.Point(179, 325);
			this.btnAddTransaction.Margin = new System.Windows.Forms.Padding(1);
			this.btnAddTransaction.Name = "btnAddTransaction";
			this.btnAddTransaction.Size = new System.Drawing.Size(152, 52);
			this.btnAddTransaction.TabIndex = 7;
			this.btnAddTransaction.Text = "Add Transaction";
			this.btnAddTransaction.UseVisualStyleBackColor = true;
			this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
			// 
			// lstTransactions
			// 
			this.lstTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDate,
            this.colType,
            this.colAmount});
			this.lstTransactions.FullRowSelect = true;
			this.lstTransactions.GridLines = true;
			this.lstTransactions.Location = new System.Drawing.Point(61, 134);
			this.lstTransactions.Name = "lstTransactions";
			this.lstTransactions.Size = new System.Drawing.Size(552, 169);
			this.lstTransactions.TabIndex = 0;
			this.lstTransactions.UseCompatibleStateImageBehavior = false;
			this.lstTransactions.View = System.Windows.Forms.View.Details;
			// 
			// colName
			// 
			this.colName.Text = "Name";
			this.colName.Width = 138;
			// 
			// colDate
			// 
			this.colDate.Text = "Date";
			this.colDate.Width = 138;
			// 
			// colType
			// 
			this.colType.Text = "Type";
			this.colType.Width = 138;
			// 
			// colAmount
			// 
			this.colAmount.Text = "Amount";
			this.colAmount.Width = 138;
			// 
			// btnEditTransaction
			// 
			this.btnEditTransaction.Location = new System.Drawing.Point(344, 325);
			this.btnEditTransaction.Name = "btnEditTransaction";
			this.btnEditTransaction.Size = new System.Drawing.Size(152, 52);
			this.btnEditTransaction.TabIndex = 8;
			this.btnEditTransaction.Text = "Edit Transaction";
			this.btnEditTransaction.UseVisualStyleBackColor = true;
			this.btnEditTransaction.Click += new System.EventHandler(this.BtnEditTransaction_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(657, 408);
			this.Controls.Add(this.btnEditTransaction);
			this.Controls.Add(this.lstTransactions);
			this.Controls.Add(this.btnAddTransaction);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblExpenses);
			this.Controls.Add(this.lblIncome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(1);
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
		private System.Windows.Forms.ListView lstTransactions;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ColumnHeader colDate;
		private System.Windows.Forms.ColumnHeader colType;
		private System.Windows.Forms.ColumnHeader colAmount;
		private System.Windows.Forms.Button btnEditTransaction;
	}
}

