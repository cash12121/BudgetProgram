using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
	public class Transaction
	{
		// Reperesent a Line from the CSV
		public string Name { get; set; }
		public string Date { get; set; }
		public string Type { get; set; } 
		public string Amount { get; set; }
	}
}
