using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Deloitte.Models
{
	[Table("Customer")]
    public partial class Customer
    {
        public Customer()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }

        [StringLength(225)]
        public string Name { get; set; }

        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string Emai { get; set; }

        public DateTime? DatefBirth { get; set; }

		public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
