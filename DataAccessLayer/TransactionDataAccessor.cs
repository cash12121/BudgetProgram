using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using System.IO;

namespace DataAccessLayer
{
	public class TransactionDataAccessor
	{
		public static List<Transaction> RetrieveTransactionList()
		{
			List<Transaction> transactionList = new List<Transaction>();

			char[] separator = { ',' };
			try
			{
				StreamReader fileReader = new StreamReader(AppData.DataPath + @"\" + AppData.TransactionListName);
				while (fileReader.EndOfStream == false)
				{
					string line = fileReader.ReadLine();
					string[] parts;
					if(line.Length > 3)
					{
						parts = line.Split(separator);
						if(parts.Count() == 4)
						{
							Transaction newTransaction = new Transaction();
							newTransaction.Name = parts[0];
							newTransaction.Date = parts[1];
							newTransaction.Type = parts[2];
							newTransaction.Amount = parts[3];

							transactionList.Add(newTransaction);
						}
					}
				}
				fileReader.Close();
			}
			catch (Exception)
			{
				throw;
			}

			return transactionList;
		}// end of RetrieveTransactionList()

		public static bool UpdateTransaction(int index, List<Transaction> transactions)
		{
			try
			{
				StreamWriter fileWriter = new StreamWriter(AppData.DataPath + @"\" + AppData.TransactionListName);
				foreach (Transaction transaction in transactions)
				{
					fileWriter.WriteLine(transaction.Name + ","
						+ transaction.Date + ","
						+ transaction.Type + "," 
						+ transaction.Amount);
				}
				fileWriter.Close();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		} // end of UpdateTransaction()

		public static bool AddTransaction(Transaction transaction)
		{
			try
			{
				StreamWriter fileWriter = new StreamWriter(AppData.DataPath + @"\" + AppData.TransactionListName, true);
				fileWriter.WriteLine(transaction.Name + ","
						+ transaction.Date + ","
						+ transaction.Type + ","
						+ transaction.Amount);
				fileWriter.Close();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}
	}
}
