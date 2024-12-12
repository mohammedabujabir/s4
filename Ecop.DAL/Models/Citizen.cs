using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecop.DAL.Models
{
    public class Citizen
    {
        [Key]
        public int CitizenId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
        public string Password { get; set; }

        public string Camera_id { get; set; }

      public ICollection<Car> Cars { get; set; }

       public ICollection<TrafficViolation> TrafficViolations { get; set; }
        public string UserId { get; set; } // مفتاح خارجي لربط المواطن بمستخدم 
        public ApplicationUser User { get; set; }
    }
}
