using Deloitte.Repository;
using Deloitte.ViewModel;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Deloitte.Controllers
{
	public class DeloitteController : Controller
	{
		private readonly ICustomerRepository _customerRepository;
		private readonly IRoomRepository _roomRepository;
		private readonly IReservationRepository  _reservationRepository;

		public DeloitteController(ICustomerRepository customerRepository, IRoomRepository roomRepository , IReservationRepository reservationRepository)
		{
			_customerRepository = customerRepository;
			_roomRepository = roomRepository;
			_reservationRepository = reservationRepository;	
		}	

		// POST: Deloitte/CreateCustomer
		[HttpPost]
		public async Task<ActionResult> CreateCustomer(CustomerVM model)
		{
			var response = await _customerRepository.Add(model);
			return Json(response, JsonRequestBehavior.AllowGet);
		}

		// POST: Deloitte/CreateRoom
		[HttpPost]
		public async Task<ActionResult> CreateRoom(RoomVM model)
		{
			var response = await _roomRepository.Add(model);
			return Json(response, JsonRequestBehavior.AllowGet);
		}


		// POST: Deloitte/Reserve
		[HttpPost]
		public async Task<ActionResult> Book(ReservationVM model)
		{
			var response = await _reservationRepository.Add(model);
			return Json(response, JsonRequestBehavior.AllowGet);
		}
	}
}