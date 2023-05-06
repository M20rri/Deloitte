using System;

namespace Deloitte.ViewModel
{
	public class ReservationVM
	{
		public int? Id { get; set; }

		public DateTime? ReserveDate { get; set; }

		public int? RoomId { get; set; }

		public int? CustomerId { get; set; }

		public int? NoOfNights { get; set; }

		public double? Price { get; set; }
	}
}