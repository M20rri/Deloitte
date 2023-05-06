using System.Data.Entity;

namespace Deloitte.Models
{
	public class DeloitteContext : DbContext
	{
		public DeloitteContext()
			: base("name=DeloitteContext")
		{
		}

		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<Reservation> Reservations { get; set; }
		public virtual DbSet<Room> Rooms { get; set; }
		public virtual DbSet<RoomType> RoomTypes { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
