using Deloitte.Models;
using System.Data.Entity.Migrations;

namespace Deloitte.Migrations
{
	internal sealed class Configuration : DbMigrationsConfiguration<DeloitteContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(DeloitteContext context)
		{
			context.RoomTypes.AddOrUpdate(x => x.Id,
				new RoomType() { Type = "Single" },
				new RoomType() { Type = "Double" },
				new RoomType() { Type = "Studio" },
				new RoomType() { Type = "Deluxe" },
				new RoomType() { Type = "Suite" }
				);
		}
	}
}
