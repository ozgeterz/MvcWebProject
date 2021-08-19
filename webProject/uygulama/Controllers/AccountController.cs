using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uygulama.Entity;
using uygulama.Identitiy;
using uygulama.Models;
using Microsoft.Owin.Security;


namespace uygulama.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;
        public AccountController()
        {
            var userStore =
                  new UserStore<ApplicationUser>(new IdentityDataContext());


            UserManager = new UserManager<ApplicationUser>(userStore);


            var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());
            RoleManager = new RoleManager<ApplicationRole>(roleStore);
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)

        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser();
                
                user.Name = model.Name;
                user.Surname = model.Surname;
                user.UserName = model.Username;

                user.Email = model.Email;

                IdentityResult result = UserManager.Create(user, model.Password);

                if (result.Succeeded)
                {
                    //kullanıcı oluştu ve kullanıcıya bir role atayabilirsiniz.
                    if (RoleManager.RoleExists("user"))
                    {
                        UserManager.AddToRole(user.Id, "user");
                    }
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("RegisterUserError", "Kullanıcı oluşturma hatası.");

                }

                //kayıt işlemleri
            }

            return View(model);
        }





        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model)

        {

            if (ModelState.IsValid)
            {
                var user = UserManager.Find(model.Username, model.Password);

                if (user != null)
                {
                    //varolan kullanıcıyı sisteme dahil et.
                    //ApplicationCookie oluşturup sisteme bırak.
                    var authManager = HttpContext.GetOwinContext().Authentication;
                    var identityclaims = UserManager.CreateIdentity(user, "ApplicationCookie");
                    var authProperties = new AuthenticationProperties();
                    authProperties.IsPersistent = model.Hatirla;
                    authManager.SignIn(authProperties, identityclaims);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("LoginUserError", "Böyle bir kullanıcı yok");
                }
                //giriş işlemleri
            }

            return View(model);
        }


        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();

            return RedirectToAction("Index", "Home");
        }
    }
}