using AspTrainingApp.Models;
using BusinessLayer.Abstract;
using BusinessLayer.Model;
using System.Web.Mvc;
using System.Web.Security;

namespace AspTrainingApp.Controllers
{
    public class AccountController : Controller
    {
        private IBLEntry _blEntry;
        public AccountController(IBLEntry blEntry)
        {
            _blEntry = blEntry;
        }
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserVO model)
        {
            if (ModelState.IsValid)
            {
                if (_blEntry.BusinessInteraction.Register(new RegisterModel { Name = model.Email, Password = model.Password, Age = model.Age }))
                {
                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "User with such login already exists");
            }

            return View(model);
        }
    }
}