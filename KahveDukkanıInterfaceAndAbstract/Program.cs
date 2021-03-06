using KahveDukkaniInterfaceAndAbstract.Abstract;
using KahveDukkaniInterfaceAndAbstract.Adapter;
using KahveDukkaniInterfaceAndAbstract.Concrete;
using System;

namespace KahveDukkaniInterfaceAndAbstract
{
	class Program
	{
		static void Main(string[] args)
		{
			//BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
			BaseCustomerManager customerManager = new NeroCustomerManager();
			customerManager.Save(new Entities.Customer { FirstName = "Hamza", DateOfBirth = new DateTime(2001, 09, 04), Id = 1 ,LastName="Kavak",NationalId="45454545454"});


		}
	}
}
