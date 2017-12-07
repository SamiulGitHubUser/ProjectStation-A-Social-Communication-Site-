using StationApp.App_Start.Injection;
using StationService.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StationApp.Controllers
{
    public class UserController : Controller
    {
        IUserService userService;

        public UserController()
        {
            //this.userService = new UserService();
            this.userService= Injector.Container.Resolve<IUserService>();
        }

        // GET: User
        public ActionResult Index()
        {
            return View("User",userService.GetAll());
        }
    }
}