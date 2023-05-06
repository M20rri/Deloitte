using AutoMapper;
using Deloitte.Mapping;
using Deloitte.Models;
using Deloitte.Repository;
using Deloitte.ViewModel;
using System.Threading.Tasks;

namespace Deloitte.Service
{
	public class RoomService : IRoomRepository
	{
		private readonly DeloitteContext _deloitte;
		private readonly IMapper _mapper;

        public RoomService(DeloitteContext deloitte)
		{
			_deloitte = deloitte;
			_mapper = AutoMappingProfile._mapper;
		}
		public async Task<ResonseMessage> Add(RoomVM model)
		{
			var rm = _mapper.Map<Room>(model);
			_deloitte.Rooms.Add(rm);
			await _deloitte.SaveChangesAsync();
			return new ResonseMessage { Code = 200, Message = rm.Id.ToString() };
		}
	}
}