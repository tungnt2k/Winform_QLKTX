using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Models
{
    public class ParkingTurn
    {
        [Key]
        public int Id { get; set; }
        public int TicketId { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        public string Note { get; set; }
        public int NumOfTurn { get; set; }
        public bool Status { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("TicketId")]
        public ParkingMonthlyTicket Ticket { get; set; }

        public ParkingTurn()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}