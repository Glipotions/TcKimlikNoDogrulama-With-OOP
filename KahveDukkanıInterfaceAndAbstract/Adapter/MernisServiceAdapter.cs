using KahveDukkaniInterfaceAndAbstract.Abstract;
using KahveDukkaniInterfaceAndAbstract.Entities;
using MernisServiceReference;
using System;

namespace KahveDukkaniInterfaceAndAbstract.Adapter
{
	public class MernisServiceAdapter : ICustomerCheckService
	{
		public bool CheckIfRealPerson(Customer customer)
		{
			KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
			return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
		}
	}
}
