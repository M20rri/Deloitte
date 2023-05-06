using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Deloitte.Models
{
	[Table("RoomType")]
    public partial class RoomType
    {
		public RoomType()
        {
            Rooms = new HashSet<Room>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

		public virtual ICollection<Room> Rooms { get; set; }
    }
}
