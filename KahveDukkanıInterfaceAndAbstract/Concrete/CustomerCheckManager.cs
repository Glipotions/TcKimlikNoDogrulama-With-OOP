using KahveDukkaniInterfaceAndAbstract.Abstract;
using KahveDukkaniInterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveDukkaniInterfaceAndAbstract.Concrete
{
	public class CustomerCheckManager : ICustomerCheckService
	{
		public bool CheckIfRealPerson(Customer customer)
		{
			return true;
		}
	}
}
