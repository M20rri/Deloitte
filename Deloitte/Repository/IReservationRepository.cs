using Deloitte.ViewModel;
using System.Threading.Tasks;

namespace Deloitte.Repository
{
	public interface IReservationRepository
	{
		Task<ResonseMessage> Add(ReservationVM model);
	}
}