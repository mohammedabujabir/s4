using Ecop.DAL.Models;
using Ecop.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace Ecop.PL.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
      

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {

                var user = userManager.FindByEmailAsync(model.Email);

                if (user is not null)
                {
                    var check = await userManager.CheckPasswordAsync(await user, model.Password);

                    if (check)
                    {
                        var result = await signInManager.PasswordSignInAsync(await user, model.Password, model.RememberMe, false);
                        if (result.Succeeded)
                        {

                            return RedirectToAction("Index", "Home");
                        }

                    }
                }
            }
            return View(model);
        }
    }
}
