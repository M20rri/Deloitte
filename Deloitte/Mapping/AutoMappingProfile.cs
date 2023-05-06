using AutoMapper;
using Deloitte.Models;
using Deloitte.ViewModel;

namespace Deloitte.Mapping
{
	public class AutoMappingProfile
	{
		public static IMapper _mapper { get; private set; }

		public static void Init()
		{
			var config = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<Customer, CustomerVM>().ReverseMap();
				cfg.CreateMap<Room, RoomVM>().ReverseMap();
				cfg.CreateMap<Reservation, ReservationVM>().ReverseMap();
			});
			_mapper = config.CreateMapper();
		}
	}
}