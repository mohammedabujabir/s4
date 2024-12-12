using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecop.DAL.Models
{
    public class Court
    {
        [Key]
        public int CourtId { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string ContactInfo { get; set; }

        public string Password { get; set; }
       public ICollection<CourtDecisions> CourtDecisions { get; set; }
    }
}
