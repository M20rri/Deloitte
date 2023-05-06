using Deloitte.ViewModel;
using System.Threading.Tasks;

namespace Deloitte.Repository
{
	public interface ICustomerRepository
	{
		Task<ResonseMessage> Add(CustomerVM model);
	}
}