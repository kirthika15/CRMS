using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRMS.Models
{
    public class Bookings
    {
        [Key]
        [Column(TypeName = "Guid")]
        public Guid BookingId { get; set; }

        [Column(TypeName = "Guid")]
        public Guid ConfRoomID { get; set; }

        [Column(TypeName = "Guid")]
        public Guid BookedByUserId { get; set; }

        [Column(TypeName = "Guid")]
        public Guid BookedForDeptID { get; set; }

        [Column(TypeName = "int")]
        public int BookedForCapacity { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string BookingStartDate { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string BookingStartTime { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string BookingEndDate { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string BookingEndTime { get; set; }

        [Column(TypeName = "bool")]
        public bool BookingStatus { get; set; }

        ConferenceRooms conferenceRooms { get; set; }

        Users users { get; set; }

        Departments departments { get; set; }
    }
}
