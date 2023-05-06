using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Deloitte.Models
{
	[Table("Room")]
    public partial class Room
    {
		public Room()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }

        public int? RoomTypeId { get; set; }

        public double? PricePerNight { get; set; }

        public int? Floor { get; set; }

        public int? NoOfBeds { get; set; }

		public virtual ICollection<Reservation> Reservations { get; set; }

        public virtual RoomType RoomType { get; set; }
    }
}
