using AutoMapper;
using Ecop.DAL.Data;
using Ecop.DAL.Models;
using Ecop.PL.Areas.Dashboard.ViewModels;
using Ecop.PL.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecop.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    [Authorize(Roles = "Citizen")]
    public class CitizensController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CitizensController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }



        public IActionResult Index()
        {
            var citizesn = context.Citizens.ToList();
            var citizensVm = mapper.Map<IEnumerable<CitizenVM>>(citizesn);
            return View(citizensVm);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
   
        public IActionResult Create(ViolationFormVM vm)
        {
            if (!ModelState.IsValid) { 
              return View(vm);
            }
            vm.Video_Url = FilesSetting.UploadFile(vm.Video,"video");
            var violation=mapper.Map<TrafficViolation>(vm);
            context.Add(violation);
            context.SaveChanges();
           return RedirectToAction(nameof(Index));
        }
    }
}
