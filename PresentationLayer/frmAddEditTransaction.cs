using System;
using System.Windows.Forms;
using LogicLayer;
using DataObjects;

namespace PresentationLayer
{
	public partial class frmAddEditTransaction : Form
	{
		bool editMode;
		string dataPath = Application.StartupPath + @"\TransactionData";

		TransactionManager _transactionManager;
		int _transactionIndex;

		public frmAddEditTransaction() // add mode
		{
			editMode = false;
			_transactionManager = new TransactionManager();

			InitializeComponent();
		}

		public frmAddEditTransaction(int transactionIndex, TransactionManager transactionManager)
		{
			editMode = true;
			_transactionManager = transactionManager;
			_transactionIndex = transactionIndex;

			InitializeComponent();
		}

		private void FrmAddEditTransaction_Load(object sender, EventArgs e)
		{
			if(editMode == true)
			{
				this.txtTransactionName.Text = _transactionManager.TransactionList[_transactionIndex].Name;
				this.dtpDate.Value = DateTime.Parse(_transactionManager.TransactionList[_transactionIndex].Date);
				this.cmbTransactionType.Text = _transactionManager.TransactionList[_transactionIndex].Type;
				this.numAmount.Value = Decimal.Parse(_transactionManager.TransactionList[_transactionIndex].Amount);

				this.Text = "Edit a Transaction";
			} else
			{
				this.Text = "Add a Transaction";
			}
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			//check if fields are blank
			if(txtTransactionName.Text == "")
			{
				MessageBox.Show("You need to enter a Transaction Name");
				txtTransactionName.Focus();
				return;
			}
			if (cmbTransactionType.SelectedItem == null)
			{
				MessageBox.Show("You need to Select a Type");
				cmbTransactionType.Focus();
				return;
			}
			if (numAmount.Value == 0.00m)
			{
				MessageBox.Show("Amount Value needs to be above 0.00");
				numAmount.Focus();
				return;
			}

			//create objects
			var transaction = new Transaction();
			transaction.Name = txtTransactionName.Text;
			transaction.Date = dtpDate.Value.ToString("yyyy-MM-dd");
			transaction.Type = cmbTransactionType.SelectedItem.ToString();

			// create object for amount value depentent on transaction type
			if (cmbTransactionType.SelectedIndex == 0) //Income
			{
				transaction.Amount = numAmount.Value.ToString();
			}
			else //Expense
			{
				decimal newAmount = numAmount.Value * -1;
				transaction.Amount = newAmount.ToString();
			}
			

			//save record
			if(editMode == true)
			{
				_transactionManager.EditTransaction(transaction, _transactionIndex);
				this.Close();
			}
			else
			{
				int transactionCount = _transactionManager.TransactionList.Count;
				var newList = _transactionManager.AddTransaction(transaction);
				if (newList.Count > transactionCount)
				{
					MessageBox.Show("New Transaction Added.");
					this.Close();
				}
				else
				{
					MessageBox.Show("Add Failed.");
					this.Close();
				}
			}
		}
	}
}
