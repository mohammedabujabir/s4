using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecop.DAL.Models
{
    public class Policeman
    {
        [Key]
        public int PolicemanId { get; set; }

        public string Name { get; set; }

        public string Badge_Number { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

      public ICollection<PolicemanDecision> Decisions { get; set; }
        public string UserId { get; set; } // مفتاح خارجي لربط المواطن بمستخدم 
        public ApplicationUser User { get; set; }
    }
}
