using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecop.DAL.Models
{
    public class TrafficViolation
    {
        [Key]
        public int TrafficViolationId { get; set; }

        public string Description { get; set; }

        public string Video_Url { get; set; }

        public DateTime Reported_Date { get; set; }

        public string Car_Number { get; set; }

        public string Location { get; set; }
        public string Status { get; set; }
        public int CitizenId { get; set; }
 
       public Citizen Citizen { get; set; }
     
      public int? DecisionId { get; set; }  // يمكن أن يكون null إذا لم يتم اتخاذ قرار بعد
       public PolicemanDecision Decision { get; set; }  // القرار المرتبط بالمخالفة
        public int? CourtDecisionId { get; set; }
        public CourtDecisions CourtDecision { get; set; }
    }
}
