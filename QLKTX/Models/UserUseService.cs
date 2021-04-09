using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Models
{
    public class UserUseService
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ServiceId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        public string Note { get; set; }
        public float Price { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("ServiceId")]
        public Service Service { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public UserUseService()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}