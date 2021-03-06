using KahveDukkaniInterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveDukkaniInterfaceAndAbstract.Abstract
{
	public interface ICustomerCheckService
	{
		bool CheckIfRealPerson(Customer customer);
	}
}
