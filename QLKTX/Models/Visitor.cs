using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Models
{
    public class Visitor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int RoomId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        public string? Phone { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        public string? Reason { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("RoomId")]
        public Room Room { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public Visitor()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}