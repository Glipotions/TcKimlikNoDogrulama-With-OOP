using KahveDukkaniInterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveDukkaniInterfaceAndAbstract.Abstract
{
	public abstract class BaseCustomerManager : ICustomerService
	{
		public virtual void Save(Customer customer)
		{
			Console.WriteLine("Save in dB : "+customer.FirstName);
		}
	}
}
