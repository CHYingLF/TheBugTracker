using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TheBugTracker.Models
{
    public class TicketComment
    {
        public int Id { get; set; }

        [DisplayName("Member Comment")]
        public string Comment { get; set; }

        //Created
        [DisplayName("Date")]
        public DateTimeOffset Created { get; set; }

        //TicketId
        [DisplayName("Ticket")]
        public int TicketId { get; set; }

        //UserId
        [DisplayName("Team Member")]
        public string UserId { get; set; }


        //--Navigation properties--//
        //Ticket
        public virtual Ticket Ticket { get; set; }
        //User
        public virtual BTUser User { get; set; }
 
    }
}
