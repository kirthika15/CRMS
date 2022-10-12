using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRMS.Models
{
    public class ConferenceRooms
    {
        [Key]
        [Column(TypeName = "Guid")]
        public int ConfRoomId { get; set; }

        [Column(TypeName = "Guid")]
        public int ConfRoomTypeId { get; set; }

        [Column(TypeName = "int")]
        public int ConfRoomCapacity { get; set; }

        [Column(TypeName = "Guid")]
        public int ConfRoomManagerId { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string ConfRoomLocation { get; set; }

        ConferenceRoomType conferenceRoomType { get; set; }

        Users users { get; set; }

    }
}
