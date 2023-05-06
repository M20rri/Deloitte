using AutoMapper;
using Deloitte.Mapping;
using Deloitte.Models;
using Deloitte.Repository;
using Deloitte.ViewModel;
using System.Threading.Tasks;

namespace Deloitte.Service
{
	public class ReservationService : IReservationRepository
	{
		private readonly DeloitteContext _deloitte;
		private readonly IMapper _mapper;
		public ReservationService(DeloitteContext deloitte)
		{
			_deloitte = deloitte;
			_mapper = AutoMappingProfile._mapper;
		}
		public async Task<ResonseMessage> Add(ReservationVM model)
		{
			var rs = _mapper.Map<Reservation>(model);
			_deloitte.Reservations.Add(rs);
			await _deloitte.SaveChangesAsync();
			return new ResonseMessage { Code = 200, Message = rs.Id.ToString() };
		}
	}
}