using KahveDukkaniInterfaceAndAbstract.Abstract;
using KahveDukkaniInterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveDukkaniInterfaceAndAbstract.Concrete
{
	public class NeroCustomerManager:BaseCustomerManager
	{
		public override void Save(Customer customer)
		{
			base.Save(customer);
		}
	}
}
