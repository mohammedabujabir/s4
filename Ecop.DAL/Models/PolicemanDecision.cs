using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecop.DAL.Models
{
    public class PolicemanDecision
    {
        [Key]
        public int PolicemanDecisionId { get; set; }

      public int Violationid { get; set; }
      public TrafficViolation TrafficViolation { get; set; }
        public int Policemanid { get; set; }
        public Policeman Policeman { get; set; }
        public string DecisionNotes { get; set; }
        public DateTime DecisionDate { get; set; }

        public bool ReferredToCourt { get; set; }

       public int? CourtDecisionId { get; set; }
      public CourtDecisions CourtDecision { get; set; }
    }
}
