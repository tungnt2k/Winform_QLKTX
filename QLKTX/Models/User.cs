using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(30)]
        public string Phone { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string StudentCode { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string SchoolYear { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Address { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime BirthDay { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<UserRoom> UserRooms { get; set; }
        public ICollection<UserUseService> UserUseServices { get; set; }
        public ICollection<Visitor> Visitors { get; set; }
        public ICollection<ParkingMonthlyTicket> ParkingMonthlyTickets{ get; set; }

        public User()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}
