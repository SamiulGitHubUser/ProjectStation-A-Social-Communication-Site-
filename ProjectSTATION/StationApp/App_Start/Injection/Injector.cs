using Injection;
using Injection.Interfaces;
using StationService.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationApp.App_Start.Injection
{
    public class Injector
    {
        public static IInjectionContainer Container { get; set; }

        static Injector()
        {
            Container = new Container();
        }

        public static void Configure()
        {

            Container.Register<IUserService, UserService>().Singleton();
            //Container.Register<DepartmentController, DepartmentController>();
            //ControllerBuilder.Current.SetControllerFactory(new InjectionControllerFactory());
        }
    }
}