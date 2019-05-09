using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataObjects;

namespace LogicLayer
{
	public class TransactionManager
	{
		List<Transaction> _transactionList;

		public TransactionManager()
		{
			try
			{
				_transactionList = TransactionDataAccessor.RetrieveTransactionList();
			}
			catch (Exception)
			{

				throw;
			}
		} // end TransactionManager()

		public List<Transaction> TransactionList
		{
			get { return _transactionList;  }
		}

		public decimal CalulateIncome()
		{
			decimal totalIncome = 0.0m;

			for(int i = 0; i < _transactionList.Count; i++)
			{
				if(_transactionList[i].Type == "Income")
				{
					totalIncome += Decimal.Parse(_transactionList[i].Amount);
				}
			}
			return totalIncome;
		}
		public decimal CalulateExpenses()
		{
			decimal totalExpenses = 0.0m;

			for (int i = 0; i < _transactionList.Count; i++)
			{
				if (_transactionList[i].Type == "Expense")
				{
					totalExpenses += Decimal.Parse(_transactionList[i].Amount);
				}
			}
			return totalExpenses;
		}

		public decimal CalulateTotal()
		{
			decimal total = CalulateIncome() + CalulateExpenses();

				return total;
		}

		public List<Transaction> EditTransaction(Transaction transaction, int index)
		{
			try
			{
				_transactionList[index] = transaction;
				if (TransactionDataAccessor.UpdateTransaction(index, _transactionList))
				{
					_transactionList = TransactionDataAccessor.RetrieveTransactionList();
					return _transactionList;
				}
				return _transactionList;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public List<Transaction> AddTransaction(Transaction transaction)
		{
			try
			{
				if (TransactionDataAccessor.AddTransaction(transaction))
				{
					_transactionList = TransactionDataAccessor.RetrieveTransactionList();
				}
				return _transactionList;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
