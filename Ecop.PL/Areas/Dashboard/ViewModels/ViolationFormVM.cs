using Ecop.DAL.Models;

namespace Ecop.PL.Areas.Dashboard.ViewModels
{
    public class ViolationFormVM
    {
        public int TrafficViolationId { get; set; }

        public string Description { get; set; }
        public IFormFile Video { get; set; }

        public string? Video_Url { get; set; }
        public DateTime Reported_Date { get; set; }

        public string Car_Number { get; set; }

        public string Location { get; set; }
        public string Status { get; set; }
        public int CitizenId { get; set; }
    }
}
