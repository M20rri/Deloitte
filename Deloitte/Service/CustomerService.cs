using AutoMapper;
using Deloitte.Mapping;
using Deloitte.Models;
using Deloitte.Repository;
using Deloitte.ViewModel;
using System.Threading.Tasks;

namespace Deloitte.Service
{
	public class CustomerService : ICustomerRepository
	{
		private readonly DeloitteContext _deloitte;
		private readonly IMapper _mapper;
		public CustomerService(DeloitteContext deloitte)
		{
			_deloitte = deloitte;
			_mapper = AutoMappingProfile._mapper;
		}

		public async Task<ResonseMessage> Add(CustomerVM model)
		{
			var cust = _mapper.Map<Customer>(model);
			_deloitte.Customers.Add(cust);
			await _deloitte.SaveChangesAsync();
			return new ResonseMessage { Code = 200, Message = cust.Id.ToString() };
		}
	}
}