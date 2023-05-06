using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Deloitte.Models
{
	[Table("Reservation")]
    public partial class Reservation
    {
        public int Id { get; set; }

        public DateTime? ReserveDate { get; set; }

        public int? RoomId { get; set; }

        public int? CustomerId { get; set; }

        public int? NoOfNights { get; set; }

        public double? Price { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Room Room { get; set; }
    }
}
