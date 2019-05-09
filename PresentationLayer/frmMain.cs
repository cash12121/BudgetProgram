using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataObjects;

namespace PresentationLayer
{
	public partial class frmMain : Form
	{
		private TransactionManager _transactionManager = new TransactionManager();
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			populate();
		}

		private void populate()
		{
			lstTransactions.Items.Clear();
			for (int i = 0; i < _transactionManager.TransactionList.Count; i++)
			{
				this.lstTransactions.Items.Add(_transactionManager.TransactionList[i].Name);
				this.lstTransactions.Items[this.lstTransactions.Items.Count - 1].SubItems.Add(_transactionManager.TransactionList[i].Date);
				this.lstTransactions.Items[this.lstTransactions.Items.Count - 1].SubItems.Add(_transactionManager.TransactionList[i].Type);
				this.lstTransactions.Items[this.lstTransactions.Items.Count - 1].SubItems.Add(_transactionManager.TransactionList[i].Amount);
			}

			lblIncome.Text = _transactionManager.CalulateIncome().ToString("c");
			lblExpenses.Text = _transactionManager.CalulateExpenses().ToString("c");
			lblTotal.Text = _transactionManager.CalulateTotal().ToString("c");
		}

		private void btnAddTransaction_Click(object sender, EventArgs e)
		{
			var addTransaction = new frmAddEditTransaction();
			addTransaction.ShowDialog();
			_transactionManager = new TransactionManager();
			populate();
		}

		private void BtnEditTransaction_Click(object sender, EventArgs e)
		{
			if(this.lstTransactions.SelectedIndices.Count > 0)
			{
				var editForm = new frmAddEditTransaction(lstTransactions.SelectedIndices[0], _transactionManager);
				editForm.ShowDialog();
				_transactionManager = new TransactionManager();
				populate();
			}
			else
			{
				MessageBox.Show("Nothing is Selected!");
			}
		}
	}
}
