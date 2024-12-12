using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecop.DAL.Models
{
    public class CourtDecisions
    {
        [Key]
        public int CourtDecisionsId { get; set; }

        public int Violationid { get; set; }
       public TrafficViolation ViolationStatus { get; set; }
        public int Courtid { get; set; }
       public Court Court { get; set; }
        public string Verdict { get; set; }

        public string Penalty { get; set; }
        public DateTime CoutDate { get; set; }

      public int? PoliceDecisionId { get; set; }
        public PolicemanDecision PoliceDecision { get; set; }

      public int JudgeId { get; set; }
      public Judge Judge { get; set; }
    }
}
