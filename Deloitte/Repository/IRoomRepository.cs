using Deloitte.ViewModel;
using System.Threading.Tasks;

namespace Deloitte.Repository
{
	public interface IRoomRepository
	{
		Task<ResonseMessage> Add(RoomVM model);
	}
}
