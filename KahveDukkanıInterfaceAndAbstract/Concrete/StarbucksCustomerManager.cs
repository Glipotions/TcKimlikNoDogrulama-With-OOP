using KahveDukkaniInterfaceAndAbstract.Abstract;
using KahveDukkaniInterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveDukkaniInterfaceAndAbstract.Concrete
{
	public class StarbucksCustomerManager:BaseCustomerManager
	{
		private ICustomerCheckService customerCheckService;



		public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
		{
			this.customerCheckService = customerCheckService;
		}

		public override void Save(Customer customer)
		{
			if (customerCheckService.CheckIfRealPerson(customer))
			{
				base.Save(customer);
			}
			else { throw new Exception("Not a valid Person"); }
		}
	}
}
