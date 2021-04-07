using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int BuildingId { get; set; }
        [Required]
        public int CateId { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        public string Name { get; set; }
        public int MaxPeople { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("BuildingId")]
        public Building Building { get; set; }
        [ForeignKey("CateId")]
        public RoomCategory RoomCategory { get; set; }
        public ICollection<UserRoom> UserRooms { get; set; }
        public ICollection<Visitor> Visitors { get; set; }

        public Room()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}