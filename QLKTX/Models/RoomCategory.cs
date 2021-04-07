using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Models
{
    public class RoomCategory
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        public string Name { get; set; }
        public float Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Room> Rooms { get; set; }


        public RoomCategory()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}